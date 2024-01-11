namespace OutAccounting.forms
{
    partial class archive
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
            System.Windows.Forms.Label customerSearchLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bigWindowModeButton = new System.Windows.Forms.PictureBox();
            this.closeAppButton = new System.Windows.Forms.PictureBox();
            this.appName = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.searchOpenButton = new System.Windows.Forms.PictureBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.createDocument = new System.Windows.Forms.Button();
            this.customerSearchText = new System.Windows.Forms.ComboBox();
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.archiveAccountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveAccountingTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.ArchiveAccountingTableAdapter();
            this.tableAdapterManager = new OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager();
            this.archiveAccountingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonsNamePanel = new System.Windows.Forms.Panel();
            customerSearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveAccountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveAccountingDataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.buttonsNamePanel.SuspendLayout();
            this.SuspendLayout();
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
            // bigWindowModeButton
            // 
            this.bigWindowModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bigWindowModeButton.BackColor = System.Drawing.Color.Transparent;
            this.bigWindowModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bigWindowModeButton.BackgroundImage")));
            this.bigWindowModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigWindowModeButton.InitialImage = null;
            this.bigWindowModeButton.Location = new System.Drawing.Point(1683, 12);
            this.bigWindowModeButton.Name = "bigWindowModeButton";
            this.bigWindowModeButton.Size = new System.Drawing.Size(53, 50);
            this.bigWindowModeButton.TabIndex = 31;
            this.bigWindowModeButton.TabStop = false;
            this.bigWindowModeButton.Click += new System.EventHandler(this.bigWindowModeButton_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Transparent;
            this.closeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeAppButton.BackgroundImage")));
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeAppButton.Location = new System.Drawing.Point(1742, 12);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(53, 50);
            this.closeAppButton.TabIndex = 30;
            this.closeAppButton.TabStop = false;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // appName
            // 
            this.appName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.appName.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(857, 20);
            this.appName.Name = "appName";
            this.appName.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.appName.Size = new System.Drawing.Size(686, 83);
            this.appName.TabIndex = 32;
            this.appName.Text = "Архив оказанных услуг";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(17, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 53);
            this.backButton.TabIndex = 33;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchOpenButton
            // 
            this.searchOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.searchOpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchOpenButton.BackgroundImage")));
            this.searchOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchOpenButton.Location = new System.Drawing.Point(78, 38);
            this.searchOpenButton.Name = "searchOpenButton";
            this.searchOpenButton.Size = new System.Drawing.Size(50, 51);
            this.searchOpenButton.TabIndex = 34;
            this.searchOpenButton.TabStop = false;
            this.searchOpenButton.Click += new System.EventHandler(this.searchOpenButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.createDocument);
            this.searchPanel.Controls.Add(this.customerSearchText);
            this.searchPanel.Controls.Add(customerSearchLabel);
            this.searchPanel.Location = new System.Drawing.Point(106, 725);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1553, 63);
            this.searchPanel.TabIndex = 35;
            this.searchPanel.Visible = false;
            // 
            // createDocument
            // 
            this.createDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.createDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createDocument.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDocument.ForeColor = System.Drawing.Color.White;
            this.createDocument.Location = new System.Drawing.Point(1012, 8);
            this.createDocument.Name = "createDocument";
            this.createDocument.Size = new System.Drawing.Size(530, 45);
            this.createDocument.TabIndex = 24;
            this.createDocument.Text = "Сохранить данные в документ";
            this.createDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createDocument.UseVisualStyleBackColor = false;
            this.createDocument.Click += new System.EventHandler(this.createDocument_Click);
            // 
            // customerSearchText
            // 
            this.customerSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customerSearchText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerSearchText.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.customerSearchText.FormattingEnabled = true;
            this.customerSearchText.Location = new System.Drawing.Point(109, 13);
            this.customerSearchText.Name = "customerSearchText";
            this.customerSearchText.Size = new System.Drawing.Size(896, 35);
            this.customerSearchText.TabIndex = 0;
            this.customerSearchText.SelectedIndexChanged += new System.EventHandler(this.customerSearchText_SelectedIndexChanged);
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "accountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archiveAccountingBindingSource
            // 
            this.archiveAccountingBindingSource.DataMember = "ArchiveAccounting";
            this.archiveAccountingBindingSource.DataSource = this.accountingDataSet;
            // 
            // archiveAccountingTableAdapter
            // 
            this.archiveAccountingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountingTableAdapter = null;
            this.tableAdapterManager.ArchiveAccountingTableAdapter = this.archiveAccountingTableAdapter;
            this.tableAdapterManager.ArchiveWorkersTableAdapter = null;
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.Service_informationTableAdapter = null;
            this.tableAdapterManager.TarifsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // archiveAccountingDataGridView
            // 
            this.archiveAccountingDataGridView.AllowUserToAddRows = false;
            this.archiveAccountingDataGridView.AllowUserToDeleteRows = false;
            this.archiveAccountingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveAccountingDataGridView.AutoGenerateColumns = false;
            this.archiveAccountingDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.archiveAccountingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.archiveAccountingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveAccountingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.archiveAccountingDataGridView.DataSource = this.archiveAccountingBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.archiveAccountingDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.archiveAccountingDataGridView.Location = new System.Drawing.Point(13, 13);
            this.archiveAccountingDataGridView.Name = "archiveAccountingDataGridView";
            this.archiveAccountingDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.archiveAccountingDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.archiveAccountingDataGridView.Size = new System.Drawing.Size(1531, 512);
            this.archiveAccountingDataGridView.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_archive";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "inn";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kpp";
            this.dataGridViewTextBoxColumn4.HeaderText = "КПП";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ogrn";
            this.dataGridViewTextBoxColumn5.HeaderText = "ОГРН";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "registration_form";
            this.dataGridViewTextBoxColumn6.HeaderText = "Форма регистрации";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "worker";
            this.dataGridViewTextBoxColumn7.HeaderText = "Работник";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tarif";
            this.dataGridViewTextBoxColumn8.HeaderText = "Тариф";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "end_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата завершения";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn11.HeaderText = "Итого";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.archiveAccountingDataGridView);
            this.mainPanel.Location = new System.Drawing.Point(104, 255);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1558, 537);
            this.mainPanel.TabIndex = 37;
            // 
            // buttonsNamePanel
            // 
            this.buttonsNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.buttonsNamePanel.Controls.Add(this.appName);
            this.buttonsNamePanel.Controls.Add(this.searchOpenButton);
            this.buttonsNamePanel.Controls.Add(this.backButton);
            this.buttonsNamePanel.Location = new System.Drawing.Point(104, 122);
            this.buttonsNamePanel.Name = "buttonsNamePanel";
            this.buttonsNamePanel.Size = new System.Drawing.Size(1558, 127);
            this.buttonsNamePanel.TabIndex = 38;
            // 
            // archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OutAccounting.Properties.Resources.background_table_big;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1807, 866);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.bigWindowModeButton);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonsNamePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "archive";
            this.Load += new System.EventHandler(this.archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOpenButton)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveAccountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveAccountingDataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.buttonsNamePanel.ResumeLayout(false);
            this.buttonsNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bigWindowModeButton;
        private System.Windows.Forms.PictureBox closeAppButton;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox searchOpenButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.ComboBox customerSearchText;
        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource archiveAccountingBindingSource;
        private other.accountingDataSetTableAdapters.ArchiveAccountingTableAdapter archiveAccountingTableAdapter;
        private other.accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView archiveAccountingDataGridView;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel buttonsNamePanel;
        private System.Windows.Forms.Button createDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}