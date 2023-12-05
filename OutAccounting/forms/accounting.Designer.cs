namespace OutAccounting.forms
{
    partial class accounting
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
            System.Windows.Forms.Label tarifLabel;
            System.Windows.Forms.Label dateEndLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accounting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label customerSearchLabel;
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.appName = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.accountingTable = new System.Windows.Forms.DataGridView();
            this.deleteNote = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.monthsCountText = new System.Windows.Forms.NumericUpDown();
            this.agreeAddButton = new System.Windows.Forms.Button();
            this.customerNameText = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifNameText = new System.Windows.Forms.ComboBox();
            this.tarifsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.CustomersTableAdapter();
            this.tarifsTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.TarifsTableAdapter();
            this.delete_button_info = new System.Windows.Forms.ToolTip(this.components);
            this.searchOpenButton = new System.Windows.Forms.PictureBox();
            this.accountingTableAdapter1 = new OutAccounting.other.accountingDataSetTableAdapters.AccountingTableAdapter();
            this.closeAppButton = new System.Windows.Forms.PictureBox();
            this.bigWindowModeButton = new System.Windows.Forms.PictureBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.customerSearchText = new System.Windows.Forms.ComboBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.buttonsNamePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            nameLabel = new System.Windows.Forms.Label();
            tarifLabel = new System.Windows.Forms.Label();
            dateEndLabel = new System.Windows.Forms.Label();
            customerSearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingTable)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsCountText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).BeginInit();
            this.viewPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.buttonsNamePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            nameLabel.Location = new System.Drawing.Point(3, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(94, 27);
            nameLabel.TabIndex = 22;
            nameLabel.Text = "Клиент:";
            // 
            // tarifLabel
            // 
            tarifLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tarifLabel.AutoSize = true;
            tarifLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            tarifLabel.Location = new System.Drawing.Point(3, 72);
            tarifLabel.Name = "tarifLabel";
            tarifLabel.Size = new System.Drawing.Size(84, 27);
            tarifLabel.TabIndex = 24;
            tarifLabel.Text = "Тариф:";
            // 
            // dateEndLabel
            // 
            dateEndLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateEndLabel.AutoSize = true;
            dateEndLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            dateEndLabel.Location = new System.Drawing.Point(3, 115);
            dateEndLabel.Name = "dateEndLabel";
            dateEndLabel.Size = new System.Drawing.Size(231, 54);
            dateEndLabel.TabIndex = 27;
            dateEndLabel.Text = "Продолжительность договора в месяцах:";
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "accountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appName
            // 
            this.appName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.appName.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(460, 0);
            this.appName.Name = "appName";
            this.appName.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.appName.Size = new System.Drawing.Size(329, 83);
            this.appName.TabIndex = 13;
            this.appName.Text = "Учёт услуг";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(14, 19);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 53);
            this.backButton.TabIndex = 14;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // accountingTable
            // 
            this.accountingTable.AllowUserToAddRows = false;
            this.accountingTable.AllowUserToDeleteRows = false;
            this.accountingTable.AllowUserToResizeColumns = false;
            this.accountingTable.AllowUserToResizeRows = false;
            this.accountingTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountingTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountingTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.accountingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountingTable.DefaultCellStyle = dataGridViewCellStyle23;
            this.accountingTable.GridColor = System.Drawing.SystemColors.Control;
            this.accountingTable.Location = new System.Drawing.Point(14, 10);
            this.accountingTable.Name = "accountingTable";
            this.accountingTable.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountingTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.accountingTable.Size = new System.Drawing.Size(763, 294);
            this.accountingTable.TabIndex = 0;
            // 
            // deleteNote
            // 
            this.deleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.deleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNote.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNote.ForeColor = System.Drawing.Color.White;
            this.deleteNote.Location = new System.Drawing.Point(404, 314);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(373, 46);
            this.deleteNote.TabIndex = 2;
            this.deleteNote.Text = "Удалить";
            this.deleteNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_button_info.SetToolTip(this.deleteNote, "Для удаления необходимо выделить соответствующую строку!");
            this.deleteNote.UseVisualStyleBackColor = false;
            this.deleteNote.Click += new System.EventHandler(this.delete_note_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(14, 314);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(373, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.add_button_Click);
            // 
            // addPanel
            // 
            this.addPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.Controls.Add(this.tableLayoutPanel1);
            this.addPanel.Location = new System.Drawing.Point(141, 195);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(790, 375);
            this.addPanel.TabIndex = 4;
            this.addPanel.Visible = false;
            // 
            // monthsCountText
            // 
            this.monthsCountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.monthsCountText.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.monthsCountText.Location = new System.Drawing.Point(254, 125);
            this.monthsCountText.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.monthsCountText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthsCountText.Name = "monthsCountText";
            this.monthsCountText.Size = new System.Drawing.Size(478, 35);
            this.monthsCountText.TabIndex = 2;
            this.monthsCountText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agreeAddButton
            // 
            this.agreeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.agreeAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.agreeAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agreeAddButton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeAddButton.ForeColor = System.Drawing.Color.White;
            this.agreeAddButton.Location = new System.Drawing.Point(254, 177);
            this.agreeAddButton.Name = "agreeAddButton";
            this.agreeAddButton.Size = new System.Drawing.Size(478, 46);
            this.agreeAddButton.TabIndex = 3;
            this.agreeAddButton.Text = "Добавить запись";
            this.agreeAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agreeAddButton.UseVisualStyleBackColor = false;
            this.agreeAddButton.Click += new System.EventHandler(this.agree_add_Click);
            // 
            // customerNameText
            // 
            this.customerNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameText.DataSource = this.customersBindingSource;
            this.customerNameText.DisplayMember = "name";
            this.customerNameText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerNameText.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.customerNameText.FormattingEnabled = true;
            this.customerNameText.Location = new System.Drawing.Point(254, 11);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(478, 35);
            this.customerNameText.TabIndex = 0;
            this.customerNameText.ValueMember = "name";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.accountingDataSet;
            // 
            // tarifNameText
            // 
            this.tarifNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tarifNameText.DataSource = this.tarifsBindingSource;
            this.tarifNameText.DisplayMember = "name";
            this.tarifNameText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tarifNameText.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.tarifNameText.FormattingEnabled = true;
            this.tarifNameText.Location = new System.Drawing.Point(254, 68);
            this.tarifNameText.Name = "tarifNameText";
            this.tarifNameText.Size = new System.Drawing.Size(478, 35);
            this.tarifNameText.TabIndex = 1;
            this.tarifNameText.ValueMember = "name";
            // 
            // tarifsBindingSource
            // 
            this.tarifsBindingSource.DataMember = "Tarifs";
            this.tarifsBindingSource.DataSource = this.accountingDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tarifsTableAdapter
            // 
            this.tarifsTableAdapter.ClearBeforeFill = true;
            // 
            // searchOpenButton
            // 
            this.searchOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.searchOpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchOpenButton.BackgroundImage")));
            this.searchOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchOpenButton.Location = new System.Drawing.Point(75, 19);
            this.searchOpenButton.Name = "searchOpenButton";
            this.searchOpenButton.Size = new System.Drawing.Size(50, 51);
            this.searchOpenButton.TabIndex = 22;
            this.searchOpenButton.TabStop = false;
            this.searchOpenButton.Click += new System.EventHandler(this.search_open_Click);
            // 
            // accountingTableAdapter1
            // 
            this.accountingTableAdapter1.ClearBeforeFill = true;
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Transparent;
            this.closeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeAppButton.BackgroundImage")));
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeAppButton.Location = new System.Drawing.Point(1059, 4);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(53, 50);
            this.closeAppButton.TabIndex = 23;
            this.closeAppButton.TabStop = false;
            this.closeAppButton.Click += new System.EventHandler(this.close_app_button_Click);
            // 
            // bigWindowModeButton
            // 
            this.bigWindowModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bigWindowModeButton.BackColor = System.Drawing.Color.Transparent;
            this.bigWindowModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bigWindowModeButton.BackgroundImage")));
            this.bigWindowModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigWindowModeButton.InitialImage = null;
            this.bigWindowModeButton.Location = new System.Drawing.Point(1000, 4);
            this.bigWindowModeButton.Name = "bigWindowModeButton";
            this.bigWindowModeButton.Size = new System.Drawing.Size(53, 50);
            this.bigWindowModeButton.TabIndex = 29;
            this.bigWindowModeButton.TabStop = false;
            this.bigWindowModeButton.Click += new System.EventHandler(this.bigWindowModeButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.BackColor = System.Drawing.Color.White;
            this.viewPanel.Controls.Add(this.searchPanel);
            this.viewPanel.Controls.Add(this.accountingTable);
            this.viewPanel.Controls.Add(this.addButton);
            this.viewPanel.Controls.Add(this.deleteNote);
            this.viewPanel.Location = new System.Drawing.Point(142, 196);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(789, 372);
            this.viewPanel.TabIndex = 30;
            // 
            // customerSearchLabel
            // 
            customerSearchLabel.AutoSize = true;
            customerSearchLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            customerSearchLabel.Location = new System.Drawing.Point(9, 16);
            customerSearchLabel.Name = "customerSearchLabel";
            customerSearchLabel.Size = new System.Drawing.Size(94, 27);
            customerSearchLabel.TabIndex = 23;
            customerSearchLabel.Text = "Клиент:";
            // 
            // customerSearchText
            // 
            this.customerSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerSearchText.DataSource = this.customersBindingSource;
            this.customerSearchText.DisplayMember = "name";
            this.customerSearchText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerSearchText.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.customerSearchText.FormattingEnabled = true;
            this.customerSearchText.Location = new System.Drawing.Point(109, 13);
            this.customerSearchText.Name = "customerSearchText";
            this.customerSearchText.Size = new System.Drawing.Size(668, 35);
            this.customerSearchText.TabIndex = 0;
            this.customerSearchText.ValueMember = "name";
            this.customerSearchText.SelectedIndexChanged += new System.EventHandler(this.customer_search_SelectedIndexChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.customerSearchText);
            this.searchPanel.Controls.Add(customerSearchLabel);
            this.searchPanel.Location = new System.Drawing.Point(1, 308);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(789, 62);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.Visible = false;
            // 
            // buttonsNamePanel
            // 
            this.buttonsNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.buttonsNamePanel.Controls.Add(this.appName);
            this.buttonsNamePanel.Controls.Add(this.backButton);
            this.buttonsNamePanel.Controls.Add(this.searchOpenButton);
            this.buttonsNamePanel.Location = new System.Drawing.Point(143, 95);
            this.buttonsNamePanel.Name = "buttonsNamePanel";
            this.buttonsNamePanel.Size = new System.Drawing.Size(789, 91);
            this.buttonsNamePanel.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.agreeAddButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.monthsCountText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.customerNameText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(tarifLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(dateEndLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tarifNameText, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 230);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 654);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.bigWindowModeButton);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.buttonsNamePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "accounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutAccounting - Учёт услуг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.accounting_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.accounting_FormClosed);
            this.Load += new System.EventHandler(this.accounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingTable)).EndInit();
            this.addPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthsCountText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).EndInit();
            this.viewPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.buttonsNamePanel.ResumeLayout(false);
            this.buttonsNamePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.DataGridView accountingTable;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.ComboBox tarifNameText;
        private System.Windows.Forms.ComboBox customerNameText;
        private System.Windows.Forms.Button agreeAddButton;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private other.accountingDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource tarifsBindingSource;
        private other.accountingDataSetTableAdapters.TarifsTableAdapter tarifsTableAdapter;
        private System.Windows.Forms.ToolTip delete_button_info;
        private System.Windows.Forms.NumericUpDown monthsCountText;
        private System.Windows.Forms.PictureBox searchOpenButton;
        private other.accountingDataSetTableAdapters.AccountingTableAdapter accountingTableAdapter1;
        private System.Windows.Forms.PictureBox closeAppButton;
        private System.Windows.Forms.PictureBox bigWindowModeButton;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.ComboBox customerSearchText;
        private System.Windows.Forms.Panel buttonsNamePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}