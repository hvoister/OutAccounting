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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.app_name = new System.Windows.Forms.Label();
            this.createNewPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.worker_surname_label = new System.Windows.Forms.Label();
            this.worker_surname = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.ogrnMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.orgName = new System.Windows.Forms.TextBox();
            this.registration_formMaskedBox = new System.Windows.Forms.ComboBox();
            this.kppMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.innMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.agreecreatebutton = new System.Windows.Forms.Button();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customersTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.search_text = new System.Windows.Forms.ComboBox();
            this.searchOpenButton = new System.Windows.Forms.PictureBox();
            this.closeAppButton = new System.Windows.Forms.PictureBox();
            this.workersTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.WorkersTableAdapter();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_note = new System.Windows.Forms.Button();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.bigWindowModeButton = new System.Windows.Forms.PictureBox();
            this.buttonsNamePanel = new System.Windows.Forms.Panel();
            nameLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            kppLabel = new System.Windows.Forms.Label();
            registration_formLabel = new System.Windows.Forms.Label();
            ogrnLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.createNewPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).BeginInit();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).BeginInit();
            this.buttonsNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            nameLabel.Location = new System.Drawing.Point(3, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(158, 27);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Организация:";
            // 
            // innLabel
            // 
            innLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            innLabel.AutoSize = true;
            innLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            innLabel.Location = new System.Drawing.Point(3, 119);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(68, 27);
            innLabel.TabIndex = 22;
            innLabel.Text = "ИНН:";
            // 
            // kppLabel
            // 
            kppLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            kppLabel.AutoSize = true;
            kppLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            kppLabel.Location = new System.Drawing.Point(3, 172);
            kppLabel.Name = "kppLabel";
            kppLabel.Size = new System.Drawing.Size(66, 27);
            kppLabel.TabIndex = 23;
            kppLabel.Text = "КПП:";
            // 
            // registration_formLabel
            // 
            registration_formLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            registration_formLabel.AutoSize = true;
            registration_formLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            registration_formLabel.Location = new System.Drawing.Point(3, 225);
            registration_formLabel.Name = "registration_formLabel";
            registration_formLabel.Size = new System.Drawing.Size(227, 27);
            registration_formLabel.TabIndex = 24;
            registration_formLabel.Text = "Форма регистрации:";
            // 
            // ogrnLabel
            // 
            ogrnLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ogrnLabel.AutoSize = true;
            ogrnLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            ogrnLabel.Location = new System.Drawing.Point(3, 278);
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
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(14, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 53);
            this.backButton.TabIndex = 13;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // app_name
            // 
            this.app_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.app_name.AutoSize = true;
            this.app_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.app_name.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.ForeColor = System.Drawing.Color.White;
            this.app_name.Location = new System.Drawing.Point(558, 6);
            this.app_name.Name = "app_name";
            this.app_name.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.app_name.Size = new System.Drawing.Size(284, 83);
            this.app_name.TabIndex = 12;
            this.app_name.Text = "Клиенты";
            // 
            // createNewPanel
            // 
            this.createNewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewPanel.BackColor = System.Drawing.Color.White;
            this.createNewPanel.Controls.Add(this.tableLayoutPanel1);
            this.createNewPanel.Location = new System.Drawing.Point(151, 193);
            this.createNewPanel.Name = "createNewPanel";
            this.createNewPanel.Size = new System.Drawing.Size(849, 392);
            this.createNewPanel.TabIndex = 4;
            this.createNewPanel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.worker_surname_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.worker_surname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ogrnMaskedBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.orgName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(ogrnLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.registration_formMaskedBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kppMaskedBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(registration_formLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(innLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.innMaskedBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(kppLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.agreecreatebutton, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28509F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 373);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // worker_surname_label
            // 
            this.worker_surname_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worker_surname_label.AutoSize = true;
            this.worker_surname_label.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.worker_surname_label.Location = new System.Drawing.Point(3, 13);
            this.worker_surname_label.Name = "worker_surname_label";
            this.worker_surname_label.Size = new System.Drawing.Size(133, 27);
            this.worker_surname_label.TabIndex = 30;
            this.worker_surname_label.Text = "Сотрудник:";
            // 
            // worker_surname
            // 
            this.worker_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.worker_surname.DataSource = this.workersBindingSource;
            this.worker_surname.DisplayMember = "surname";
            this.worker_surname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worker_surname.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.worker_surname.FormattingEnabled = true;
            this.worker_surname.Location = new System.Drawing.Point(236, 9);
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
            // ogrnMaskedBox
            // 
            this.ogrnMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ogrnMaskedBox.Enabled = false;
            this.ogrnMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.ogrnMaskedBox.Location = new System.Drawing.Point(236, 274);
            this.ogrnMaskedBox.Name = "ogrnMaskedBox";
            this.ogrnMaskedBox.Size = new System.Drawing.Size(544, 35);
            this.ogrnMaskedBox.TabIndex = 5;
            // 
            // orgName
            // 
            this.orgName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orgName.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.orgName.Location = new System.Drawing.Point(236, 62);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(544, 35);
            this.orgName.TabIndex = 1;
            // 
            // registration_formMaskedBox
            // 
            this.registration_formMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.registration_formMaskedBox.Location = new System.Drawing.Point(236, 221);
            this.registration_formMaskedBox.Name = "registration_formMaskedBox";
            this.registration_formMaskedBox.Size = new System.Drawing.Size(544, 35);
            this.registration_formMaskedBox.TabIndex = 4;
            this.registration_formMaskedBox.SelectedIndexChanged += new System.EventHandler(this.registration_formTextBox_SelectedIndexChanged);
            // 
            // kppMaskedBox
            // 
            this.kppMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kppMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.kppMaskedBox.Location = new System.Drawing.Point(236, 168);
            this.kppMaskedBox.Mask = "000000000";
            this.kppMaskedBox.Name = "kppMaskedBox";
            this.kppMaskedBox.Size = new System.Drawing.Size(544, 35);
            this.kppMaskedBox.TabIndex = 3;
            // 
            // innMaskedBox
            // 
            this.innMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.innMaskedBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.innMaskedBox.Location = new System.Drawing.Point(236, 115);
            this.innMaskedBox.Mask = "000000000000";
            this.innMaskedBox.Name = "innMaskedBox";
            this.innMaskedBox.Size = new System.Drawing.Size(544, 35);
            this.innMaskedBox.TabIndex = 2;
            // 
            // agreecreatebutton
            // 
            this.agreecreatebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.agreecreatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.agreecreatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agreecreatebutton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreecreatebutton.ForeColor = System.Drawing.Color.White;
            this.agreecreatebutton.Location = new System.Drawing.Point(236, 322);
            this.agreecreatebutton.Name = "agreecreatebutton";
            this.agreecreatebutton.Size = new System.Drawing.Size(544, 46);
            this.agreecreatebutton.TabIndex = 6;
            this.agreecreatebutton.Text = "Добавить клиента";
            this.agreecreatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agreecreatebutton.UseVisualStyleBackColor = false;
            this.agreecreatebutton.Click += new System.EventHandler(this.agreecreatebutton_Click);
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
            this.customersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.customersDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.customersDataGridView.Location = new System.Drawing.Point(14, 8);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.search_text);
            this.searchPanel.Controls.Add(label1);
            this.searchPanel.Location = new System.Drawing.Point(3, 325);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(839, 62);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.Visible = false;
            // 
            // search_text
            // 
            this.search_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // searchOpenButton
            // 
            this.searchOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.searchOpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchOpenButton.BackgroundImage")));
            this.searchOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchOpenButton.Location = new System.Drawing.Point(75, 23);
            this.searchOpenButton.Name = "searchOpenButton";
            this.searchOpenButton.Size = new System.Drawing.Size(50, 51);
            this.searchOpenButton.TabIndex = 25;
            this.searchOpenButton.TabStop = false;
            this.searchOpenButton.Click += new System.EventHandler(this.search_open_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Transparent;
            this.closeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeAppButton.BackgroundImage")));
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeAppButton.Location = new System.Drawing.Point(1137, 3);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(53, 50);
            this.closeAppButton.TabIndex = 26;
            this.closeAppButton.TabStop = false;
            this.closeAppButton.Click += new System.EventHandler(this.close_app_button_Click);
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(14, 325);
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
            this.delete_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.delete_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_note.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_note.ForeColor = System.Drawing.Color.White;
            this.delete_note.Location = new System.Drawing.Point(434, 325);
            this.delete_note.Name = "delete_note";
            this.delete_note.Size = new System.Drawing.Size(397, 46);
            this.delete_note.TabIndex = 2;
            this.delete_note.Text = "Удалить";
            this.delete_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_note.UseVisualStyleBackColor = false;
            this.delete_note.Click += new System.EventHandler(this.delete_note_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.BackColor = System.Drawing.Color.White;
            this.viewPanel.Controls.Add(this.searchPanel);
            this.viewPanel.Controls.Add(this.customersDataGridView);
            this.viewPanel.Controls.Add(this.add_button);
            this.viewPanel.Controls.Add(this.delete_note);
            this.viewPanel.Location = new System.Drawing.Point(151, 195);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(848, 390);
            this.viewPanel.TabIndex = 27;
            // 
            // bigWindowModeButton
            // 
            this.bigWindowModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bigWindowModeButton.BackColor = System.Drawing.Color.Transparent;
            this.bigWindowModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bigWindowModeButton.BackgroundImage")));
            this.bigWindowModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigWindowModeButton.InitialImage = null;
            this.bigWindowModeButton.Location = new System.Drawing.Point(1078, 3);
            this.bigWindowModeButton.Name = "bigWindowModeButton";
            this.bigWindowModeButton.Size = new System.Drawing.Size(53, 50);
            this.bigWindowModeButton.TabIndex = 28;
            this.bigWindowModeButton.TabStop = false;
            this.bigWindowModeButton.Click += new System.EventHandler(this.bigWindowModeButton_Click);
            // 
            // buttonsNamePanel
            // 
            this.buttonsNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.buttonsNamePanel.Controls.Add(this.backButton);
            this.buttonsNamePanel.Controls.Add(this.searchOpenButton);
            this.buttonsNamePanel.Controls.Add(this.app_name);
            this.buttonsNamePanel.Location = new System.Drawing.Point(151, 89);
            this.buttonsNamePanel.Name = "buttonsNamePanel";
            this.buttonsNamePanel.Size = new System.Drawing.Size(848, 100);
            this.buttonsNamePanel.TabIndex = 29;
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 664);
            this.Controls.Add(this.bigWindowModeButton);
            this.Controls.Add(this.createNewPanel);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.buttonsNamePanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.createNewPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).EndInit();
            this.viewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).EndInit();
            this.buttonsNamePanel.ResumeLayout(false);
            this.buttonsNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.Panel createNewPanel;
        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private other.accountingDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.MaskedTextBox kppMaskedBox;
        private System.Windows.Forms.MaskedTextBox innMaskedBox;
        private System.Windows.Forms.ComboBox registration_formMaskedBox;
        private other.accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox ogrnMaskedBox;
        private System.Windows.Forms.TextBox orgName;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.ComboBox search_text;
        private System.Windows.Forms.PictureBox searchOpenButton;
        private System.Windows.Forms.PictureBox closeAppButton;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private other.accountingDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Label worker_surname_label;
        private System.Windows.Forms.ComboBox worker_surname;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_note;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.PictureBox bigWindowModeButton;
        private System.Windows.Forms.Panel buttonsNamePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button agreecreatebutton;
    }
}