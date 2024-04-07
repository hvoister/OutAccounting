namespace OutAccounting.forms
{
    partial class statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statistic));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bigWindowModeButton = new System.Windows.Forms.PictureBox();
            this.closeAppButton = new System.Windows.Forms.PictureBox();
            this.workersStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statisticTable = new System.Windows.Forms.DataGridView();
            this.buttonsNamePanel = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.allTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.currentMonthRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersStatistic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticTable)).BeginInit();
            this.buttonsNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigWindowModeButton
            // 
            this.bigWindowModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bigWindowModeButton.BackColor = System.Drawing.Color.Transparent;
            this.bigWindowModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bigWindowModeButton.BackgroundImage")));
            this.bigWindowModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigWindowModeButton.InitialImage = null;
            this.bigWindowModeButton.Location = new System.Drawing.Point(1302, 12);
            this.bigWindowModeButton.Name = "bigWindowModeButton";
            this.bigWindowModeButton.Size = new System.Drawing.Size(53, 50);
            this.bigWindowModeButton.TabIndex = 33;
            this.bigWindowModeButton.TabStop = false;
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Transparent;
            this.closeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeAppButton.BackgroundImage")));
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeAppButton.Location = new System.Drawing.Point(1361, 12);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(53, 50);
            this.closeAppButton.TabIndex = 32;
            this.closeAppButton.TabStop = false;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // workersStatistic
            // 
            this.workersStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workersStatistic.BorderlineColor = System.Drawing.Color.Black;
            this.workersStatistic.BorderlineWidth = 3;
            chartArea3.Name = "ChartArea1";
            this.workersStatistic.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workersStatistic.Legends.Add(legend3);
            this.workersStatistic.Location = new System.Drawing.Point(3, 3);
            this.workersStatistic.Name = "workersStatistic";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.workersStatistic.Series.Add(series3);
            this.workersStatistic.Size = new System.Drawing.Size(870, 542);
            this.workersStatistic.TabIndex = 35;
            this.workersStatistic.Text = "workersStatistic";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.82003F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.17997F));
            this.tableLayoutPanel1.Controls.Add(this.workersStatistic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statisticTable, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 258);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 548);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // statisticTable
            // 
            this.statisticTable.AllowUserToAddRows = false;
            this.statisticTable.AllowUserToDeleteRows = false;
            this.statisticTable.AllowUserToResizeColumns = false;
            this.statisticTable.AllowUserToResizeRows = false;
            this.statisticTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.statisticTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.statisticTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.statisticTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticTable.GridColor = System.Drawing.SystemColors.Control;
            this.statisticTable.Location = new System.Drawing.Point(879, 3);
            this.statisticTable.Name = "statisticTable";
            this.statisticTable.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Linux Biolinum G", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.statisticTable.Size = new System.Drawing.Size(450, 542);
            this.statisticTable.TabIndex = 36;
            // 
            // buttonsNamePanel
            // 
            this.buttonsNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.buttonsNamePanel.Controls.Add(this.tableLayoutPanel2);
            this.buttonsNamePanel.Controls.Add(this.appName);
            this.buttonsNamePanel.Controls.Add(this.backButton);
            this.buttonsNamePanel.Location = new System.Drawing.Point(55, 98);
            this.buttonsNamePanel.Name = "buttonsNamePanel";
            this.buttonsNamePanel.Size = new System.Drawing.Size(1332, 154);
            this.buttonsNamePanel.TabIndex = 37;
            // 
            // appName
            // 
            this.appName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.appName.Font = new System.Drawing.Font("Linux Biolinum G", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(742, 9);
            this.appName.Name = "appName";
            this.appName.Padding = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.appName.Size = new System.Drawing.Size(576, 83);
            this.appName.TabIndex = 13;
            this.appName.Text = "Статистика работы";
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
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.allTimeRadioButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.currentMonthRadioButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(827, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(491, 36);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // allTimeRadioButton
            // 
            this.allTimeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTimeRadioButton.AutoSize = true;
            this.allTimeRadioButton.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.allTimeRadioButton.Location = new System.Drawing.Point(3, 3);
            this.allTimeRadioButton.Name = "allTimeRadioButton";
            this.allTimeRadioButton.Size = new System.Drawing.Size(239, 30);
            this.allTimeRadioButton.TabIndex = 0;
            this.allTimeRadioButton.TabStop = true;
            this.allTimeRadioButton.Text = "За всё время";
            this.allTimeRadioButton.UseVisualStyleBackColor = true;
            this.allTimeRadioButton.CheckedChanged += new System.EventHandler(this.allTimeRadioButton_CheckedChanged);
            // 
            // currentMonthRadioButton
            // 
            this.currentMonthRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentMonthRadioButton.AutoSize = true;
            this.currentMonthRadioButton.Font = new System.Drawing.Font("Linux Biolinum G", 18F);
            this.currentMonthRadioButton.Location = new System.Drawing.Point(248, 3);
            this.currentMonthRadioButton.Name = "currentMonthRadioButton";
            this.currentMonthRadioButton.Size = new System.Drawing.Size(240, 30);
            this.currentMonthRadioButton.TabIndex = 1;
            this.currentMonthRadioButton.TabStop = true;
            this.currentMonthRadioButton.Text = "За текущий месяц";
            this.currentMonthRadioButton.UseVisualStyleBackColor = true;
            this.currentMonthRadioButton.CheckedChanged += new System.EventHandler(this.currentMonthRadioButton_CheckedChanged);
            // 
            // statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OutAccounting.Properties.Resources.background_table_big;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 864);
            this.Controls.Add(this.buttonsNamePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bigWindowModeButton);
            this.Controls.Add(this.closeAppButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statistic";
            ((System.ComponentModel.ISupportInitialize)(this.bigWindowModeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersStatistic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticTable)).EndInit();
            this.buttonsNamePanel.ResumeLayout(false);
            this.buttonsNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bigWindowModeButton;
        private System.Windows.Forms.PictureBox closeAppButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart workersStatistic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView statisticTable;
        private System.Windows.Forms.Panel buttonsNamePanel;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton allTimeRadioButton;
        private System.Windows.Forms.RadioButton currentMonthRadioButton;
    }
}