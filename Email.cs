using System.Net;
using System.Net.Mail;
using System.Drawing;
using System;

namespace AutoPingNotify_GUI
{
    internal class Email
    {
        private static MailMessage message = new MailMessage();
        private static SmtpClient smtp = new SmtpClient();

        public static void Send(string subject, string htmlString, SaveState.Values values) // Email sender incase of unusual behaviour
        {
            Output.WriteLine("Sending email notification...", Color.LightBlue);

            // Unsecure apps access must be enabled for the sender account: https://myaccount.google.com/u/1/lesssecureapps
            message.From = new MailAddress(values.mailFrom, "Auto Ping Notify");
            message.To.Add(new MailAddress(values.mailTo));
            message.Subject = subject;
            message.IsBodyHtml = true; //to make message body as html
            message.Body = htmlString;
            smtp.Port = 587;
            smtp.Host = values.mailSMTP; //for gmail host
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(values.mailFrom, values.mailPassword);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message); // Try send email

                Output.WriteLine("Email notification sent!", Color.LightBlue);
            }
            catch (Exception ex)
            {
                Output.WriteLine("Email notification failed. Please ensure your mail settings are correct", Color.OrangeRed);

                Output.WriteLine(ex.Message, Color.OrangeRed);
            }
        }
    }
}