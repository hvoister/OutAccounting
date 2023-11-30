﻿namespace OutAccounting.forms
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accounting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accountingDataSet = new OutAccounting.other.accountingDataSet();
            this.app_name = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.accountingtable = new System.Windows.Forms.DataGridView();
            this.delete_note = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.add_panel = new System.Windows.Forms.Panel();
            this.months_count = new System.Windows.Forms.NumericUpDown();
            this.agree_add = new System.Windows.Forms.Button();
            this.customer_name = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.end_date = new System.Windows.Forms.MaskedTextBox();
            this.tarif_name = new System.Windows.Forms.ComboBox();
            this.tarifsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.CustomersTableAdapter();
            this.tarifsTableAdapter = new OutAccounting.other.accountingDataSetTableAdapters.TarifsTableAdapter();
            this.delete_button_info = new System.Windows.Forms.ToolTip(this.components);
            this.search_panel = new System.Windows.Forms.Panel();
            this.customer_search = new System.Windows.Forms.ComboBox();
            this.search_open = new System.Windows.Forms.PictureBox();
            this.accountingTableAdapter1 = new OutAccounting.other.accountingDataSetTableAdapters.AccountingTableAdapter();
            this.close_app_button = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            tarifLabel = new System.Windows.Forms.Label();
            dateEndLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingtable)).BeginInit();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.months_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).BeginInit();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_app_button)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            nameLabel.Location = new System.Drawing.Point(48, 96);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(94, 27);
            nameLabel.TabIndex = 22;
            nameLabel.Text = "Клиент:";
            // 
            // tarifLabel
            // 
            tarifLabel.AutoSize = true;
            tarifLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            tarifLabel.Location = new System.Drawing.Point(48, 146);
            tarifLabel.Name = "tarifLabel";
            tarifLabel.Size = new System.Drawing.Size(84, 27);
            tarifLabel.TabIndex = 24;
            tarifLabel.Text = "Тариф:";
            // 
            // dateEndLabel
            // 
            dateEndLabel.AutoSize = true;
            dateEndLabel.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            dateEndLabel.Location = new System.Drawing.Point(48, 196);
            dateEndLabel.Name = "dateEndLabel";
            dateEndLabel.Size = new System.Drawing.Size(438, 27);
            dateEndLabel.TabIndex = 27;
            dateEndLabel.Text = "Продолжительность договора в месяцах:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            label1.Location = new System.Drawing.Point(9, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 27);
            label1.TabIndex = 23;
            label1.Text = "Клиент:";
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "accountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.app_name.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.ForeColor = System.Drawing.Color.White;
            this.app_name.Location = new System.Drawing.Point(602, 99);
            this.app_name.Name = "app_name";
            this.app_name.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.app_name.Size = new System.Drawing.Size(329, 83);
            this.app_name.TabIndex = 13;
            this.app_name.Text = "Учёт услуг";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Location = new System.Drawing.Point(156, 114);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(55, 53);
            this.backbutton.TabIndex = 14;
            this.backbutton.TabStop = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // accountingtable
            // 
            this.accountingtable.AllowUserToAddRows = false;
            this.accountingtable.AllowUserToDeleteRows = false;
            this.accountingtable.AllowUserToResizeColumns = false;
            this.accountingtable.AllowUserToResizeRows = false;
            this.accountingtable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountingtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.accountingtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountingtable.DefaultCellStyle = dataGridViewCellStyle2;
            this.accountingtable.GridColor = System.Drawing.SystemColors.Control;
            this.accountingtable.Location = new System.Drawing.Point(156, 207);
            this.accountingtable.Name = "accountingtable";
            this.accountingtable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountingtable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.accountingtable.Size = new System.Drawing.Size(763, 294);
            this.accountingtable.TabIndex = 0;
            // 
            // delete_note
            // 
            this.delete_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.delete_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_note.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_note.ForeColor = System.Drawing.Color.White;
            this.delete_note.Location = new System.Drawing.Point(546, 510);
            this.delete_note.Name = "delete_note";
            this.delete_note.Size = new System.Drawing.Size(373, 46);
            this.delete_note.TabIndex = 2;
            this.delete_note.Text = "Удалить";
            this.delete_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_button_info.SetToolTip(this.delete_note, "Для удаления необходимо выделить соответствующую строку!");
            this.delete_note.UseVisualStyleBackColor = false;
            this.delete_note.Click += new System.EventHandler(this.delete_note_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(156, 510);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(373, 46);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_panel
            // 
            this.add_panel.BackColor = System.Drawing.Color.White;
            this.add_panel.Controls.Add(this.months_count);
            this.add_panel.Controls.Add(this.agree_add);
            this.add_panel.Controls.Add(this.customer_name);
            this.add_panel.Controls.Add(dateEndLabel);
            this.add_panel.Controls.Add(this.end_date);
            this.add_panel.Controls.Add(this.tarif_name);
            this.add_panel.Controls.Add(tarifLabel);
            this.add_panel.Controls.Add(nameLabel);
            this.add_panel.Location = new System.Drawing.Point(141, 192);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(790, 375);
            this.add_panel.TabIndex = 4;
            this.add_panel.Visible = false;
            // 
            // months_count
            // 
            this.months_count.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.months_count.Location = new System.Drawing.Point(492, 192);
            this.months_count.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.months_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.months_count.Name = "months_count";
            this.months_count.Size = new System.Drawing.Size(268, 35);
            this.months_count.TabIndex = 2;
            this.months_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agree_add
            // 
            this.agree_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(110)))), ((int)(((byte)(171)))));
            this.agree_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agree_add.Font = new System.Drawing.Font("Linux Biolinum G", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agree_add.ForeColor = System.Drawing.Color.White;
            this.agree_add.Location = new System.Drawing.Point(405, 241);
            this.agree_add.Name = "agree_add";
            this.agree_add.Size = new System.Drawing.Size(355, 46);
            this.agree_add.TabIndex = 3;
            this.agree_add.Text = "Добавить запись";
            this.agree_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agree_add.UseVisualStyleBackColor = false;
            this.agree_add.Click += new System.EventHandler(this.agree_add_Click);
            // 
            // customer_name
            // 
            this.customer_name.DataSource = this.customersBindingSource;
            this.customer_name.DisplayMember = "name";
            this.customer_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customer_name.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.customer_name.FormattingEnabled = true;
            this.customer_name.Location = new System.Drawing.Point(148, 93);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(612, 35);
            this.customer_name.TabIndex = 0;
            this.customer_name.ValueMember = "name";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.accountingDataSet;
            // 
            // end_date
            // 
            this.end_date.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.end_date.Location = new System.Drawing.Point(525, 192);
            this.end_date.Mask = "00/00/0000";
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(10, 35);
            this.end_date.TabIndex = 26;
            this.end_date.ValidatingType = typeof(System.DateTime);
            // 
            // tarif_name
            // 
            this.tarif_name.DataSource = this.tarifsBindingSource;
            this.tarif_name.DisplayMember = "name";
            this.tarif_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tarif_name.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.tarif_name.FormattingEnabled = true;
            this.tarif_name.Location = new System.Drawing.Point(138, 143);
            this.tarif_name.Name = "tarif_name";
            this.tarif_name.Size = new System.Drawing.Size(622, 35);
            this.tarif_name.TabIndex = 1;
            this.tarif_name.ValueMember = "name";
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
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.Color.White;
            this.search_panel.Controls.Add(this.customer_search);
            this.search_panel.Controls.Add(label1);
            this.search_panel.Location = new System.Drawing.Point(142, 506);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(789, 62);
            this.search_panel.TabIndex = 3;
            this.search_panel.Visible = false;
            // 
            // customer_search
            // 
            this.customer_search.DataSource = this.customersBindingSource;
            this.customer_search.DisplayMember = "name";
            this.customer_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customer_search.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.customer_search.FormattingEnabled = true;
            this.customer_search.Location = new System.Drawing.Point(109, 13);
            this.customer_search.Name = "customer_search";
            this.customer_search.Size = new System.Drawing.Size(668, 35);
            this.customer_search.TabIndex = 0;
            this.customer_search.ValueMember = "name";
            this.customer_search.SelectedIndexChanged += new System.EventHandler(this.customer_search_SelectedIndexChanged);
            // 
            // search_open
            // 
            this.search_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.search_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_open.BackgroundImage")));
            this.search_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_open.Location = new System.Drawing.Point(217, 114);
            this.search_open.Name = "search_open";
            this.search_open.Size = new System.Drawing.Size(50, 51);
            this.search_open.TabIndex = 22;
            this.search_open.TabStop = false;
            this.search_open.Click += new System.EventHandler(this.search_open_Click);
            // 
            // accountingTableAdapter1
            // 
            this.accountingTableAdapter1.ClearBeforeFill = true;
            // 
            // close_app_button
            // 
            this.close_app_button.BackColor = System.Drawing.Color.Transparent;
            this.close_app_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_app_button.BackgroundImage")));
            this.close_app_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_app_button.Location = new System.Drawing.Point(1059, 4);
            this.close_app_button.Name = "close_app_button";
            this.close_app_button.Size = new System.Drawing.Size(53, 50);
            this.close_app_button.TabIndex = 23;
            this.close_app_button.TabStop = false;
            this.close_app_button.Click += new System.EventHandler(this.close_app_button_Click);
            // 
            // accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 654);
            this.Controls.Add(this.close_app_button);
            this.Controls.Add(this.search_open);
            this.Controls.Add(this.search_panel);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.delete_note);
            this.Controls.Add(this.accountingtable);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.app_name);
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
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingtable)).EndInit();
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.months_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifsBindingSource)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_app_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private other.accountingDataSet accountingDataSet;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.DataGridView accountingtable;
        private System.Windows.Forms.Button delete_note;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Panel add_panel;
        private System.Windows.Forms.MaskedTextBox end_date;
        private System.Windows.Forms.ComboBox tarif_name;
        private System.Windows.Forms.ComboBox customer_name;
        private System.Windows.Forms.Button agree_add;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private other.accountingDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource tarifsBindingSource;
        private other.accountingDataSetTableAdapters.TarifsTableAdapter tarifsTableAdapter;
        private System.Windows.Forms.ToolTip delete_button_info;
        private System.Windows.Forms.NumericUpDown months_count;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.PictureBox search_open;
        private other.accountingDataSetTableAdapters.AccountingTableAdapter accountingTableAdapter1;
        private System.Windows.Forms.ComboBox customer_search;
        private System.Windows.Forms.PictureBox close_app_button;
    }
}