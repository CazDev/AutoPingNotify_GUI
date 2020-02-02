using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoPingNotify_GUI
{
    internal class Monitor
    {
        private static PerformanceCounter cpucounter;

        private static double cpuUsage;

        private static long avgReplyTime;

        private static int errorCount;

        private static bool running = true;

        public static void StartScaning(string hostsFile, string localhostsFile)
        {
            while (running)
            {
                //Start pinging
                string[] hostList = File.ReadAllLines(hostsFile);

                if (hostList.Length > 0)
                {
                    foreach (string host in hostList)
                    {
                        Output.WriteLine("Pinging " + host, Color.LightBlue);

                        String message = Monitor.PingHost(host);

                        if (message.Contains("Error"))
                        {
                            if (Monitor.errorCount >= 3)
                            {
                                //Host is offline
                                Email.Send("APN: Host: " + host + " is offline", message, SaveState.values);
                            }
                        }
                        else if (Monitor.avgReplyTime > SaveState.values.replyTimeThreshold)
                        {
                            //Host response is slow
                            Email.Send("APN: Host: " + host + " ping theshold reached", host + " responded with an average response time of: " + Monitor.avgReplyTime + "ms", SaveState.values);
                        }
                    }
                }
                else
                {
                    Output.LogAppend("hosts.txt file is empty! Please add hosts to ping. \n", Color.White);
                }

                string[] localhostList = File.ReadAllLines(localhostsFile);

                if (hostList.Length > 0)
                {
                    foreach (string localhost in localhostList)
                    {
                        string message = Monitor.CPU(localhost, SaveState.values); // Measure resource usage

                        if (message.Contains("Error")) // Send email for errors
                        {
                            Email.Send("APN: Local Host: " + localhost + " is offline", message, SaveState.values);
                        }
                        else if (Monitor.cpuUsage > SaveState.values.cpuUsageThreshold) // Send email for high CPU usage
                        {
                            Email.Send("APN: Local Host: " + localhost + " CPU usage is higher than theshold", message, SaveState.values);
                        }
                    }
                }

                // Wait to ping again
                Output.WriteLine("Waiting " + SaveState.values.pingInterval / 1000 + " seconds... \n", Color.LightBlue);
                Thread.Sleep(SaveState.values.pingInterval);
            }
        } // Ping and get CPU loop reads hosts.txt and localhosts.txt

        public static String PingHost(string host)
        {
            //Returned Message
            String Message = "Host is online \n";

            //IPAddress instance for holding the returned host
            IPAddress address = GetIpFromHost(ref host);

            //set the ping options, TTL 128
            PingOptions pingOptions = new PingOptions(128, true);

            //create a new ping instance
            Ping ping = new Ping();

            //32 byte buffer (create empty)
            byte[] buffer = new byte[32];

            // amount of times the host is pinged
            int pings = 4;

            //first make sure we actually have an internet connection
            if (HasConnection())
            {
                errorCount = 0;
                avgReplyTime = 0;
                //here we will ping the host 4 times (standard)
                for (int i = 0; i < pings; i++)
                {
                    try
                    {
                        //send the ping 4 times to the host and record the returned data.
                        //The Send() method expects 4 items:
                        //1) The IPAddress we are pinging
                        //2) The timeout value
                        //3) A buffer (our byte array)
                        //4) PingOptions

                        PingReply pingReply = ping.Send(address, 1000, buffer, pingOptions);

                        //make sure we dont have a null reply
                        if ((pingReply != null))
                        {
                            switch (pingReply.Status)
                            {
                                // Ping reply
                                case IPStatus.Success:
                                    Output.LogAppend(string.Format("Reply from {0}: bytes={1} time={2}ms TTL={3} \n", pingReply.Address, pingReply.Buffer.Length, pingReply.RoundtripTime, pingReply.Options.Ttl), Color.White);
                                    avgReplyTime += pingReply.RoundtripTime;
                                    break;

                                // Ping timed out
                                case IPStatus.TimedOut:
                                    Message = string.Format("Error: Connection to the host: {0} [{1}] has timed out...", pingReply.Address, host);
                                    Output.WriteLine(Message, Color.OrangeRed);
                                    errorCount++;
                                    break;

                                // Ping failed
                                default:
                                    Message = string.Format("Error: Ping failed: {0}", pingReply.Status.ToString());
                                    Output.WriteLine(Message, Color.OrangeRed);
                                    errorCount++;
                                    break;
                            }
                        }
                        else
                        {
                            Message = "Error: Connection failed...";
                            errorCount++;
                        }
                    }
                    catch (ArgumentNullException) // IP address was not set from hostname
                    {
                        Message = "Error: Remote host was not found";
                        errorCount++;
                    }
                    catch (NullReferenceException) // No host exists
                    {
                        Message = "Error: Remote host was not found";
                        errorCount++;
                    }
                    catch (Exception ex) // Any other unforseen scenarios
                    {
                        Message = "Unexpected error: " + ex.Message;
                        errorCount++;
                    }
                }
            }
            else
            {
                Message = "Error: No Internet connection found..."; // HasConnection() returned false
            }

            avgReplyTime = avgReplyTime / pings; // Calculate average ping time in miliseconds
            Output.WriteLine("Average response time: " + avgReplyTime + "ms", Color.LightBlue);

            if (Message.Contains("Error")) // Check if Message has error to determine text colour
            {
                Output.WriteLine(Message, Color.OrangeRed); // Red text error
            }
            else
            {
                Output.WriteLine(Message, Color.LightGreen); // Green text success
            }

            return Message;
        }

        public static String CPU(string localhost, SaveState.Values values) // Method to measure resource usage
        {
            string Message = "";
            string localhosts = File.ReadAllText("localhosts.txt");
            if (localhosts.Length > 0)
            {
                if (localhosts.Contains(localhost))
                {
                    try
                    {
                        Output.WriteLine("Measuring local host CPU usage for: " + localhost, Color.LightBlue);

                        // Initialise cpu counter
                        cpucounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);

                        cpucounter.MachineName = localhost;

                        cpucounter.NextValue();
                        Thread.Sleep(1000); // One second of CPU time

                        cpuUsage = Convert.ToDouble(Math.Round(cpucounter.NextValue(), 2));
                        Output.WriteLine("CPU Usage: " + cpuUsage + "%", Color.LightBlue);

                        if (cpuUsage > values.cpuUsageThreshold)
                        {
                            Output.WriteLine("CPU usage is higher than theshold of " + values.cpuUsageThreshold + "%", Color.OrangeRed);
                        }
                    }
                    catch (Exception ex)
                    {
                        Message = "Error: " + ex.Message;
                        Output.WriteLine(Message, Color.OrangeRed);
                    }
                }
            }
            else
            {
                Output.LogAppend("localhosts.txt file is empty! Please add local hosts to check their resources. \n", Color.White);
            }

            return Message;
        }

        private enum ConnectionStatusEnum
        {
            InternetConnectionOffline = 0x20,
        }

        [DllImport("wininet", CharSet = CharSet.Auto)]
        private static extern bool InternetGetConnectedState(ref ConnectionStatusEnum flags, int dw);

        private static IPAddress GetIpFromHost(ref string host) // Attempt to get IP address from hostname
        {
            //IPAddress instance for holding the returned host
            IPAddress address = null;

            //wrap the attempt in a try..catch to capture
            //any exceptions that may occur
            try
            {
                //get the host IP from the name provided
                address = Dns.GetHostEntry(host).AddressList[0];
            }
            catch (SocketException)
            {
                //some DNS error happened
            }
            return address;
        }

        private static bool HasConnection() // Test the connection to the host before ping
        {
            //instance of our ConnectionStatusEnum
            ConnectionStatusEnum state = 0;

            //call the API
            InternetGetConnectedState(ref state, 0);

            //check the status, if not offline and the returned state
            //isnt 0 then we have a connection
            if (((int)ConnectionStatusEnum.InternetConnectionOffline & (int)state) != 0)
            {
                //return true, we have a connection
                return false;
            }
            //return false, no connection available
            return true;
        }
    }
}