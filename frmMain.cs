using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace AutoPingNotify_GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Text files containing host lists
        public const string hostsFile = "hosts.txt";

        private const string localhostsFile = "localhosts.txt";

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists(hostsFile)) // Check hosts file exists
            {
                Output.WriteLine("hosts.txt file does not exist!", Color.OrangeRed);
                File.Create(hostsFile).Dispose();
                Output.WriteLine("Created new hosts.txt file.", Color.LightBlue);
            }

            if (!File.Exists(localhostsFile)) // Check localhosts file exists
            {
                Output.WriteLine("localhosts.txt file does not exist!", Color.OrangeRed);
                File.Create(localhostsFile).Dispose();
                Output.WriteLine("Created new localhosts.txt file.", Color.LightBlue);
            }

            if (!File.Exists(SaveState.ConfigPath))
            {
                SaveState.SetDefaults(); // Set default config SaveState.values

                SaveState.SaveConfig(); // Save config SaveState.values

                SaveState.LoadConfig(); // Load config SaveState.values
            }
            else
            {
                SaveState.LoadConfig(); // Load config SaveState.values
            }

            // Start Ping / Scanning loop on new thread
            Thread thread = new Thread(() => Monitor.StartScaning(hostsFile, localhostsFile));
            thread.Start();
        } // On Load

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) // On Close
        {
            SaveState.SaveConfig(); // Save config SaveState.values

            Environment.Exit(0); // Close all running threads
        }

        private void btnHosts_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", hostsFile); // Open hosts text file
        }

        private void btnLocalHosts_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", localhostsFile); // Open localhosts text file
        }

        #region txtPingInterval

        private void PingInterval_Enter(object sender, EventArgs e) // Clear placeholder text
        {
            if (txtPingInterval.Text == "Auto Ping Interval")
            {
                txtPingInterval.ForeColor = Color.LightGray;
                txtPingInterval.Clear();
            }
        }

        private void PingInterval_Leave(object sender, EventArgs e)  // Set placeholder text
        {
            if (string.IsNullOrEmpty(txtPingInterval.Text))
            {
                txtPingInterval.ForeColor = Color.Gray;
                txtPingInterval.Text = "Auto Ping Interval";
            }
        }

        private void txtPingInterval_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressing enter will set PingInterval
            {
                SaveState.values.pingInterval = int.Parse(txtPingInterval.Text) * 1000;
                lblPingInterval.Text = txtPingInterval.Text + "s";
                txtPingInterval.Clear();
                logOutput.Focus();
            }
        }

        private void txtPingInterval_KeyPress(object sender, KeyPressEventArgs e) // Only allow numbers
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion txtPingInterval

        #region txtPingAlertThreshold

        private void txtPingAlert_Enter(object sender, EventArgs e) // Clear placeholder text
        {
            if (txtPingAlertThreshold.Text == "Ping Threshold")
            {
                txtPingAlertThreshold.ForeColor = Color.LightGray;
                txtPingAlertThreshold.Clear();
            }
        }

        private void txtPingAlert_Leave(object sender, EventArgs e)  // Set placeholder text
        {
            if (string.IsNullOrEmpty(txtPingAlertThreshold.Text))
            {
                txtPingAlertThreshold.ForeColor = Color.Gray;
                txtPingAlertThreshold.Text = "Ping Threshold";
            }
        }

        private void txtPingAlert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressing enter will set PingAlertThreshold
            {
                SaveState.values.replyTimeThreshold = int.Parse(txtPingAlertThreshold.Text);
                lblPingAlertThreshold.Text = txtPingAlertThreshold.Text + "ms";
                txtPingAlertThreshold.Clear();
                logOutput.Focus();
            }
        }

        private void txtPingAlert_KeyPress(object sender, KeyPressEventArgs e)  // Only allow numbers
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion txtPingAlertThreshold

        #region txtCpuTheshold

        private void txtCpuTheshold_Enter(object sender, EventArgs e)
        {
            if (txtCpuTheshold.Text == "CPU Threshold")
            {
                txtCpuTheshold.ForeColor = Color.LightGray;
                txtCpuTheshold.Clear();
            }
        }

        private void txtCpuTheshold_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCpuTheshold.Text))
            {
                txtCpuTheshold.ForeColor = Color.Gray;
                txtCpuTheshold.Text = "CPU Threshold";
            }
        }

        private void txtCpuTheshold_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressing enter will set PingAlertThreshold
            {
                SaveState.values.cpuUsageThreshold = int.Parse(txtCpuTheshold.Text);
                lblCpuTheshold.Text = txtCpuTheshold.Text + "%";
                txtCpuTheshold.Clear();
                logOutput.Focus();
            }
        }

        private void txtCpuTheshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion txtCpuTheshold

        #region txtMailFrom

        private void txtMailFrom_Enter(object sender, EventArgs e)
        {
            if (txtMailFrom.Text == "From Email Address")
            {
                txtMailFrom.ForeColor = Color.LightGray;
                txtMailFrom.Clear();
            }
        }

        private void txtMailFrom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailFrom.Text))
            {
                txtMailFrom.ForeColor = Color.Gray;
                txtMailFrom.Text = "From Email Address";
            }
        }

        private void txtMailFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressing enter will set PingAlertThreshold
            {
                SaveState.values.mailFrom = txtMailFrom.Text;
                logOutput.Focus();
            }
        }

        #endregion txtMailFrom

        #region txtMailPassword

        private void txtMailPassword_Enter(object sender, EventArgs e)
        {
            if (txtMailPassword.Text == "From Email Password")
            {
                txtMailPassword.ForeColor = Color.LightGray;
                txtMailPassword.Clear();
                txtMailPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtMailPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailPassword.Text))
            {
                txtMailPassword.UseSystemPasswordChar = false;
                txtMailPassword.ForeColor = Color.Gray;
                txtMailPassword.Text = "From Email Password";
            }
        }

        private void txtMailPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressing enter will set PingAlertThreshold
            {
                SaveState.values.mailPassword = txtMailPassword.Text;
                logOutput.Focus();
            }
        }

        #endregion txtMailPassword

        #region txtMailSmtp

        private void txtMailSmtp_Enter(object sender, EventArgs e)
        {
            if (txtMailSmtp.Text == "Smtp Server")
            {
                txtMailSmtp.ForeColor = Color.LightGray;
                txtMailSmtp.Clear();
            }
        }

        private void txtMailSmtp_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailSmtp.Text))
            {
                txtMailSmtp.ForeColor = Color.Gray;
                txtMailSmtp.Text = "Smtp Server";
            }
        }

        private void txtMailSmtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressing enter will set PingAlertThreshold
            {
                SaveState.values.mailSMTP = txtMailSmtp.Text;
                logOutput.Focus();
            }
        }

        #endregion txtMailSmtp

        #region txtMailTo

        private void txtMailTo_Enter(object sender, EventArgs e)
        {
            if (txtMailTo.Text == "To Email Address")
            {
                txtMailTo.ForeColor = Color.LightGray;
                txtMailTo.Clear();
            }
        }

        private void txtMailTo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailTo.Text))
            {
                txtMailTo.ForeColor = Color.Gray;
                txtMailTo.Text = "To Email Address";
            }
        }

        private void txtMailTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressing enter will set PingAlertThreshold
            {
                SaveState.values.mailTo = txtMailTo.Text;
                logOutput.Focus();
            }
        }

        #endregion txtMailTo

        private void btnConfigHelp_Click(object sender, EventArgs e)
        {
            if (pnlConfigHelp.Visible)
            {
                pnlConfigHelp.Visible = false;
            }
            else
            {
                pnlConfigHelp.Visible = true;
            }
        }

        private void btnMailHelp_Click(object sender, EventArgs e)
        {
            if (pnlMailHelp.Visible)
            {
                pnlMailHelp.Visible = false;
            }
            else
            {
                pnlMailHelp.Visible = true;
            }
        }

        private void tmrLogClear_Tick(object sender, EventArgs e)
        {
            logOutput.Clear();
        }

        private void BtnConfigHelpOk_Click(object sender, EventArgs e)
        {
            pnlConfigHelp.Hide();
        }

        private void btnMailHelpOk_Click(object sender, EventArgs e)
        {
            pnlMailHelp.Hide();
        }
    }

    // Overload Richtextbox with color parametter
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;

            //Ensure console always autoscrolls
            box.ScrollToCaret();
        }
    }
}