using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPingNotify_GUI
{
    public class Output
    {
        private readonly string LogDirPath = "logs";

        private static Output _outputSingleton;

        //Main form reference
        private static frmMain main = (frmMain)Application.OpenForms["frmMain"];

        private static Output OutputSingleton
        {
            get
            {
                if (_outputSingleton == null)
                {
                    _outputSingleton = new Output();
                }
                return _outputSingleton;
            }
        }

        public StreamWriter SW { get; set; }

        public Output()
        {
            EnsureLogDirectoryExists();
            InstantiateStreamWriter();
        }

        private delegate void SetTextCallback(string text, Color col);

        public static void LogAppend(string text, Color col)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (main.logOutput.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(LogAppend);
                main.Invoke(d, new object[] { text, col });
            }
            else
            {
                main.logOutput.AppendText(text, col);
            }
        }

        ~Output()
        {
            if (SW != null)
            {
                try
                {
                    SW.Dispose();
                }
                catch (ObjectDisposedException) { } // object already disposed - ignore exception
            }
        }

        //Console.WriteLine replacement which also writes to text file
        public static void WriteLine(string str, Color col)
        {
            LogAppend(str + "\n", col);
            OutputSingleton.SW.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss: ") + str);
        }

        //Console.Write replacement which also writes to text file
        public static void Write(string str, Color col)
        {
            LogAppend(str + "\n", col);
            OutputSingleton.SW.Write(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss: ") + str);
        }

        private void InstantiateStreamWriter()
        {
            string filePath = Path.Combine(LogDirPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")) + ".txt";
            try
            {
                SW = new StreamWriter(filePath);
                SW.AutoFlush = true;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new ApplicationException(string.Format("Access denied. Could not instantiate StreamWriter using path: {0}.", filePath), ex);
            }
        }

        private void EnsureLogDirectoryExists()
        {
            if (!Directory.Exists(LogDirPath))
            {
                try
                {
                    Directory.CreateDirectory(LogDirPath);
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw new ApplicationException(string.Format("Access denied. Could not create log directory using path: {0}.", LogDirPath), ex);
                }
            }
        }
    }
}