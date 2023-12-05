namespace OutAccounting
{
    partial class tarifs
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
            System.Windows.Forms.Label price_per_monthLabel;
            System.Windows.Forms.Label servicesLabel;
            System.Windows.Forms.Label searchLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarifs));
            this.appName = new System.Windows.Forms.Label();
            this.tarifsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepermonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.tarifsTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.TarifsTableAdapter();
            this.deleteNote = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager = new OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager();
            this.searchOpenButton = new System.Windows.Forms.PictureBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchText = new System.Windows.Forms.ComboBox();
            this.close_app_button = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addTarifButton = new System.Windows.Forms.Button();
            this.agreeCreateButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.price_per_monthTextBox = new System.Windows.Forms.TextBox();
            this.servicesTextBox = new System.Windows.Forms.TextBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.bigWindowModeButton = new System.Windows.Forms.PictureBox();
            this.buttonsNamePanel = new System.Windows.Forms.Panel();
            nameLabel = new System.Windows.Forms.Label();
            price_per_monthLabel = new System.Windows.Forms.Label();
            servicesLabel = new System.Windows.Forms.Label();
            searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_app_button)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).BeginInit();
            this.buttonsNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(3, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(118, 27);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Название:";
            // 
            // price_per_monthLabel
            // 
            price_per_monthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            price_per_monthLabel.AutoSize = true;
            price_per_monthLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price_per_monthLabel.Location = new System.Drawing.Point(3, 94);
            price_per_monthLabel.Name = "price_per_monthLabel";
            price_per_monthLabel.Size = new System.Drawing.Size(167, 27);
            price_per_monthLabel.TabIndex = 12;
            price_per_monthLabel.Text = "Цена за месяц:";
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            servicesLabel.Location = new System.Drawing.Point(3, 144);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new System.Drawing.Size(88, 27);
            servicesLabel.TabIndex = 13;
            servicesLabel.Text = "Услуги:";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            searchLabel.Location = new System.Drawing.Point(15, 16);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new System.Drawing.Size(203, 27);
            searchLabel.TabIndex = 23;
            searchLabel.Text = "Название тарифа:";
            // 
            // appName
            // 
            this.appName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.appName.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(491, 0);
            this.appName.Name = "appName";
            this.appName.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.appName.Size = new System.Drawing.Size(255, 83);
            this.appName.TabIndex = 6;
            this.appName.Text = "Тарифы";
            // 
            // tarifsDataGridView
            // 
            this.tarifsDataGridView.AllowUserToAddRows = false;
            this.tarifsDataGridView.AllowUserToDeleteRows = false;
            this.tarifsDataGridView.AllowUserToResizeColumns = false;
            this.tarifsDataGridView.AllowUserToResizeRows = false;
            this.tarifsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarifsDataGridView.AutoGenerateColumns = false;
            this.tarifsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tarifsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tarifsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tarifsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tarifsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarifsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pricepermonthDataGridViewTextBoxColumn,
            this.servicesDataGridViewTextBoxColumn});
            this.tarifsDataGridView.DataSource = this.tarifsBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tarifsDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.tarifsDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.tarifsDataGridView.Location = new System.Drawing.Point(21, 16);
            this.tarifsDataGridView.Name = "tarifsDataGridView";
            this.tarifsDataGridView.ReadOnly = true;
            this.tarifsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tarifsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tarifsDataGridView.ShowCellToolTips = false;
            this.tarifsDataGridView.ShowEditingIcon = false;
            this.tarifsDataGridView.Size = new System.Drawing.Size(712, 296);
            this.tarifsDataGridView.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название тарифа";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // pricepermonthDataGridViewTextBoxColumn
            // 
            this.pricepermonthDataGridViewTextBoxColumn.DataPropertyName = "price_per_month";
            this.pricepermonthDataGridViewTextBoxColumn.HeaderText = "Цена за месяц";
            this.pricepermonthDataGridViewTextBoxColumn.Name = "pricepermonthDataGridViewTextBoxColumn";
            this.pricepermonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricepermonthDataGridViewTextBoxColumn.Width = 57;
            // 
            // servicesDataGridViewTextBoxColumn
            // 
            this.servicesDataGridViewTextBoxColumn.DataPropertyName = "services";
            this.servicesDataGridViewTextBoxColumn.HeaderText = "Услуги";
            this.servicesDataGridViewTextBoxColumn.Name = "servicesDataGridViewTextBoxColumn";
            this.servicesDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicesDataGridViewTextBoxColumn.Width = 485;
            // 
            // tarifsBindingSource
            // 
            this.tarifsBindingSource.DataMember = "Tarifs";
            this.tarifsBindingSource.DataSource = this.accountingDataSet;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "accountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarifsTableAdapter
            // 
            this.tarifsTableAdapter.ClearBeforeFill = true;
            // 
            // deleteNote
            // 
            this.deleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.deleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNote.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNote.ForeColor = System.Drawing.Color.White;
            this.deleteNote.Location = new System.Drawing.Point(417, 318);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(316, 46);
            this.deleteNote.TabIndex = 1;
            this.deleteNote.Text = "Удалить";
            this.deleteNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteNote.UseVisualStyleBackColor = false;
            this.deleteNote.Click += new System.EventHandler(this.delete_note_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.Controls.Add(this.tableLayoutPanel1);
            this.infoPanel.Location = new System.Drawing.Point(133, 196);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(753, 386);
            this.infoPanel.TabIndex = 0;
            this.infoPanel.Visible = false;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Location = new System.Drawing.Point(16, 17);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(55, 53);
            this.backbutton.TabIndex = 11;
            this.backbutton.TabStop = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountingTableAdapter = null;
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.Service_informationTableAdapter = null;
            this.tableAdapterManager.TarifsTableAdapter = this.tarifsTableAdapter;
            this.tableAdapterManager.UpdateOrder = OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // searchOpenButton
            // 
            this.searchOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.searchOpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchOpenButton.BackgroundImage")));
            this.searchOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchOpenButton.Location = new System.Drawing.Point(77, 17);
            this.searchOpenButton.Name = "searchOpenButton";
            this.searchOpenButton.Size = new System.Drawing.Size(50, 51);
            this.searchOpenButton.TabIndex = 23;
            this.searchOpenButton.TabStop = false;
            this.searchOpenButton.Click += new System.EventHandler(this.search_open_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Controls.Add(searchLabel);
            this.searchPanel.Location = new System.Drawing.Point(0, 316);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(739, 60);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Visible = false;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.DataSource = this.tarifsBindingSource;
            this.searchText.DisplayMember = "name";
            this.searchText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchText.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.searchText.FormattingEnabled = true;
            this.searchText.Location = new System.Drawing.Point(224, 12);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(501, 35);
            this.searchText.TabIndex = 0;
            this.searchText.ValueMember = "name";
            this.searchText.SelectedIndexChanged += new System.EventHandler(this.search_text_SelectedIndexChanged);
            // 
            // close_app_button
            // 
            this.close_app_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_app_button.BackColor = System.Drawing.Color.Transparent;
            this.close_app_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_app_button.BackgroundImage")));
            this.close_app_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_app_button.Location = new System.Drawing.Point(999, 5);
            this.close_app_button.Name = "close_app_button";
            this.close_app_button.Size = new System.Drawing.Size(53, 50);
            this.close_app_button.TabIndex = 25;
            this.close_app_button.TabStop = false;
            this.close_app_button.Click += new System.EventHandler(this.close_app_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.price_per_monthTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.agreeCreateButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.servicesTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(servicesLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(price_per_monthLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 335);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // addTarifButton
            // 
            this.addTarifButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addTarifButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.addTarifButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTarifButton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTarifButton.ForeColor = System.Drawing.Color.White;
            this.addTarifButton.Location = new System.Drawing.Point(21, 318);
            this.addTarifButton.Name = "addTarifButton";
            this.addTarifButton.Size = new System.Drawing.Size(316, 46);
            this.addTarifButton.TabIndex = 28;
            this.addTarifButton.Text = "Добавить";
            this.addTarifButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTarifButton.UseVisualStyleBackColor = false;
            this.addTarifButton.Click += new System.EventHandler(this.addTarifButton_Click);
            // 
            // agreeCreateButton
            // 
            this.agreeCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.agreeCreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.agreeCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agreeCreateButton.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeCreateButton.ForeColor = System.Drawing.Color.White;
            this.agreeCreateButton.Location = new System.Drawing.Point(176, 274);
            this.agreeCreateButton.Name = "agreeCreateButton";
            this.agreeCreateButton.Size = new System.Drawing.Size(544, 46);
            this.agreeCreateButton.TabIndex = 22;
            this.agreeCreateButton.Text = "Добавить тариф";
            this.agreeCreateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agreeCreateButton.UseVisualStyleBackColor = false;
            this.agreeCreateButton.Click += new System.EventHandler(this.agreecreatebutton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.nameTextBox.Location = new System.Drawing.Point(176, 18);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(544, 35);
            this.nameTextBox.TabIndex = 29;
            // 
            // price_per_monthTextBox
            // 
            this.price_per_monthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.price_per_monthTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.price_per_monthTextBox.Location = new System.Drawing.Point(176, 90);
            this.price_per_monthTextBox.Name = "price_per_monthTextBox";
            this.price_per_monthTextBox.Size = new System.Drawing.Size(544, 35);
            this.price_per_monthTextBox.TabIndex = 30;
            // 
            // servicesTextBox
            // 
            this.servicesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.servicesTextBox.Location = new System.Drawing.Point(176, 147);
            this.servicesTextBox.Multiline = true;
            this.servicesTextBox.Name = "servicesTextBox";
            this.servicesTextBox.Size = new System.Drawing.Size(544, 110);
            this.servicesTextBox.TabIndex = 31;
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.BackColor = System.Drawing.Color.White;
            this.viewPanel.Controls.Add(this.searchPanel);
            this.viewPanel.Controls.Add(this.tarifsDataGridView);
            this.viewPanel.Controls.Add(this.deleteNote);
            this.viewPanel.Controls.Add(this.addTarifButton);
            this.viewPanel.Location = new System.Drawing.Point(134, 196);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(749, 379);
            this.viewPanel.TabIndex = 29;
            // 
            // bigWindowModeButton
            // 
            this.bigWindowModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bigWindowModeButton.BackColor = System.Drawing.Color.Transparent;
            this.bigWindowModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bigWindowModeButton.BackgroundImage")));
            this.bigWindowModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigWindowModeButton.InitialImage = null;
            this.bigWindowModeButton.Location = new System.Drawing.Point(940, 5);
            this.bigWindowModeButton.Name = "bigWindowModeButton";
            this.bigWindowModeButton.Size = new System.Drawing.Size(53, 50);
            this.bigWindowModeButton.TabIndex = 29;
            this.bigWindowModeButton.TabStop = false;
            this.bigWindowModeButton.Click += new System.EventHandler(this.bigWindowModeButton_Click);
            // 
            // buttonsNamePanel
            // 
            this.buttonsNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.buttonsNamePanel.Controls.Add(this.appName);
            this.buttonsNamePanel.Controls.Add(this.searchOpenButton);
            this.buttonsNamePanel.Controls.Add(this.backbutton);
            this.buttonsNamePanel.Location = new System.Drawing.Point(134, 99);
            this.buttonsNamePanel.Name = "buttonsNamePanel";
            this.buttonsNamePanel.Size = new System.Drawing.Size(749, 91);
            this.buttonsNamePanel.TabIndex = 30;
            // 
            // tarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 660);
            this.Controls.Add(this.bigWindowModeButton);
            this.Controls.Add(this.close_app_button);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.buttonsNamePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tarifs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurAccounting - Тарифы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tarifs_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tarifs_FormClosed);
            this.Load += new System.EventHandler(this.tarifs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarifsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_app_button)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).EndInit();
            this.buttonsNamePanel.ResumeLayout(false);
            this.buttonsNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.DataGridView tarifsDataGridView;
        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource tarifsBindingSource;
        private other.accountingDataSetTableAdapters.TarifsTableAdapter tarifsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepermonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.PictureBox backbutton;
        private other.accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox searchOpenButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.ComboBox searchText;
        private System.Windows.Forms.PictureBox close_app_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addTarifButton;
        private System.Windows.Forms.Button agreeCreateButton;
        private System.Windows.Forms.TextBox price_per_monthTextBox;
        private System.Windows.Forms.TextBox servicesTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.PictureBox bigWindowModeButton;
        private System.Windows.Forms.Panel buttonsNamePanel;
    }
}