using dataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutAccounting.forms
{
    public partial class archive : Form
    {
        dataBase dataBase = new dataBase();
        workingWithData wWD = new workingWithData();
        string mainTable = "SELECT * FROM ArchiveAccounting";

        public archive()
        {
            InitializeComponent();

            wWD.updateTable(mainTable, archiveAccountingDataGridView);
            wWD.comboBoxFuller($"SELECT name FROM customers;", "name", customerSearchText);
        }

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Вы уверены, что хотите закрыть приложение? \nВсе несохранённые данные будут потеряны.", "Подтверждение закрытия приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bigWindowModeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                this.BackgroundImage = Properties.Resources.background_table_big;
                archiveAccountingDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
                archiveAccountingDataGridView.DefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                this.BackgroundImage = Properties.Resources.authorization_background;
                archiveAccountingDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
                archiveAccountingDataGridView.DefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
            };
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Visible == false)
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                wWD.updateTable(mainTable, archiveAccountingDataGridView);
                if (current_user.level == 1)
                {
                    if (WindowState != FormWindowState.Maximized) archiveAccountingDataGridView.Size = new Size(1531, 512);
                }

                searchPanel.Visible = false;
                searchOpenButton.Visible = true;
            }
        }

        private void archiveAccountingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.archiveAccountingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountingDataSet);

        }

        private void archive_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.ArchiveAccounting". При необходимости она может быть перемещена или удалена.
            this.archiveAccountingTableAdapter.Fill(this.accountingDataSet.ArchiveAccounting);

        }

        private void searchOpenButton_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized) archiveAccountingDataGridView.Size = new Size(1531, 450);
            searchPanel.Visible = true;
            searchOpenButton.Visible = false;
        }
    }
}
