using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPingNotify_GUI
{

    public static class SaveState
    {
        public static readonly string ConfigPath = "config.xml";

        //Controls AutoSave is enabled or not
        public static bool AutoSave = true;

        //AutoSave interval
        public static int AutoSaveInterval = 10000;

        private static frmMain main = (frmMain)Application.OpenForms["frmMain"];

        //Values to be used in SaveState for loading and saving to config
        public static readonly Values values = new SaveState.Values();

        public class Values
        {
            //declare values to be saved
            public string mailTo { get; set; }

            public string mailFrom { get; set; }
            public string mailSMTP { get; set; }
            public string mailPassword { get; set; }
            public int pingInterval { get; set; }
            public int replyTimeThreshold { get; set; }
            public int cpuUsageThreshold { get; set; }
            //TODO: Other variables still need to be added here
        }

        public static void SetDefaults()
        {
            values.mailFrom = "YourEmail@gmail.com";
            values.mailPassword = "YourPassword";
            values.mailSMTP = "smtp.gmail.com"; ;
            values.mailTo = "MailTo@gmail.com";
            values.pingInterval = 60_000;
            values.replyTimeThreshold = 100;
            values.cpuUsageThreshold = 80;
        }

        //Saves values ready to be stored
        public static void SaveConfig()
        {
            //update values
            Values state = new Values();

            //Values
            state.pingInterval = values.pingInterval;
            state.replyTimeThreshold = values.replyTimeThreshold;

            state.cpuUsageThreshold = values.cpuUsageThreshold;

            state.mailTo = values.mailTo;
            state.mailFrom = values.mailFrom;
            state.mailPassword = values.mailPassword;
            state.mailSMTP = values.mailSMTP;

            //writes values to config
            WriteConfig(state);
        }

        //AutoSave values
        public static async void AutoSaveValues()
        {
            while (true)
            {
                while (AutoSave)
                {
                    SaveConfig();

                    Output.LogAppend("Config has been saved. \n", Color.White);

                    await Task.Delay(AutoSaveInterval);
                }

                await Task.Delay(AutoSaveInterval);
            }
        }

        //Load values from config
        public static void LoadConfig()
        {
            if (File.Exists(ConfigPath))
            {
                //Sets players info to config values
                Values state = new Values();

                XmlSerializer serializer = new XmlSerializer(typeof(Values));
                using (FileStream fs = File.OpenRead(ConfigPath))
                {
                    state = (Values)serializer.Deserialize(fs);
                    fs.Dispose();
                }

                //Sets application info to config values
                values.pingInterval = state.pingInterval;
                values.replyTimeThreshold = state.replyTimeThreshold;
                values.cpuUsageThreshold = state.cpuUsageThreshold;

                values.mailTo = state.mailTo;
                values.mailFrom = state.mailFrom;
                values.mailPassword = state.mailPassword;
                values.mailSMTP = state.mailSMTP;

                //Set labels to config values
                main.lblPingInterval.Text = values.pingInterval / 1000 + "s";
                main.lblPingAlertThreshold.Text = values.replyTimeThreshold + "ms";
                main.lblCpuTheshold.Text = values.cpuUsageThreshold + "%";

                //Set labels to mail config values
                main.txtMailFrom.Text = values.mailFrom;
                main.txtMailPassword.Text = values.mailPassword;
                main.txtMailSmtp.Text = values.mailSMTP;
                main.txtMailTo.Text = values.mailTo;
            }
            else
            {
                //Create configs if they do not exist
                File.Create(ConfigPath);
            }
        }

        //Store values to config
        public static void WriteConfig(Values values)
        {
            if (!File.Exists(ConfigPath))
            {
                File.Create(ConfigPath).Dispose();
            }

            //write player values to file in %appdata%
            XmlSerializer serializer = new XmlSerializer(typeof(Values));
            using (TextWriter tw = new StreamWriter(ConfigPath))
            {
                serializer.Serialize(tw, values);
                tw.Dispose();
            }
        }
    }
}