namespace OutAccounting.forms
{
    partial class customers
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label innLabel;
            System.Windows.Forms.Label kppLabel;
            System.Windows.Forms.Label registration_formLabel;
            System.Windows.Forms.Label ogrnLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.app_name = new System.Windows.Forms.Label();
            this.infopanel = new System.Windows.Forms.Panel();
            this.agreecreatebutton = new System.Windows.Forms.Button();
            this.worker_surname = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.worker_surname_label = new System.Windows.Forms.Label();
            this.orgname = new System.Windows.Forms.TextBox();
            this.ogrnMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.registration_formMaskedBox = new System.Windows.Forms.ComboBox();
            this.kppMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.innMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customersTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager();
            this.search_panel = new System.Windows.Forms.Panel();
            this.search_text = new System.Windows.Forms.ComboBox();
            this.search_open = new System.Windows.Forms.PictureBox();
            this.close_app_button = new System.Windows.Forms.PictureBox();
            this.workersTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.WorkersTableAdapter();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_note = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            kppLabel = new System.Windows.Forms.Label();
            registration_formLabel = new System.Windows.Forms.Label();
            ogrnLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            this.infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_app_button)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            nameLabel.Location = new System.Drawing.Point(95, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(158, 27);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Организация:";
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            innLabel.Location = new System.Drawing.Point(95, 136);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(68, 27);
            innLabel.TabIndex = 22;
            innLabel.Text = "ИНН:";
            // 
            // kppLabel
            // 
            kppLabel.AutoSize = true;
            kppLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            kppLabel.Location = new System.Drawing.Point(97, 183);
            kppLabel.Name = "kppLabel";
            kppLabel.Size = new System.Drawing.Size(66, 27);
            kppLabel.TabIndex = 23;
            kppLabel.Text = "КПП:";
            // 
            // registration_formLabel
            // 
            registration_formLabel.AutoSize = true;
            registration_formLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            registration_formLabel.Location = new System.Drawing.Point(96, 232);
            registration_formLabel.Name = "registration_formLabel";
            registration_formLabel.Size = new System.Drawing.Size(227, 27);
            registration_formLabel.TabIndex = 24;
            registration_formLabel.Text = "Форма регистрации:";
            // 
            // ogrnLabel
            // 
            ogrnLabel.AutoSize = true;
            ogrnLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            ogrnLabel.Location = new System.Drawing.Point(98, 281);
            ogrnLabel.Name = "ogrnLabel";
            ogrnLabel.Size = new System.Drawing.Size(78, 27);
            ogrnLabel.TabIndex = 25;
            ogrnLabel.Text = "ОГРН:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            label1.Location = new System.Drawing.Point(6, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 27);
            label1.TabIndex = 23;
            label1.Text = "Организация:";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Location = new System.Drawing.Point(165, 114);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(55, 53);
            this.backbutton.TabIndex = 13;
            this.backbutton.TabStop = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.app_name.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.ForeColor = System.Drawing.Color.White;
            this.app_name.Location = new System.Drawing.Point(707, 100);
            this.app_name.Name = "app_name";
            this.app_name.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.app_name.Size = new System.Drawing.Size(284, 83);
            this.app_name.TabIndex = 12;
            this.app_name.Text = "Клиенты";
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.Color.White;
            this.infopanel.Controls.Add(this.agreecreatebutton);
            this.infopanel.Controls.Add(this.worker_surname);
            this.infopanel.Controls.Add(this.worker_surname_label);
            this.infopanel.Controls.Add(this.orgname);
            this.infopanel.Controls.Add(this.ogrnMaskedBox);
            this.infopanel.Controls.Add(this.registration_formMaskedBox);
            this.infopanel.Controls.Add(this.kppMaskedBox);
            this.infopanel.Controls.Add(this.innMaskedBox);
            this.infopanel.Controls.Add(ogrnLabel);
            this.infopanel.Controls.Add(registration_formLabel);
            this.infopanel.Controls.Add(kppLabel);
            this.infopanel.Controls.Add(innLabel);
            this.infopanel.Controls.Add(nameLabel);
            this.infopanel.Location = new System.Drawing.Point(149, 192);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(849, 392);
            this.infopanel.TabIndex = 4;
            this.infopanel.Visible = false;
            // 
            // agreecreatebutton
            // 
            this.agreecreatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.agreecreatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agreecreatebutton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreecreatebutton.ForeColor = System.Drawing.Color.White;
            this.agreecreatebutton.Location = new System.Drawing.Point(426, 321);
            this.agreecreatebutton.Name = "agreecreatebutton";
            this.agreecreatebutton.Size = new System.Drawing.Size(355, 46);
            this.agreecreatebutton.TabIndex = 6;
            this.agreecreatebutton.Text = "Добавить запись";
            this.agreecreatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agreecreatebutton.UseVisualStyleBackColor = false;
            this.agreecreatebutton.Click += new System.EventHandler(this.agreecreatebutton_Click);
            // 
            // worker_surname
            // 
            this.worker_surname.DataSource = this.workersBindingSource;
            this.worker_surname.DisplayMember = "surname";
            this.worker_surname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worker_surname.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.worker_surname.FormattingEnabled = true;
            this.worker_surname.Location = new System.Drawing.Point(237, 42);
            this.worker_surname.Name = "worker_surname";
            this.worker_surname.Size = new System.Drawing.Size(544, 35);
            this.worker_surname.TabIndex = 0;
            this.worker_surname.ValueMember = "surname";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.accountingDataSet;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "accountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worker_surname_label
            // 
            this.worker_surname_label.AutoSize = true;
            this.worker_surname_label.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.worker_surname_label.Location = new System.Drawing.Point(98, 45);
            this.worker_surname_label.Name = "worker_surname_label";
            this.worker_surname_label.Size = new System.Drawing.Size(133, 27);
            this.worker_surname_label.TabIndex = 30;
            this.worker_surname_label.Text = "Сотрудник:";
            // 
            // orgname
            // 
            this.orgname.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.orgname.Location = new System.Drawing.Point(258, 88);
            this.orgname.Name = "orgname";
            this.orgname.Size = new System.Drawing.Size(523, 35);
            this.orgname.TabIndex = 1;
            // 
            // ogrnMaskedBox
            // 
            this.ogrnMaskedBox.Enabled = false;
            this.ogrnMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.ogrnMaskedBox.Location = new System.Drawing.Point(182, 278);
            this.ogrnMaskedBox.Name = "ogrnMaskedBox";
            this.ogrnMaskedBox.Size = new System.Drawing.Size(599, 35);
            this.ogrnMaskedBox.TabIndex = 5;
            // 
            // registration_formMaskedBox
            // 
            this.registration_formMaskedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.registration_formMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.registration_formMaskedBox.FormattingEnabled = true;
            this.registration_formMaskedBox.Items.AddRange(new object[] {
            "ИП (Индивидуальный предприниматель)",
            "Общество с ограниченной ответственностью (ООО)",
            "Акционерное общество (АО)",
            "Публичное акционерное общество (ПАО)",
            "Некоммерческая организация (НКО)",
            "Обособленное подразделение (ОП)",
            "Товарищество собственников жилья (ТСЖ)"});
            this.registration_formMaskedBox.Location = new System.Drawing.Point(329, 229);
            this.registration_formMaskedBox.Name = "registration_formMaskedBox";
            this.registration_formMaskedBox.Size = new System.Drawing.Size(452, 35);
            this.registration_formMaskedBox.TabIndex = 4;
            this.registration_formMaskedBox.SelectedIndexChanged += new System.EventHandler(this.registration_formTextBox_SelectedIndexChanged);
            // 
            // kppMaskedBox
            // 
            this.kppMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.kppMaskedBox.Location = new System.Drawing.Point(169, 180);
            this.kppMaskedBox.Mask = "000000000";
            this.kppMaskedBox.Name = "kppMaskedBox";
            this.kppMaskedBox.Size = new System.Drawing.Size(611, 35);
            this.kppMaskedBox.TabIndex = 3;
            // 
            // innMaskedBox
            // 
            this.innMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.innMaskedBox.Location = new System.Drawing.Point(169, 133);
            this.innMaskedBox.Mask = "000000000000";
            this.innMaskedBox.Name = "innMaskedBox";
            this.innMaskedBox.Size = new System.Drawing.Size(611, 35);
            this.innMaskedBox.TabIndex = 2;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.accountingDataSet;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AllowUserToResizeColumns = false;
            this.customersDataGridView.AllowUserToResizeRows = false;
            this.customersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.customersDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.customersDataGridView.Location = new System.Drawing.Point(165, 203);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customersDataGridView.ShowCellToolTips = false;
            this.customersDataGridView.ShowEditingIcon = false;
            this.customersDataGridView.Size = new System.Drawing.Size(817, 311);
            this.customersDataGridView.TabIndex = 0;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountingTableAdapter = null;
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.Service_informationTableAdapter = null;
            this.tableAdapterManager.TarifsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.Color.White;
            this.search_panel.Controls.Add(this.search_text);
            this.search_panel.Controls.Add(label1);
            this.search_panel.Location = new System.Drawing.Point(155, 515);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(839, 62);
            this.search_panel.TabIndex = 3;
            this.search_panel.Visible = false;
            // 
            // search_text
            // 
            this.search_text.DataSource = this.customersBindingSource;
            this.search_text.DisplayMember = "name";
            this.search_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_text.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.search_text.FormattingEnabled = true;
            this.search_text.Location = new System.Drawing.Point(170, 13);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(658, 35);
            this.search_text.TabIndex = 0;
            this.search_text.ValueMember = "name";
            this.search_text.SelectedIndexChanged += new System.EventHandler(this.search_text_SelectedIndexChanged);
            // 
            // search_open
            // 
            this.search_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.search_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_open.BackgroundImage")));
            this.search_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_open.Location = new System.Drawing.Point(226, 114);
            this.search_open.Name = "search_open";
            this.search_open.Size = new System.Drawing.Size(50, 51);
            this.search_open.TabIndex = 25;
            this.search_open.TabStop = false;
            this.search_open.Click += new System.EventHandler(this.search_open_Click);
            // 
            // close_app_button
            // 
            this.close_app_button.BackColor = System.Drawing.Color.Transparent;
            this.close_app_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_app_button.BackgroundImage")));
            this.close_app_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_app_button.Location = new System.Drawing.Point(1137, 3);
            this.close_app_button.Name = "close_app_button";
            this.close_app_button.Size = new System.Drawing.Size(53, 50);
            this.close_app_button.TabIndex = 26;
            this.close_app_button.TabStop = false;
            this.close_app_button.Click += new System.EventHandler(this.close_app_button_Click);
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(165, 520);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(396, 46);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_note
            // 
            this.delete_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.delete_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_note.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_note.ForeColor = System.Drawing.Color.White;
            this.delete_note.Location = new System.Drawing.Point(585, 520);
            this.delete_note.Name = "delete_note";
            this.delete_note.Size = new System.Drawing.Size(397, 46);
            this.delete_note.TabIndex = 2;
            this.delete_note.Text = "Удалить";
            this.delete_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_note.UseVisualStyleBackColor = false;
            this.delete_note.Click += new System.EventHandler(this.delete_note_Click);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 664);
            this.Controls.Add(this.search_panel);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.delete_note);
            this.Controls.Add(this.close_app_button);
            this.Controls.Add(this.search_open);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.app_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutAccounting - Клиенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.customers_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.customers_FormClosed);
            this.Load += new System.EventHandler(this.customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_app_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.Panel infopanel;
        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private other.accountingDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.MaskedTextBox kppMaskedBox;
        private System.Windows.Forms.MaskedTextBox innMaskedBox;
        private System.Windows.Forms.ComboBox registration_formMaskedBox;
        private other.accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox ogrnMaskedBox;
        private System.Windows.Forms.TextBox orgname;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.ComboBox search_text;
        private System.Windows.Forms.PictureBox search_open;
        private System.Windows.Forms.PictureBox close_app_button;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private other.accountingDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Label worker_surname_label;
        private System.Windows.Forms.ComboBox worker_surname;
        private System.Windows.Forms.Button agreecreatebutton;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_note;
    }
}