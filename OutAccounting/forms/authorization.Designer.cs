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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.app_name.Font = new System.Drawing.Font("Copperplate Gothic Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.ForeColor = System.Drawing.Color.White;
            this.app_name.Location = new System.Drawing.Point(1, 86);
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
            this.pas_mask.Location = new System.Drawing.Point(25, 286);
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
            this.log_mask.Location = new System.Drawing.Point(25, 221);
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
            this.today_lab.Location = new System.Drawing.Point(708, 542);
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
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 582);
            this.Controls.Add(this.today_lab);
            this.Controls.Add(this.log_mask);
            this.Controls.Add(this.pas_mask);
            this.Controls.Add(this.app_name);
            this.Controls.Add(this.tarifs);
            this.Controls.Add(this.entrance);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutAccounting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

