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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.app_name = new System.Windows.Forms.Label();
            this.agreecreatebutton = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.PictureBox();
            this.createbitton = new System.Windows.Forms.PictureBox();
            this.moveright = new System.Windows.Forms.PictureBox();
            this.moveleft = new System.Windows.Forms.PictureBox();
            this.workerpic = new System.Windows.Forms.PictureBox();
            this.infopanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.orgname = new System.Windows.Forms.TextBox();
            this.ogrnTextBox = new System.Windows.Forms.TextBox();
            this.ogrnMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.registration_formTextBox = new System.Windows.Forms.TextBox();
            this.kppTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.registration_formMaskedBox = new System.Windows.Forms.ComboBox();
            this.kppMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.innMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.fullcustomers = new System.Windows.Forms.PictureBox();
            this.bosspic = new System.Windows.Forms.PictureBox();
            this.gueststarif = new System.Windows.Forms.PictureBox();
            this.delete_note = new System.Windows.Forms.Button();
            this.delete_panel = new System.Windows.Forms.PictureBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager();
            this.search_panel = new System.Windows.Forms.Panel();
            this.search_text = new System.Windows.Forms.ComboBox();
            this.search_open = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            kppLabel = new System.Windows.Forms.Label();
            registration_formLabel = new System.Windows.Forms.Label();
            ogrnLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreecreatebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createbitton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerpic)).BeginInit();
            this.infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullcustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosspic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gueststarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_open)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            nameLabel.Location = new System.Drawing.Point(42, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(158, 27);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Организация:";
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            innLabel.Location = new System.Drawing.Point(42, 107);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(68, 27);
            innLabel.TabIndex = 22;
            innLabel.Text = "ИНН:";
            // 
            // kppLabel
            // 
            kppLabel.AutoSize = true;
            kppLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            kppLabel.Location = new System.Drawing.Point(44, 154);
            kppLabel.Name = "kppLabel";
            kppLabel.Size = new System.Drawing.Size(66, 27);
            kppLabel.TabIndex = 23;
            kppLabel.Text = "КПП:";
            // 
            // registration_formLabel
            // 
            registration_formLabel.AutoSize = true;
            registration_formLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            registration_formLabel.Location = new System.Drawing.Point(43, 203);
            registration_formLabel.Name = "registration_formLabel";
            registration_formLabel.Size = new System.Drawing.Size(227, 27);
            registration_formLabel.TabIndex = 24;
            registration_formLabel.Text = "Форма регистрации:";
            // 
            // ogrnLabel
            // 
            ogrnLabel.AutoSize = true;
            ogrnLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            ogrnLabel.Location = new System.Drawing.Point(45, 252);
            ogrnLabel.Name = "ogrnLabel";
            ogrnLabel.Size = new System.Drawing.Size(78, 27);
            ogrnLabel.TabIndex = 25;
            ogrnLabel.Text = "ОГРН:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            label1.Location = new System.Drawing.Point(18, 16);
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
            this.backbutton.Location = new System.Drawing.Point(150, 116);
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
            this.app_name.Location = new System.Drawing.Point(598, 100);
            this.app_name.Name = "app_name";
            this.app_name.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.app_name.Size = new System.Drawing.Size(284, 83);
            this.app_name.TabIndex = 12;
            this.app_name.Text = "Клиенты";
            // 
            // agreecreatebutton
            // 
            this.agreecreatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.agreecreatebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agreecreatebutton.BackgroundImage")));
            this.agreecreatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agreecreatebutton.Location = new System.Drawing.Point(505, 312);
            this.agreecreatebutton.Name = "agreecreatebutton";
            this.agreecreatebutton.Size = new System.Drawing.Size(52, 55);
            this.agreecreatebutton.TabIndex = 21;
            this.agreecreatebutton.TabStop = false;
            this.agreecreatebutton.Visible = false;
            this.agreecreatebutton.Click += new System.EventHandler(this.agreecreatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebutton.BackgroundImage")));
            this.deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebutton.Location = new System.Drawing.Point(559, 312);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(46, 53);
            this.deletebutton.TabIndex = 15;
            this.deletebutton.TabStop = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // createbitton
            // 
            this.createbitton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.createbitton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createbitton.BackgroundImage")));
            this.createbitton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createbitton.Location = new System.Drawing.Point(505, 312);
            this.createbitton.Name = "createbitton";
            this.createbitton.Size = new System.Drawing.Size(52, 55);
            this.createbitton.TabIndex = 16;
            this.createbitton.TabStop = false;
            this.createbitton.Click += new System.EventHandler(this.createbitton_Click);
            // 
            // moveright
            // 
            this.moveright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.moveright.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moveright.BackgroundImage")));
            this.moveright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveright.Location = new System.Drawing.Point(659, 310);
            this.moveright.Name = "moveright";
            this.moveright.Size = new System.Drawing.Size(65, 62);
            this.moveright.TabIndex = 13;
            this.moveright.TabStop = false;
            this.moveright.Click += new System.EventHandler(this.moveright_Click);
            // 
            // moveleft
            // 
            this.moveleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.moveleft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moveleft.BackgroundImage")));
            this.moveleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveleft.Location = new System.Drawing.Point(600, 310);
            this.moveleft.Name = "moveleft";
            this.moveleft.Size = new System.Drawing.Size(65, 62);
            this.moveleft.TabIndex = 12;
            this.moveleft.TabStop = false;
            this.moveleft.Click += new System.EventHandler(this.moveleft_Click);
            // 
            // workerpic
            // 
            this.workerpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.workerpic.Location = new System.Drawing.Point(502, 310);
            this.workerpic.Name = "workerpic";
            this.workerpic.Size = new System.Drawing.Size(224, 62);
            this.workerpic.TabIndex = 17;
            this.workerpic.TabStop = false;
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.Color.White;
            this.infopanel.Controls.Add(this.nameTextBox);
            this.infopanel.Controls.Add(this.orgname);
            this.infopanel.Controls.Add(this.ogrnTextBox);
            this.infopanel.Controls.Add(this.ogrnMaskedBox);
            this.infopanel.Controls.Add(this.registration_formTextBox);
            this.infopanel.Controls.Add(this.kppTextBox);
            this.infopanel.Controls.Add(this.innTextBox);
            this.infopanel.Controls.Add(this.registration_formMaskedBox);
            this.infopanel.Controls.Add(this.kppMaskedBox);
            this.infopanel.Controls.Add(this.innMaskedBox);
            this.infopanel.Controls.Add(this.fullcustomers);
            this.infopanel.Controls.Add(ogrnLabel);
            this.infopanel.Controls.Add(registration_formLabel);
            this.infopanel.Controls.Add(kppLabel);
            this.infopanel.Controls.Add(innLabel);
            this.infopanel.Controls.Add(nameLabel);
            this.infopanel.Controls.Add(this.agreecreatebutton);
            this.infopanel.Controls.Add(this.deletebutton);
            this.infopanel.Controls.Add(this.createbitton);
            this.infopanel.Controls.Add(this.moveright);
            this.infopanel.Controls.Add(this.moveleft);
            this.infopanel.Controls.Add(this.workerpic);
            this.infopanel.Controls.Add(this.bosspic);
            this.infopanel.Controls.Add(this.gueststarif);
            this.infopanel.Location = new System.Drawing.Point(134, 191);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(751, 392);
            this.infopanel.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.nameTextBox.Location = new System.Drawing.Point(205, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(523, 35);
            this.nameTextBox.TabIndex = 22;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.accountingDataSet;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "accountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orgname
            // 
            this.orgname.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.orgname.Location = new System.Drawing.Point(205, 59);
            this.orgname.Name = "orgname";
            this.orgname.Size = new System.Drawing.Size(523, 35);
            this.orgname.TabIndex = 29;
            // 
            // ogrnTextBox
            // 
            this.ogrnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ogrn", true));
            this.ogrnTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.ogrnTextBox.Location = new System.Drawing.Point(129, 249);
            this.ogrnTextBox.Name = "ogrnTextBox";
            this.ogrnTextBox.ReadOnly = true;
            this.ogrnTextBox.Size = new System.Drawing.Size(599, 35);
            this.ogrnTextBox.TabIndex = 26;
            // 
            // ogrnMaskedBox
            // 
            this.ogrnMaskedBox.Enabled = false;
            this.ogrnMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.ogrnMaskedBox.Location = new System.Drawing.Point(129, 249);
            this.ogrnMaskedBox.Name = "ogrnMaskedBox";
            this.ogrnMaskedBox.Size = new System.Drawing.Size(599, 35);
            this.ogrnMaskedBox.TabIndex = 18;
            // 
            // registration_formTextBox
            // 
            this.registration_formTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "registration_form", true));
            this.registration_formTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.registration_formTextBox.Location = new System.Drawing.Point(276, 200);
            this.registration_formTextBox.Name = "registration_formTextBox";
            this.registration_formTextBox.ReadOnly = true;
            this.registration_formTextBox.Size = new System.Drawing.Size(452, 35);
            this.registration_formTextBox.TabIndex = 28;
            // 
            // kppTextBox
            // 
            this.kppTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "kpp", true));
            this.kppTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.kppTextBox.Location = new System.Drawing.Point(116, 151);
            this.kppTextBox.Name = "kppTextBox";
            this.kppTextBox.ReadOnly = true;
            this.kppTextBox.Size = new System.Drawing.Size(612, 35);
            this.kppTextBox.TabIndex = 28;
            // 
            // innTextBox
            // 
            this.innTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "inn", true));
            this.innTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.innTextBox.Location = new System.Drawing.Point(116, 104);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.ReadOnly = true;
            this.innTextBox.Size = new System.Drawing.Size(612, 35);
            this.innTextBox.TabIndex = 28;
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
            this.registration_formMaskedBox.Location = new System.Drawing.Point(276, 200);
            this.registration_formMaskedBox.Name = "registration_formMaskedBox";
            this.registration_formMaskedBox.Size = new System.Drawing.Size(452, 35);
            this.registration_formMaskedBox.TabIndex = 28;
            this.registration_formMaskedBox.SelectedIndexChanged += new System.EventHandler(this.registration_formTextBox_SelectedIndexChanged);
            // 
            // kppMaskedBox
            // 
            this.kppMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.kppMaskedBox.Location = new System.Drawing.Point(116, 151);
            this.kppMaskedBox.Mask = "000000000";
            this.kppMaskedBox.Name = "kppMaskedBox";
            this.kppMaskedBox.Size = new System.Drawing.Size(611, 35);
            this.kppMaskedBox.TabIndex = 28;
            // 
            // innMaskedBox
            // 
            this.innMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.innMaskedBox.Location = new System.Drawing.Point(116, 104);
            this.innMaskedBox.Mask = "000000000000";
            this.innMaskedBox.Name = "innMaskedBox";
            this.innMaskedBox.Size = new System.Drawing.Size(611, 35);
            this.innMaskedBox.TabIndex = 27;
            // 
            // fullcustomers
            // 
            this.fullcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.fullcustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullcustomers.BackgroundImage")));
            this.fullcustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullcustomers.Location = new System.Drawing.Point(555, 315);
            this.fullcustomers.Name = "fullcustomers";
            this.fullcustomers.Size = new System.Drawing.Size(48, 52);
            this.fullcustomers.TabIndex = 20;
            this.fullcustomers.TabStop = false;
            this.fullcustomers.Visible = false;
            this.fullcustomers.Click += new System.EventHandler(this.fullcustomers_Click);
            // 
            // bosspic
            // 
            this.bosspic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.bosspic.Location = new System.Drawing.Point(559, 310);
            this.bosspic.Name = "bosspic";
            this.bosspic.Size = new System.Drawing.Size(167, 62);
            this.bosspic.TabIndex = 18;
            this.bosspic.TabStop = false;
            this.bosspic.Visible = false;
            // 
            // gueststarif
            // 
            this.gueststarif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.gueststarif.Location = new System.Drawing.Point(549, 310);
            this.gueststarif.Name = "gueststarif";
            this.gueststarif.Size = new System.Drawing.Size(177, 62);
            this.gueststarif.TabIndex = 20;
            this.gueststarif.TabStop = false;
            this.gueststarif.Visible = false;
            // 
            // delete_note
            // 
            this.delete_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.delete_note.Enabled = false;
            this.delete_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_note.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_note.ForeColor = System.Drawing.Color.White;
            this.delete_note.Location = new System.Drawing.Point(96, 512);
            this.delete_note.Name = "delete_note";
            this.delete_note.Size = new System.Drawing.Size(316, 46);
            this.delete_note.TabIndex = 15;
            this.delete_note.Text = "Удалить";
            this.delete_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_note.UseVisualStyleBackColor = false;
            this.delete_note.Click += new System.EventHandler(this.delete_note_Click);
            // 
            // delete_panel
            // 
            this.delete_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.delete_panel.Enabled = false;
            this.delete_panel.Location = new System.Drawing.Point(96, 512);
            this.delete_panel.Name = "delete_panel";
            this.delete_panel.Size = new System.Drawing.Size(316, 46);
            this.delete_panel.TabIndex = 16;
            this.delete_panel.TabStop = false;
            this.delete_panel.Visible = false;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AllowUserToResizeColumns = false;
            this.customersDataGridView.AllowUserToResizeRows = false;
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ogrn});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.customersDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.customersDataGridView.Location = new System.Drawing.Point(155, 212);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.customersDataGridView.ShowCellToolTips = false;
            this.customersDataGridView.ShowEditingIcon = false;
            this.customersDataGridView.Size = new System.Drawing.Size(705, 296);
            this.customersDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Организация";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "inn";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kpp";
            this.dataGridViewTextBoxColumn4.HeaderText = "КПП";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "registration_form";
            this.dataGridViewTextBoxColumn5.HeaderText = "Форма регистрации";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 215;
            // 
            // ogrn
            // 
            this.ogrn.DataPropertyName = "ogrn";
            this.ogrn.HeaderText = "ОГРН";
            this.ogrn.Name = "ogrn";
            this.ogrn.ReadOnly = true;
            this.ogrn.Width = 116;
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
            this.tableAdapterManager.TarifsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.Color.White;
            this.search_panel.Controls.Add(this.search_text);
            this.search_panel.Controls.Add(label1);
            this.search_panel.Location = new System.Drawing.Point(134, 512);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(747, 62);
            this.search_panel.TabIndex = 25;
            this.search_panel.Visible = false;
            // 
            // search_text
            // 
            this.search_text.DataSource = this.customersBindingSource;
            this.search_text.DisplayMember = "name";
            this.search_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_text.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.search_text.FormattingEnabled = true;
            this.search_text.Location = new System.Drawing.Point(182, 13);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(544, 35);
            this.search_text.TabIndex = 24;
            this.search_text.ValueMember = "name";
            this.search_text.SelectedIndexChanged += new System.EventHandler(this.search_text_SelectedIndexChanged);
            // 
            // search_open
            // 
            this.search_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.search_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_open.BackgroundImage")));
            this.search_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_open.Location = new System.Drawing.Point(211, 116);
            this.search_open.Name = "search_open";
            this.search_open.Size = new System.Drawing.Size(50, 51);
            this.search_open.TabIndex = 25;
            this.search_open.TabStop = false;
            this.search_open.Click += new System.EventHandler(this.search_open_Click);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 664);
            this.Controls.Add(this.search_open);
            this.Controls.Add(this.search_panel);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.delete_panel);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.app_name);
            this.Controls.Add(this.delete_note);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)(this.agreecreatebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createbitton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerpic)).EndInit();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullcustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosspic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gueststarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.PictureBox agreecreatebutton;
        private System.Windows.Forms.PictureBox deletebutton;
        private System.Windows.Forms.PictureBox createbitton;
        private System.Windows.Forms.PictureBox moveright;
        private System.Windows.Forms.PictureBox moveleft;
        private System.Windows.Forms.PictureBox workerpic;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.PictureBox gueststarif;
        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.Button delete_note;
        private System.Windows.Forms.PictureBox delete_panel;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private other.accountingDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ogrnTextBox;
        private System.Windows.Forms.PictureBox fullcustomers;
        private System.Windows.Forms.PictureBox bosspic;
        private System.Windows.Forms.MaskedTextBox kppMaskedBox;
        private System.Windows.Forms.MaskedTextBox innMaskedBox;
        private System.Windows.Forms.ComboBox registration_formMaskedBox;
        private other.accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox kppTextBox;
        private System.Windows.Forms.TextBox registration_formTextBox;
        private System.Windows.Forms.MaskedTextBox ogrnMaskedBox;
        private System.Windows.Forms.TextBox orgname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrn;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.ComboBox search_text;
        private System.Windows.Forms.PictureBox search_open;
    }
}