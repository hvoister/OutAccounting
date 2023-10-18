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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.entrance = new System.Windows.Forms.Button();
            this.tarifs = new System.Windows.Forms.Button();
            this.app_name = new System.Windows.Forms.Label();
            this.pas_mask = new System.Windows.Forms.Label();
            this.log_mask = new System.Windows.Forms.Label();
            this.today_lab = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menupanel = new System.Windows.Forms.Panel();
            this.tarifs_button = new System.Windows.Forms.Button();
            this.customers_button = new System.Windows.Forms.Button();
            this.accounting_button = new System.Windows.Forms.Button();
            this.backauth_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menupanel.SuspendLayout();
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
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.login.Location = new System.Drawing.Point(22, 218);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(338, 46);
            this.login.TabIndex = 1;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.password.Location = new System.Drawing.Point(22, 282);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(338, 46);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // entrance
            // 
            this.entrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.entrance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entrance.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrance.ForeColor = System.Drawing.Color.White;
            this.entrance.Location = new System.Drawing.Point(1, 376);
            this.entrance.Name = "entrance";
            this.entrance.Size = new System.Drawing.Size(312, 60);
            this.entrance.TabIndex = 3;
            this.entrance.Text = "Войти";
            this.entrance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.entrance.UseVisualStyleBackColor = false;
            this.entrance.Click += new System.EventHandler(this.entrance_Click);
            // 
            // tarifs
            // 
            this.tarifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.tarifs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tarifs.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifs.ForeColor = System.Drawing.Color.White;
            this.tarifs.Location = new System.Drawing.Point(1, 442);
            this.tarifs.Name = "tarifs";
            this.tarifs.Size = new System.Drawing.Size(312, 46);
            this.tarifs.TabIndex = 4;
            this.tarifs.Text = "Тарифы";
            this.tarifs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tarifs.UseVisualStyleBackColor = false;
            this.tarifs.Click += new System.EventHandler(this.tarifs_Click);
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.app_name.Font = new System.Drawing.Font("Copperplate Gothic Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.ForeColor = System.Drawing.Color.White;
            this.app_name.Location = new System.Drawing.Point(-2, 86);
            this.app_name.Name = "app_name";
            this.app_name.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.app_name.Size = new System.Drawing.Size(581, 79);
            this.app_name.TabIndex = 5;
            this.app_name.Text = "OutAccounting";
            // 
            // pas_mask
            // 
            this.pas_mask.AutoSize = true;
            this.pas_mask.BackColor = System.Drawing.Color.White;
            this.pas_mask.Enabled = false;
            this.pas_mask.Font = new System.Drawing.Font("Linux Biolinum G", 24F);
            this.pas_mask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.pas_mask.Location = new System.Drawing.Point(34, 285);
            this.pas_mask.Name = "pas_mask";
            this.pas_mask.Size = new System.Drawing.Size(114, 37);
            this.pas_mask.TabIndex = 6;
            this.pas_mask.Text = "пароль";
            // 
            // log_mask
            // 
            this.log_mask.AutoSize = true;
            this.log_mask.BackColor = System.Drawing.Color.White;
            this.log_mask.Enabled = false;
            this.log_mask.Font = new System.Drawing.Font("Linux Biolinum G", 24F);
            this.log_mask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.log_mask.Location = new System.Drawing.Point(34, 221);
            this.log_mask.Name = "log_mask";
            this.log_mask.Size = new System.Drawing.Size(99, 37);
            this.log_mask.TabIndex = 7;
            this.log_mask.Text = "логин";
            // 
            // today_lab
            // 
            this.today_lab.AutoSize = true;
            this.today_lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.today_lab.Font = new System.Drawing.Font("Linux Biolinum G", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today_lab.ForeColor = System.Drawing.Color.White;
            this.today_lab.Location = new System.Drawing.Point(709, 542);
            this.today_lab.Name = "today_lab";
            this.today_lab.Size = new System.Drawing.Size(227, 31);
            this.today_lab.TabIndex = 9;
            this.today_lab.Text = "00.00.0000 00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.menupanel.Controls.Add(this.tarifs_button);
            this.menupanel.Controls.Add(this.customers_button);
            this.menupanel.Controls.Add(this.accounting_button);
            this.menupanel.Location = new System.Drawing.Point(-6, 170);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(391, 397);
            this.menupanel.TabIndex = 10;
            this.menupanel.Visible = false;
            // 
            // tarifs_button
            // 
            this.tarifs_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.tarifs_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tarifs_button.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifs_button.ForeColor = System.Drawing.Color.White;
            this.tarifs_button.Location = new System.Drawing.Point(-1, 189);
            this.tarifs_button.Name = "tarifs_button";
            this.tarifs_button.Size = new System.Drawing.Size(345, 46);
            this.tarifs_button.TabIndex = 14;
            this.tarifs_button.Text = "Тарифы";
            this.tarifs_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tarifs_button.UseVisualStyleBackColor = false;
            this.tarifs_button.Click += new System.EventHandler(this.tarifs_button_Click);
            // 
            // customers_button
            // 
            this.customers_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.customers_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customers_button.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_button.ForeColor = System.Drawing.Color.White;
            this.customers_button.Location = new System.Drawing.Point(-1, 134);
            this.customers_button.Name = "customers_button";
            this.customers_button.Size = new System.Drawing.Size(345, 46);
            this.customers_button.TabIndex = 13;
            this.customers_button.Text = "Клиенты";
            this.customers_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customers_button.UseVisualStyleBackColor = false;
            this.customers_button.Click += new System.EventHandler(this.customers_button_Click);
            // 
            // accounting_button
            // 
            this.accounting_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.accounting_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accounting_button.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accounting_button.ForeColor = System.Drawing.Color.White;
            this.accounting_button.Location = new System.Drawing.Point(-1, 80);
            this.accounting_button.Name = "accounting_button";
            this.accounting_button.Size = new System.Drawing.Size(345, 46);
            this.accounting_button.TabIndex = 12;
            this.accounting_button.Text = "Учёт услуг";
            this.accounting_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accounting_button.UseVisualStyleBackColor = false;
            // 
            // backauth_button
            // 
            this.backauth_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.backauth_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backauth_button.Font = new System.Drawing.Font("Linux Biolinum G", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backauth_button.ForeColor = System.Drawing.Color.White;
            this.backauth_button.Location = new System.Drawing.Point(385, 176);
            this.backauth_button.Name = "backauth_button";
            this.backauth_button.Size = new System.Drawing.Size(195, 46);
            this.backauth_button.TabIndex = 11;
            this.backauth_button.Text = "Назад";
            this.backauth_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backauth_button.UseVisualStyleBackColor = false;
            this.backauth_button.Visible = false;
            this.backauth_button.Click += new System.EventHandler(this.backauth_button_Click);
            // 
            // authorization
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 582);
            this.Controls.Add(this.backauth_button);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.today_lab);
            this.Controls.Add(this.log_mask);
            this.Controls.Add(this.pas_mask);
            this.Controls.Add(this.app_name);
            this.Controls.Add(this.tarifs);
            this.Controls.Add(this.entrance);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutAccounting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menupanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button entrance;
        private System.Windows.Forms.Button tarifs;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.Label pas_mask;
        private System.Windows.Forms.Label log_mask;
        private System.Windows.Forms.Label today_lab;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button backauth_button;
        private System.Windows.Forms.Button tarifs_button;
        private System.Windows.Forms.Button customers_button;
        private System.Windows.Forms.Button accounting_button;
    }
}

