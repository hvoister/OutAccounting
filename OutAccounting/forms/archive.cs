using dataBaseConnection;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;
using Word = Microsoft.Office.Interop.Word;

namespace OutAccounting.forms
{
    public partial class archive : Form
    {
        dataBase dataBase = new dataBase();
        workingWithData wWD = new workingWithData();
        string mainTable = "SELECT * FROM ArchiveAccounting";

        string pathSave = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\Документы_клиентов";
        string[] months_list = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        public archive()
        {
            InitializeComponent();

            wWD.updateTable(mainTable, archiveAccountingDataGridView);
            wWD.comboBoxFuller($"SELECT DISTINCT customer FROM ArchiveAccounting;", "customer", customerSearchText);
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

        private void customerSearchText_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requesrCustomerName = Convert.ToString(customerSearchText.SelectedItem);

            wWD.updateTable($"select * from ArchiveAccounting where customer = N'{requesrCustomerName}';", archiveAccountingDataGridView);
        }

        private void createDocument_Click(object sender, EventArgs e)
        {
            DialogResult documentCreateResult;
            string tableQuery;
            string customerName = "";
            if (customerSearchText.SelectedItem != null) 
            {
                documentCreateResult = MessageBox.Show("Вы действительно хотите сохранить данные выбранного клиента в документ?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                customerName = customerSearchText.SelectedItem.ToString();
                tableQuery = $"SELECT ID_archive as [Номер записи], customer as [Клиент], inn as [ИНН], kpp as [КПП], ogrn as [ОГРН], registration_form as [Форма регистрации], worker as [Сотрудник], tarif as [Тариф], start_date as [Дата начала], end_date as [Дата окончания], total as [Итого] FROM ArchiveAccounting WHERE customer = N'{customerName}'";
            }
            else
            {
                documentCreateResult = MessageBox.Show("Вы действительно хотите сохранить данные всех клиентов в документ?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                tableQuery = $"SELECT ID_archive as [Номер записи], customer as [Клиент], inn as [ИНН], kpp as [КПП], ogrn as [ОГРН], registration_form as [Форма регистрации], worker as [Сотрудник], tarif as [Тариф], start_date as [Дата начала], end_date as [Дата окончания], total as [Итого] FROM ArchiveAccounting;";
            }
            if (documentCreateResult == DialogResult.Yes)
            {
                try
                {
                    Word._Application oWord = new Word.Application();
                    oWord.Visible = false;
                    Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\statistics.dotx");

                    oDoc.Bookmarks["date"].Range.Text = DateTime.Now.Day.ToString();
                    oDoc.Bookmarks["month"].Range.Text = months_list[DateTime.Now.Month - 1];
                    oDoc.Bookmarks["year"].Range.Text = DateTime.Now.Year.ToString();

                    dataBase.openConnection();
                    SqlDataAdapter docTable = new SqlDataAdapter(tableQuery, dataBase.getConnection());
                    DataTable resultTable = new DataTable();
                    docTable.Fill(resultTable);
                    dataBase.closeConnection();

                    Table table = oWord.Application.ActiveDocument.Tables.Add(oWord.Selection.Range, resultTable.Rows.Count + 1, resultTable.Columns.Count, Type.Missing, Type.Missing);
                    table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                    table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;

                    for (int i = 0; i < resultTable.Columns.Count; i++)
                    {
                        table.Cell(1, i + 1).Range.Text = resultTable.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < resultTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < resultTable.Columns.Count; j++)
                        {
                            table.Cell(i + 2, j + 1).Range.Text = resultTable.Rows[i][j].ToString();
                        }
                    }

                    DirectoryInfo folder = new DirectoryInfo(pathSave);
                    if (folder.Exists == false)
                    {
                        Directory.CreateDirectory(pathSave);
                    }
                    if (customerName == "")
                    {
                        oDoc.SaveAs(FileName: folder + $"\\Архив_записей.doc");
                    }
                    else {
                        oDoc.SaveAs(FileName: folder + $"\\Архив_записей_{customerName}.doc");
                    }
                    oDoc.Close();
                    oWord.Quit();
                    MessageBox.Show("Данные успешно сохранены в документ на рабочем столе в папке Документы_клиентов", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка импорта данных в документ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
