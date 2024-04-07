namespace OutAccounting
{
    partial class authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorization));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.entranceButton = new System.Windows.Forms.Button();
            this.tarifGuestButton = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.pasMask = new System.Windows.Forms.Label();
            this.logMask = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.archiveButton = new System.Windows.Forms.Button();
            this.tarifsButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.accountingButton = new System.Windows.Forms.Button();
            this.backauthButton = new System.Windows.Forms.Button();
            this.hide_button = new System.Windows.Forms.PictureBox();
            this.showButton = new System.Windows.Forms.PictureBox();
            this.closeAppButton = new System.Windows.Forms.PictureBox();
            this.statisticButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 601);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.loginTextBox.Location = new System.Drawing.Point(22, 218);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(338, 46);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.passwordTextBox.Location = new System.Drawing.Point(22, 282);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(338, 46);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // entranceButton
            // 
            this.entranceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.entranceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entranceButton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entranceButton.ForeColor = System.Drawing.Color.White;
            this.entranceButton.Location = new System.Drawing.Point(-2, 376);
            this.entranceButton.Name = "entranceButton";
            this.entranceButton.Size = new System.Drawing.Size(312, 60);
            this.entranceButton.TabIndex = 2;
            this.entranceButton.Text = "Войти";
            this.entranceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.entranceButton.UseVisualStyleBackColor = false;
            this.entranceButton.Click += new System.EventHandler(this.entrance_Click);
            // 
            // tarifGuestButton
            // 
            this.tarifGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.tarifGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tarifGuestButton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifGuestButton.ForeColor = System.Drawing.Color.White;
            this.tarifGuestButton.Location = new System.Drawing.Point(-2, 442);
            this.tarifGuestButton.Name = "tarifGuestButton";
            this.tarifGuestButton.Size = new System.Drawing.Size(312, 46);
            this.tarifGuestButton.TabIndex = 3;
            this.tarifGuestButton.Text = "Тарифы";
            this.tarifGuestButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tarifGuestButton.UseVisualStyleBackColor = false;
            this.tarifGuestButton.Click += new System.EventHandler(this.tarifs_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.appName.Font = new System.Drawing.Font("Copperplate Gothic Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(-2, 86);
            this.appName.Name = "appName";
            this.appName.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.appName.Size = new System.Drawing.Size(581, 79);
            this.appName.TabIndex = 7;
            this.appName.Text = "OutAccounting";
            // 
            // pasMask
            // 
            this.pasMask.AutoSize = true;
            this.pasMask.BackColor = System.Drawing.Color.White;
            this.pasMask.Enabled = false;
            this.pasMask.Font = new System.Drawing.Font("Linux Biolinum G", 24F);
            this.pasMask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.pasMask.Location = new System.Drawing.Point(34, 285);
            this.pasMask.Name = "pasMask";
            this.pasMask.Size = new System.Drawing.Size(114, 37);
            this.pasMask.TabIndex = 6;
            this.pasMask.Text = "пароль";
            // 
            // logMask
            // 
            this.logMask.AutoSize = true;
            this.logMask.BackColor = System.Drawing.Color.White;
            this.logMask.Enabled = false;
            this.logMask.Font = new System.Drawing.Font("Linux Biolinum G", 24F);
            this.logMask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.logMask.Location = new System.Drawing.Point(34, 221);
            this.logMask.Name = "logMask";
            this.logMask.Size = new System.Drawing.Size(99, 37);
            this.logMask.TabIndex = 7;
            this.logMask.Text = "логин";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.todayLabel.Font = new System.Drawing.Font("Linux Biolinum G", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(698, 542);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(283, 31);
            this.todayLabel.TabIndex = 9;
            this.todayLabel.Text = "00.00.0000 00:00:00        ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.menuPanel.Controls.Add(this.statisticButton);
            this.menuPanel.Controls.Add(this.archiveButton);
            this.menuPanel.Controls.Add(this.tarifsButton);
            this.menuPanel.Controls.Add(this.customersButton);
            this.menuPanel.Controls.Add(this.accountingButton);
            this.menuPanel.Location = new System.Drawing.Point(-6, 168);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(391, 397);
            this.menuPanel.TabIndex = 4;
            this.menuPanel.Visible = false;
            // 
            // archiveButton
            // 
            this.archiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.archiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.archiveButton.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveButton.ForeColor = System.Drawing.Color.White;
            this.archiveButton.Location = new System.Drawing.Point(-1, 243);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(345, 46);
            this.archiveButton.TabIndex = 3;
            this.archiveButton.Text = "Архив";
            this.archiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archiveButton.UseVisualStyleBackColor = false;
            this.archiveButton.Visible = false;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // tarifsButton
            // 
            this.tarifsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.tarifsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tarifsButton.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifsButton.ForeColor = System.Drawing.Color.White;
            this.tarifsButton.Location = new System.Drawing.Point(-1, 189);
            this.tarifsButton.Name = "tarifsButton";
            this.tarifsButton.Size = new System.Drawing.Size(345, 46);
            this.tarifsButton.TabIndex = 2;
            this.tarifsButton.Text = "Тарифы";
            this.tarifsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tarifsButton.UseVisualStyleBackColor = false;
            this.tarifsButton.Click += new System.EventHandler(this.tarifs_button_Click);
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customersButton.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.ForeColor = System.Drawing.Color.White;
            this.customersButton.Location = new System.Drawing.Point(-1, 134);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(345, 46);
            this.customersButton.TabIndex = 1;
            this.customersButton.Text = "Клиенты";
            this.customersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customersButton.UseVisualStyleBackColor = false;
            this.customersButton.Click += new System.EventHandler(this.customers_button_Click);
            // 
            // accountingButton
            // 
            this.accountingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.accountingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountingButton.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountingButton.ForeColor = System.Drawing.Color.White;
            this.accountingButton.Location = new System.Drawing.Point(-1, 80);
            this.accountingButton.Name = "accountingButton";
            this.accountingButton.Size = new System.Drawing.Size(345, 46);
            this.accountingButton.TabIndex = 0;
            this.accountingButton.Text = "Учёт услуг";
            this.accountingButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountingButton.UseVisualStyleBackColor = false;
            this.accountingButton.Click += new System.EventHandler(this.accounting_button_Click);
            // 
            // backauthButton
            // 
            this.backauthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.backauthButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backauthButton.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backauthButton.ForeColor = System.Drawing.Color.White;
            this.backauthButton.Location = new System.Drawing.Point(385, 176);
            this.backauthButton.Name = "backauthButton";
            this.backauthButton.Size = new System.Drawing.Size(195, 46);
            this.backauthButton.TabIndex = 5;
            this.backauthButton.Text = "Назад";
            this.backauthButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backauthButton.UseVisualStyleBackColor = false;
            this.backauthButton.Visible = false;
            this.backauthButton.Click += new System.EventHandler(this.backauth_button_Click);
            // 
            // hide_button
            // 
            this.hide_button.BackColor = System.Drawing.Color.White;
            this.hide_button.Image = ((System.Drawing.Image)(resources.GetObject("hide_button.Image")));
            this.hide_button.Location = new System.Drawing.Point(312, 285);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(40, 40);
            this.hide_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide_button.TabIndex = 12;
            this.hide_button.TabStop = false;
            this.hide_button.Visible = false;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.White;
            this.showButton.Image = ((System.Drawing.Image)(resources.GetObject("showButton.Image")));
            this.showButton.Location = new System.Drawing.Point(312, 285);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(40, 40);
            this.showButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showButton.TabIndex = 13;
            this.showButton.TabStop = false;
            this.showButton.Click += new System.EventHandler(this.show_button_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.BackColor = System.Drawing.Color.Transparent;
            this.closeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeAppButton.BackgroundImage")));
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeAppButton.Location = new System.Drawing.Point(872, 4);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(53, 50);
            this.closeAppButton.TabIndex = 14;
            this.closeAppButton.TabStop = false;
            this.closeAppButton.Click += new System.EventHandler(this.close_app_button_Click);
            // 
            // statisticButton
            // 
            this.statisticButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.statisticButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statisticButton.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticButton.ForeColor = System.Drawing.Color.White;
            this.statisticButton.Location = new System.Drawing.Point(-1, 295);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Size = new System.Drawing.Size(345, 46);
            this.statisticButton.TabIndex = 4;
            this.statisticButton.Text = "Статистика";
            this.statisticButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statisticButton.UseVisualStyleBackColor = false;
            this.statisticButton.Click += new System.EventHandler(this.statisticButton_Click);
            // 
            // authorization
            // 
            this.AcceptButton = this.entranceButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 582);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.hide_button);
            this.Controls.Add(this.backauthButton);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.logMask);
            this.Controls.Add(this.pasMask);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.tarifGuestButton);
            this.Controls.Add(this.entranceButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutAccounting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.authorization_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.authorization_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hide_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button entranceButton;
        private System.Windows.Forms.Button tarifGuestButton;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label pasMask;
        private System.Windows.Forms.Label logMask;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button backauthButton;
        private System.Windows.Forms.Button tarifsButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button accountingButton;
        private System.Windows.Forms.PictureBox hide_button;
        private System.Windows.Forms.PictureBox showButton;
        private System.Windows.Forms.PictureBox closeAppButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button statisticButton;
    }
}

