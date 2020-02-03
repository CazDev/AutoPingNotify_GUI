namespace AutoPingNotify_GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtPingInterval = new System.Windows.Forms.TextBox();
            this.lblPingInterval = new System.Windows.Forms.Label();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.lblPingAlertThreshold = new System.Windows.Forms.Label();
            this.txtPingAlertThreshold = new System.Windows.Forms.TextBox();
            this.btnConfigHelp = new System.Windows.Forms.Button();
            this.btnHosts = new System.Windows.Forms.Button();
            this.btnLocalHosts = new System.Windows.Forms.Button();
            this.txtMailTo = new System.Windows.Forms.TextBox();
            this.txtMailFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logOutput = new System.Windows.Forms.RichTextBox();
            this.lblMailFrom = new System.Windows.Forms.Label();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.lblMailPassword = new System.Windows.Forms.Label();
            this.txtMailPassword = new System.Windows.Forms.TextBox();
            this.lblMailSmtp = new System.Windows.Forms.Label();
            this.txtMailSmtp = new System.Windows.Forms.TextBox();
            this.lblCpuTheshold = new System.Windows.Forms.Label();
            this.txtCpuTheshold = new System.Windows.Forms.TextBox();
            this.btnMailHelp = new System.Windows.Forms.Button();
            this.tmrLogClear = new System.Windows.Forms.Timer(this.components);
            this.btnConfigHelpOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlConfigHelp = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlMailHelp = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMailHelpOk = new System.Windows.Forms.Button();
            this.pnlConfigHelp.SuspendLayout();
            this.pnlMailHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPingInterval
            // 
            this.txtPingInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtPingInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPingInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPingInterval.ForeColor = System.Drawing.Color.Gray;
            this.txtPingInterval.Location = new System.Drawing.Point(18, 53);
            this.txtPingInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPingInterval.Name = "txtPingInterval";
            this.txtPingInterval.Size = new System.Drawing.Size(197, 27);
            this.txtPingInterval.TabIndex = 1;
            this.txtPingInterval.Text = "Auto Ping Interval";
            this.txtPingInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPingInterval.Enter += new System.EventHandler(this.PingInterval_Enter);
            this.txtPingInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPingInterval_KeyDown);
            this.txtPingInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPingInterval_KeyPress);
            this.txtPingInterval.Leave += new System.EventHandler(this.PingInterval_Leave);
            // 
            // lblPingInterval
            // 
            this.lblPingInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPingInterval.ForeColor = System.Drawing.Color.LightGray;
            this.lblPingInterval.Location = new System.Drawing.Point(222, 53);
            this.lblPingInterval.Name = "lblPingInterval";
            this.lblPingInterval.Size = new System.Drawing.Size(65, 27);
            this.lblPingInterval.TabIndex = 4;
            this.lblPingInterval.Text = "60s";
            this.lblPingInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblTopTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(269, 27);
            this.lblTopTitle.TabIndex = 5;
            this.lblTopTitle.Text = "Config Settings";
            this.lblTopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPingAlertThreshold
            // 
            this.lblPingAlertThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPingAlertThreshold.ForeColor = System.Drawing.Color.LightGray;
            this.lblPingAlertThreshold.Location = new System.Drawing.Point(222, 90);
            this.lblPingAlertThreshold.Name = "lblPingAlertThreshold";
            this.lblPingAlertThreshold.Size = new System.Drawing.Size(65, 27);
            this.lblPingAlertThreshold.TabIndex = 7;
            this.lblPingAlertThreshold.Text = "100ms";
            this.lblPingAlertThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPingAlertThreshold
            // 
            this.txtPingAlertThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtPingAlertThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPingAlertThreshold.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPingAlertThreshold.ForeColor = System.Drawing.Color.Gray;
            this.txtPingAlertThreshold.Location = new System.Drawing.Point(18, 90);
            this.txtPingAlertThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPingAlertThreshold.Name = "txtPingAlertThreshold";
            this.txtPingAlertThreshold.Size = new System.Drawing.Size(197, 27);
            this.txtPingAlertThreshold.TabIndex = 2;
            this.txtPingAlertThreshold.Text = "Ping Threshold";
            this.txtPingAlertThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPingAlertThreshold.Enter += new System.EventHandler(this.txtPingAlert_Enter);
            this.txtPingAlertThreshold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPingAlert_KeyDown);
            this.txtPingAlertThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPingAlert_KeyPress);
            this.txtPingAlertThreshold.Leave += new System.EventHandler(this.txtPingAlert_Leave);
            // 
            // btnConfigHelp
            // 
            this.btnConfigHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnConfigHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigHelp.FlatAppearance.BorderSize = 0;
            this.btnConfigHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnConfigHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigHelp.ForeColor = System.Drawing.Color.LightBlue;
            this.btnConfigHelp.Location = new System.Drawing.Point(240, 10);
            this.btnConfigHelp.Name = "btnConfigHelp";
            this.btnConfigHelp.Size = new System.Drawing.Size(32, 32);
            this.btnConfigHelp.TabIndex = 8;
            this.btnConfigHelp.Text = "?";
            this.btnConfigHelp.UseVisualStyleBackColor = false;
            this.btnConfigHelp.Click += new System.EventHandler(this.btnConfigHelp_Click);
            // 
            // btnHosts
            // 
            this.btnHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnHosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHosts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHosts.ForeColor = System.Drawing.Color.LightBlue;
            this.btnHosts.Location = new System.Drawing.Point(12, 508);
            this.btnHosts.Name = "btnHosts";
            this.btnHosts.Size = new System.Drawing.Size(134, 41);
            this.btnHosts.TabIndex = 8;
            this.btnHosts.Text = "Hosts";
            this.btnHosts.UseVisualStyleBackColor = false;
            this.btnHosts.Click += new System.EventHandler(this.btnHosts_Click);
            // 
            // btnLocalHosts
            // 
            this.btnLocalHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLocalHosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnLocalHosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalHosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLocalHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalHosts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalHosts.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLocalHosts.Location = new System.Drawing.Point(167, 508);
            this.btnLocalHosts.Name = "btnLocalHosts";
            this.btnLocalHosts.Size = new System.Drawing.Size(120, 41);
            this.btnLocalHosts.TabIndex = 9;
            this.btnLocalHosts.Text = "Localhosts";
            this.btnLocalHosts.UseVisualStyleBackColor = false;
            this.btnLocalHosts.Click += new System.EventHandler(this.btnLocalHosts_Click);
            // 
            // txtMailTo
            // 
            this.txtMailTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtMailTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMailTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailTo.ForeColor = System.Drawing.Color.LightGray;
            this.txtMailTo.Location = new System.Drawing.Point(91, 326);
            this.txtMailTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMailTo.Name = "txtMailTo";
            this.txtMailTo.Size = new System.Drawing.Size(196, 27);
            this.txtMailTo.TabIndex = 7;
            this.txtMailTo.Text = "To Email Address";
            this.txtMailTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMailTo.Enter += new System.EventHandler(this.txtMailTo_Enter);
            this.txtMailTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailTo_KeyDown);
            this.txtMailTo.Leave += new System.EventHandler(this.txtMailTo_Leave);
            // 
            // txtMailFrom
            // 
            this.txtMailFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtMailFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMailFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailFrom.ForeColor = System.Drawing.Color.LightGray;
            this.txtMailFrom.Location = new System.Drawing.Point(91, 215);
            this.txtMailFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMailFrom.Name = "txtMailFrom";
            this.txtMailFrom.Size = new System.Drawing.Size(196, 27);
            this.txtMailFrom.TabIndex = 4;
            this.txtMailFrom.Text = "From Email Address";
            this.txtMailFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMailFrom.Enter += new System.EventHandler(this.txtMailFrom_Enter);
            this.txtMailFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailFrom_KeyDown);
            this.txtMailFrom.Leave += new System.EventHandler(this.txtMailFrom_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mail Settings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutput
            // 
            this.logOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.logOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logOutput.ForeColor = System.Drawing.Color.White;
            this.logOutput.Location = new System.Drawing.Point(305, 12);
            this.logOutput.MaxLength = 0;
            this.logOutput.Name = "logOutput";
            this.logOutput.ReadOnly = true;
            this.logOutput.Size = new System.Drawing.Size(721, 537);
            this.logOutput.TabIndex = 0;
            this.logOutput.Text = "";
            // 
            // lblMailFrom
            // 
            this.lblMailFrom.ForeColor = System.Drawing.Color.LightGray;
            this.lblMailFrom.Location = new System.Drawing.Point(14, 215);
            this.lblMailFrom.Name = "lblMailFrom";
            this.lblMailFrom.Size = new System.Drawing.Size(65, 27);
            this.lblMailFrom.TabIndex = 17;
            this.lblMailFrom.Text = "From";
            this.lblMailFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMailTo
            // 
            this.lblMailTo.ForeColor = System.Drawing.Color.LightGray;
            this.lblMailTo.Location = new System.Drawing.Point(14, 326);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(65, 27);
            this.lblMailTo.TabIndex = 18;
            this.lblMailTo.Text = "To";
            this.lblMailTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMailPassword
            // 
            this.lblMailPassword.ForeColor = System.Drawing.Color.LightGray;
            this.lblMailPassword.Location = new System.Drawing.Point(14, 252);
            this.lblMailPassword.Name = "lblMailPassword";
            this.lblMailPassword.Size = new System.Drawing.Size(70, 27);
            this.lblMailPassword.TabIndex = 20;
            this.lblMailPassword.Text = "Password";
            this.lblMailPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMailPassword
            // 
            this.txtMailPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtMailPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMailPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtMailPassword.Location = new System.Drawing.Point(91, 252);
            this.txtMailPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMailPassword.Name = "txtMailPassword";
            this.txtMailPassword.Size = new System.Drawing.Size(196, 27);
            this.txtMailPassword.TabIndex = 5;
            this.txtMailPassword.Text = "From Email Password";
            this.txtMailPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMailPassword.UseSystemPasswordChar = true;
            this.txtMailPassword.Enter += new System.EventHandler(this.txtMailPassword_Enter);
            this.txtMailPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailPassword_KeyDown);
            this.txtMailPassword.Leave += new System.EventHandler(this.txtMailPassword_Leave);
            // 
            // lblMailSmtp
            // 
            this.lblMailSmtp.ForeColor = System.Drawing.Color.LightGray;
            this.lblMailSmtp.Location = new System.Drawing.Point(14, 289);
            this.lblMailSmtp.Name = "lblMailSmtp";
            this.lblMailSmtp.Size = new System.Drawing.Size(65, 27);
            this.lblMailSmtp.TabIndex = 22;
            this.lblMailSmtp.Text = "Smtp";
            this.lblMailSmtp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMailSmtp
            // 
            this.txtMailSmtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtMailSmtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMailSmtp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailSmtp.ForeColor = System.Drawing.Color.LightGray;
            this.txtMailSmtp.Location = new System.Drawing.Point(91, 289);
            this.txtMailSmtp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMailSmtp.Name = "txtMailSmtp";
            this.txtMailSmtp.Size = new System.Drawing.Size(196, 27);
            this.txtMailSmtp.TabIndex = 6;
            this.txtMailSmtp.Text = "Smtp Server";
            this.txtMailSmtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMailSmtp.Enter += new System.EventHandler(this.txtMailSmtp_Enter);
            this.txtMailSmtp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailSmtp_KeyDown);
            this.txtMailSmtp.Leave += new System.EventHandler(this.txtMailSmtp_Leave);
            // 
            // lblCpuTheshold
            // 
            this.lblCpuTheshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCpuTheshold.ForeColor = System.Drawing.Color.LightGray;
            this.lblCpuTheshold.Location = new System.Drawing.Point(222, 127);
            this.lblCpuTheshold.Name = "lblCpuTheshold";
            this.lblCpuTheshold.Size = new System.Drawing.Size(65, 27);
            this.lblCpuTheshold.TabIndex = 24;
            this.lblCpuTheshold.Text = "80%";
            this.lblCpuTheshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCpuTheshold
            // 
            this.txtCpuTheshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtCpuTheshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpuTheshold.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuTheshold.ForeColor = System.Drawing.Color.Gray;
            this.txtCpuTheshold.Location = new System.Drawing.Point(18, 127);
            this.txtCpuTheshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpuTheshold.Name = "txtCpuTheshold";
            this.txtCpuTheshold.Size = new System.Drawing.Size(197, 27);
            this.txtCpuTheshold.TabIndex = 3;
            this.txtCpuTheshold.Text = "CPU Threshold";
            this.txtCpuTheshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpuTheshold.Enter += new System.EventHandler(this.txtCpuTheshold_Enter);
            this.txtCpuTheshold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpuTheshold_KeyDown);
            this.txtCpuTheshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpuTheshold_KeyPress);
            this.txtCpuTheshold.Leave += new System.EventHandler(this.txtCpuTheshold_Leave);
            // 
            // btnMailHelp
            // 
            this.btnMailHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnMailHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMailHelp.FlatAppearance.BorderSize = 0;
            this.btnMailHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMailHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailHelp.ForeColor = System.Drawing.Color.LightBlue;
            this.btnMailHelp.Location = new System.Drawing.Point(241, 169);
            this.btnMailHelp.Name = "btnMailHelp";
            this.btnMailHelp.Size = new System.Drawing.Size(32, 32);
            this.btnMailHelp.TabIndex = 27;
            this.btnMailHelp.Text = "?";
            this.btnMailHelp.UseVisualStyleBackColor = false;
            this.btnMailHelp.Click += new System.EventHandler(this.btnMailHelp_Click);
            // 
            // tmrLogClear
            // 
            this.tmrLogClear.Enabled = true;
            this.tmrLogClear.Interval = 600000;
            this.tmrLogClear.Tick += new System.EventHandler(this.tmrLogClear_Tick);
            // 
            // btnConfigHelpOk
            // 
            this.btnConfigHelpOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnConfigHelpOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigHelpOk.FlatAppearance.BorderSize = 0;
            this.btnConfigHelpOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnConfigHelpOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigHelpOk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigHelpOk.ForeColor = System.Drawing.Color.LightBlue;
            this.btnConfigHelpOk.Location = new System.Drawing.Point(194, 122);
            this.btnConfigHelpOk.Name = "btnConfigHelpOk";
            this.btnConfigHelpOk.Size = new System.Drawing.Size(94, 29);
            this.btnConfigHelpOk.TabIndex = 9;
            this.btnConfigHelpOk.Text = "Ok, thanks";
            this.btnConfigHelpOk.UseVisualStyleBackColor = false;
            this.btnConfigHelpOk.Click += new System.EventHandler(this.BtnConfigHelpOk_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(190, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Amount of time APN waits before pinging again";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlConfigHelp
            // 
            this.pnlConfigHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfigHelp.Controls.Add(this.label4);
            this.pnlConfigHelp.Controls.Add(this.label2);
            this.pnlConfigHelp.Controls.Add(this.textBox2);
            this.pnlConfigHelp.Controls.Add(this.textBox3);
            this.pnlConfigHelp.Controls.Add(this.textBox1);
            this.pnlConfigHelp.Controls.Add(this.label1);
            this.pnlConfigHelp.Controls.Add(this.btnConfigHelpOk);
            this.pnlConfigHelp.ForeColor = System.Drawing.Color.Silver;
            this.pnlConfigHelp.Location = new System.Drawing.Point(305, 53);
            this.pnlConfigHelp.Name = "pnlConfigHelp";
            this.pnlConfigHelp.Size = new System.Drawing.Size(572, 156);
            this.pnlConfigHelp.TabIndex = 28;
            this.pnlConfigHelp.Visible = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(190, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "CPU usage limit before sending a notification via email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(190, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ping limit before sending a notification via email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(11, 79);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 27);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "CPU Threshold";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(11, 42);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 27);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "Ping Threshold";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(11, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 27);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Auto Ping Interval";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlMailHelp
            // 
            this.pnlMailHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMailHelp.Controls.Add(this.label9);
            this.pnlMailHelp.Controls.Add(this.textBox4);
            this.pnlMailHelp.Controls.Add(this.textBox5);
            this.pnlMailHelp.Controls.Add(this.textBox6);
            this.pnlMailHelp.Controls.Add(this.textBox7);
            this.pnlMailHelp.Controls.Add(this.label5);
            this.pnlMailHelp.Controls.Add(this.label6);
            this.pnlMailHelp.Controls.Add(this.label7);
            this.pnlMailHelp.Controls.Add(this.btnMailHelpOk);
            this.pnlMailHelp.ForeColor = System.Drawing.Color.Silver;
            this.pnlMailHelp.Location = new System.Drawing.Point(305, 215);
            this.pnlMailHelp.Name = "pnlMailHelp";
            this.pnlMailHelp.Size = new System.Drawing.Size(529, 197);
            this.pnlMailHelp.TabIndex = 29;
            this.pnlMailHelp.Visible = false;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(190, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 26);
            this.label9.TabIndex = 29;
            this.label9.Text = "The email address recieve notifications\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox4.Location = new System.Drawing.Point(11, 80);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 27);
            this.textBox4.TabIndex = 27;
            this.textBox4.Text = "Smtp Server";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox5.Location = new System.Drawing.Point(11, 43);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 27);
            this.textBox5.TabIndex = 26;
            this.textBox5.Text = "From Email Password";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox6.Location = new System.Drawing.Point(11, 117);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 27);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "To Email Address";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox7.Location = new System.Drawing.Point(11, 6);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(161, 27);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = "From Email Address";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(190, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Your email account SMTP server";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(190, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Your email account account password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(190, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Your account to send the email notification from";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMailHelpOk
            // 
            this.btnMailHelpOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnMailHelpOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMailHelpOk.FlatAppearance.BorderSize = 0;
            this.btnMailHelpOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMailHelpOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailHelpOk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailHelpOk.ForeColor = System.Drawing.Color.LightBlue;
            this.btnMailHelpOk.Location = new System.Drawing.Point(194, 162);
            this.btnMailHelpOk.Name = "btnMailHelpOk";
            this.btnMailHelpOk.Size = new System.Drawing.Size(94, 29);
            this.btnMailHelpOk.TabIndex = 9;
            this.btnMailHelpOk.Text = "Ok, thanks";
            this.btnMailHelpOk.UseVisualStyleBackColor = false;
            this.btnMailHelpOk.Click += new System.EventHandler(this.btnMailHelpOk_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1038, 561);
            this.Controls.Add(this.pnlMailHelp);
            this.Controls.Add(this.pnlConfigHelp);
            this.Controls.Add(this.logOutput);
            this.Controls.Add(this.btnMailHelp);
            this.Controls.Add(this.lblCpuTheshold);
            this.Controls.Add(this.txtCpuTheshold);
            this.Controls.Add(this.lblMailSmtp);
            this.Controls.Add(this.txtMailSmtp);
            this.Controls.Add(this.lblMailPassword);
            this.Controls.Add(this.txtMailPassword);
            this.Controls.Add(this.lblMailTo);
            this.Controls.Add(this.lblMailFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMailTo);
            this.Controls.Add(this.txtMailFrom);
            this.Controls.Add(this.btnLocalHosts);
            this.Controls.Add(this.btnHosts);
            this.Controls.Add(this.btnConfigHelp);
            this.Controls.Add(this.lblPingAlertThreshold);
            this.Controls.Add(this.txtPingAlertThreshold);
            this.Controls.Add(this.lblTopTitle);
            this.Controls.Add(this.lblPingInterval);
            this.Controls.Add(this.txtPingInterval);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "frmMain";
            this.Text = "Auto Ping Notify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlConfigHelp.ResumeLayout(false);
            this.pnlConfigHelp.PerformLayout();
            this.pnlMailHelp.ResumeLayout(false);
            this.pnlMailHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPingInterval;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.TextBox txtPingAlertThreshold;
        private System.Windows.Forms.Button btnConfigHelp;
        private System.Windows.Forms.Button btnHosts;
        private System.Windows.Forms.Button btnLocalHosts;
        public System.Windows.Forms.Label lblPingInterval;
        public System.Windows.Forms.Label lblPingAlertThreshold;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox logOutput;
        public System.Windows.Forms.Label lblCpuTheshold;
        private System.Windows.Forms.TextBox txtCpuTheshold;
        private System.Windows.Forms.Button btnMailHelp;
        public System.Windows.Forms.TextBox txtMailTo;
        public System.Windows.Forms.TextBox txtMailFrom;
        private System.Windows.Forms.Label lblMailFrom;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.Label lblMailPassword;
        public System.Windows.Forms.TextBox txtMailPassword;
        private System.Windows.Forms.Label lblMailSmtp;
        public System.Windows.Forms.TextBox txtMailSmtp;
        private System.Windows.Forms.Timer tmrLogClear;
        private System.Windows.Forms.Button btnConfigHelpOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlConfigHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlMailHelp;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMailHelpOk;
    }
}

