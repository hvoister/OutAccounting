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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarifs));
            this.app_name = new System.Windows.Forms.Label();
            this.tarifsdata = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepermonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.tarifsTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.TarifsTableAdapter();
            this.delete_note = new System.Windows.Forms.Button();
            this.deletbutton = new System.Windows.Forms.PictureBox();
            this.infopanel = new System.Windows.Forms.Panel();
            this.createbitton = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.PictureBox();
            this.price_per_monthTextBox = new System.Windows.Forms.TextBox();
            this.moveright = new System.Windows.Forms.PictureBox();
            this.moveleft = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager = new OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager();
            this.workerpic = new System.Windows.Forms.PictureBox();
            this.bosspic = new System.Windows.Forms.PictureBox();
            this.servicesTextBox = new System.Windows.Forms.TextBox();
            this.fulltarifs = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            price_per_monthLabel = new System.Windows.Forms.Label();
            servicesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletbutton)).BeginInit();
            this.infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createbitton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosspic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulltarifs)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(38, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(118, 27);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Название:";
            // 
            // price_per_monthLabel
            // 
            price_per_monthLabel.AutoSize = true;
            price_per_monthLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price_per_monthLabel.Location = new System.Drawing.Point(38, 80);
            price_per_monthLabel.Name = "price_per_monthLabel";
            price_per_monthLabel.Size = new System.Drawing.Size(167, 27);
            price_per_monthLabel.TabIndex = 12;
            price_per_monthLabel.Text = "Цена за месяц:";
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            servicesLabel.Location = new System.Drawing.Point(38, 128);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new System.Drawing.Size(88, 27);
            servicesLabel.TabIndex = 13;
            servicesLabel.Text = "Услуги:";
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.app_name.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.ForeColor = System.Drawing.Color.White;
            this.app_name.Location = new System.Drawing.Point(624, 100);
            this.app_name.Name = "app_name";
            this.app_name.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.app_name.Size = new System.Drawing.Size(255, 83);
            this.app_name.TabIndex = 6;
            this.app_name.Text = "Тарифы";
            // 
            // tarifsdata
            // 
            this.tarifsdata.AllowUserToAddRows = false;
            this.tarifsdata.AllowUserToDeleteRows = false;
            this.tarifsdata.AllowUserToResizeColumns = false;
            this.tarifsdata.AllowUserToResizeRows = false;
            this.tarifsdata.AutoGenerateColumns = false;
            this.tarifsdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tarifsdata.BackgroundColor = System.Drawing.Color.White;
            this.tarifsdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tarifsdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tarifsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarifsdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pricepermonthDataGridViewTextBoxColumn,
            this.servicesDataGridViewTextBoxColumn});
            this.tarifsdata.DataSource = this.tarifsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tarifsdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.tarifsdata.GridColor = System.Drawing.SystemColors.Control;
            this.tarifsdata.Location = new System.Drawing.Point(155, 212);
            this.tarifsdata.Name = "tarifsdata";
            this.tarifsdata.ReadOnly = true;
            this.tarifsdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tarifsdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tarifsdata.ShowCellToolTips = false;
            this.tarifsdata.ShowEditingIcon = false;
            this.tarifsdata.Size = new System.Drawing.Size(705, 296);
            this.tarifsdata.TabIndex = 7;
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
            // delete_note
            // 
            this.delete_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.delete_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_note.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_note.ForeColor = System.Drawing.Color.White;
            this.delete_note.Location = new System.Drawing.Point(97, 514);
            this.delete_note.Name = "delete_note";
            this.delete_note.Size = new System.Drawing.Size(316, 46);
            this.delete_note.TabIndex = 8;
            this.delete_note.Text = "Удалить";
            this.delete_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_note.UseVisualStyleBackColor = false;
            this.delete_note.Click += new System.EventHandler(this.delete_note_Click);
            // 
            // deletbutton
            // 
            this.deletbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.deletbutton.Location = new System.Drawing.Point(97, 514);
            this.deletbutton.Name = "deletbutton";
            this.deletbutton.Size = new System.Drawing.Size(316, 46);
            this.deletbutton.TabIndex = 9;
            this.deletbutton.TabStop = false;
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.Color.White;
            this.infopanel.Controls.Add(this.fulltarifs);
            this.infopanel.Controls.Add(this.deletebutton);
            this.infopanel.Controls.Add(this.createbitton);
            this.infopanel.Controls.Add(price_per_monthLabel);
            this.infopanel.Controls.Add(this.price_per_monthTextBox);
            this.infopanel.Controls.Add(servicesLabel);
            this.infopanel.Controls.Add(this.servicesTextBox);
            this.infopanel.Controls.Add(this.moveright);
            this.infopanel.Controls.Add(this.moveleft);
            this.infopanel.Controls.Add(nameLabel);
            this.infopanel.Controls.Add(this.nameTextBox);
            this.infopanel.Controls.Add(this.workerpic);
            this.infopanel.Controls.Add(this.bosspic);
            this.infopanel.Location = new System.Drawing.Point(134, 197);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(753, 386);
            this.infopanel.TabIndex = 10;
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
            this.createbitton.Visible = false;
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
            // price_per_monthTextBox
            // 
            this.price_per_monthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarifsBindingSource, "price_per_month", true));
            this.price_per_monthTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_per_monthTextBox.Location = new System.Drawing.Point(211, 77);
            this.price_per_monthTextBox.Name = "price_per_monthTextBox";
            this.price_per_monthTextBox.Size = new System.Drawing.Size(512, 35);
            this.price_per_monthTextBox.TabIndex = 13;
            // 
            // moveright
            // 
            this.moveright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.moveright.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moveright.BackgroundImage")));
            this.moveright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveright.Location = new System.Drawing.Point(658, 310);
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
            this.moveleft.Location = new System.Drawing.Point(601, 310);
            this.moveleft.Name = "moveleft";
            this.moveleft.Size = new System.Drawing.Size(65, 62);
            this.moveleft.TabIndex = 12;
            this.moveleft.TabStop = false;
            this.moveleft.Click += new System.EventHandler(this.moveleft_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarifsBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(162, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(561, 35);
            this.nameTextBox.TabIndex = 12;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Location = new System.Drawing.Point(150, 116);
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
            this.tableAdapterManager.TarifsTableAdapter = this.tarifsTableAdapter;
            this.tableAdapterManager.UpdateOrder = OutAccounting.other.accountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // workerpic
            // 
            this.workerpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.workerpic.Location = new System.Drawing.Point(503, 310);
            this.workerpic.Name = "workerpic";
            this.workerpic.Size = new System.Drawing.Size(223, 62);
            this.workerpic.TabIndex = 17;
            this.workerpic.TabStop = false;
            this.workerpic.Visible = false;
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
            // servicesTextBox
            // 
            this.servicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarifsBindingSource, "services", true));
            this.servicesTextBox.Font = new System.Drawing.Font("Linux Biolinum G", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesTextBox.Location = new System.Drawing.Point(132, 125);
            this.servicesTextBox.Multiline = true;
            this.servicesTextBox.Name = "servicesTextBox";
            this.servicesTextBox.Size = new System.Drawing.Size(591, 179);
            this.servicesTextBox.TabIndex = 14;
            // 
            // fulltarifs
            // 
            this.fulltarifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.fulltarifs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fulltarifs.BackgroundImage")));
            this.fulltarifs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fulltarifs.Location = new System.Drawing.Point(540, 310);
            this.fulltarifs.Name = "fulltarifs";
            this.fulltarifs.Size = new System.Drawing.Size(65, 62);
            this.fulltarifs.TabIndex = 19;
            this.fulltarifs.TabStop = false;
            this.fulltarifs.Visible = false;
            this.fulltarifs.Click += new System.EventHandler(this.fulltarifs_Click);
            // 
            // tarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 660);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.deletbutton);
            this.Controls.Add(this.delete_note);
            this.Controls.Add(this.tarifsdata);
            this.Controls.Add(this.app_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tarifs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurAccounting - Тарифы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tarifs_FormClosed);
            this.Load += new System.EventHandler(this.tarifs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarifsdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletbutton)).EndInit();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createbitton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosspic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulltarifs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.DataGridView tarifsdata;
        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource tarifsBindingSource;
        private other.accountingDataSetTableAdapters.TarifsTableAdapter tarifsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepermonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delete_note;
        private System.Windows.Forms.PictureBox deletbutton;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.PictureBox moveleft;
        private System.Windows.Forms.PictureBox moveright;
        private System.Windows.Forms.TextBox price_per_monthTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private other.accountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox deletebutton;
        private System.Windows.Forms.PictureBox createbitton;
        private System.Windows.Forms.PictureBox workerpic;
        private System.Windows.Forms.TextBox servicesTextBox;
        private System.Windows.Forms.PictureBox bosspic;
        private System.Windows.Forms.PictureBox fulltarifs;
    }
}