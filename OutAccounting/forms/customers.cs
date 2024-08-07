﻿using dataBaseConnection;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;
using static System.Windows.Forms.LinkLabel;
using System.Reflection;

namespace OutAccounting.forms
{
    public partial class customers : Form
    {
        DataBase dataBase = new DataBase();
        WorkingWithData wWD = new WorkingWithData();

        string mainTable = "select Customers.name as [Организация], inn as [ИНН], kpp as [КПП], registration_form as [Форма регистрации], ogrn as [ОГРН], Workers.surname as [Сотрудник] from customers join Workers on worker = Workers.ID_worker";
        string pathSave = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\Документы_клиентов";
        string[] months_list = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };


        public customers()
        {
            InitializeComponent();
            wWD.comboBoxFuller("SELECT name FROM customers;", "name", search_text);
            if (CurrentUser.level == 5)
            {
                int workerID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_worker FROM Workers WHERE account = {CurrentUser.id};"));
                wWD.updateTable(mainTable + $" WHERE worker = {workerID}", customersDataGridView);
                wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {workerID};", "name", search_text);
            }
            else 
            {
                wWD.updateTable(mainTable, customersDataGridView);
            }

            if (customersDataGridView.Rows.Count == 0)
            {
                searchOpenButton.Visible = false;
            };

            if (CurrentUser.level == 4)
            {
                delete_note.Visible = false;
                add_button.Visible = false;
                customersDataGridView.Size = new Size(817, 363);
            };
        }

        private void customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.accountingDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.accountingDataSet.Customers);

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (createNewPanel.Visible == false && searchPanel.Visible == false)
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                if (CurrentUser.level == 4)
                {
                    wWD.updateTable(mainTable, customersDataGridView);
                }
                else
                {
                    int workerID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_worker FROM Workers WHERE account = {CurrentUser.id};"));
                    wWD.updateTable(mainTable + $" WHERE worker = {workerID}", customersDataGridView);
                }

                if (CurrentUser.level == 4)
                {
                    delete_note.Visible = false;
                    add_button.Visible = false;
                    customersDataGridView.Size = new Size(customersDataGridView.Width, customersDataGridView.Height + 50);
                };


                if (customersDataGridView.Rows.Count == 0)
                {
                    searchOpenButton.Visible = false;
                }
                else
                {
                    searchOpenButton.Visible = true;
                };
                createNewPanel.Visible = false;
                searchPanel.Visible = false;

                orgName.Clear();
                innMaskedBox.Clear();
                kppMaskedBox.Clear();
                ogrnMaskedBox.Clear();
            }
        }

        private void customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registration_formTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogrnMaskedBox.Mask = "";
            ogrnMaskedBox.Enabled = true;
            if (registration_formMaskedBox.SelectedIndex == 0)
            {
                ogrnMaskedBox.Mask = "000000000000000";
            }
            else
            {
                ogrnMaskedBox.Mask = "0000000000000";
            }
        }

        private void search_open_Click(object sender, EventArgs e)
        {
            if (CurrentUser.level == 4) customersDataGridView.Size = new Size(customersDataGridView.Width, customersDataGridView.Height - 50);

            createNewPanel.Visible = false;
            searchPanel.Visible = true;
            searchOpenButton.Visible = false;
        }

        private void search_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requestCustomerName = Convert.ToString(search_text.SelectedItem);
            int selectedCustomer_id = Convert.ToInt32(wWD.executeScalar($"Select id_customer from customers where name = N'{requestCustomerName}';"));

            wWD.updateTable($"select Customers.name as [Организация], inn as [ИНН], kpp as [КПП], registration_form as [Форма регистрации], ogrn as [ОГРН], Workers.surname as [Сотрудник] from customers join Workers on worker = Workers.ID_worker where ID_customer = {selectedCustomer_id};", customersDataGridView);
        }

        private void close_app_button_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Вы уверены, что хотите закрыть приложение? \nВсе несохранённые данные будут потеряны.", "Подтверждение закрытия приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            createNewPanel.Visible = true;
            searchOpenButton.Visible = false;
        }

        private void agreecreatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (orgName.Text == "" || innMaskedBox.Text == "" || kppMaskedBox.Text == "" || registration_formMaskedBox.Text == "" || ogrnMaskedBox.Text == "" ||
                    innMaskedBox.Text.Length != innMaskedBox.Mask.Length || kppMaskedBox.Text.Length != kppMaskedBox.Mask.Length || ogrnMaskedBox.Text.Length != ogrnMaskedBox.Mask.Length)
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                        string customerName = orgName.Text;
                        decimal inn = Convert.ToDecimal(innMaskedBox.Text);
                        decimal kpp = Convert.ToDecimal(kppMaskedBox.Text);
                        string registr = Convert.ToString(registration_formMaskedBox.SelectedItem);
                        decimal ogrn = Convert.ToDecimal(ogrnMaskedBox.Text);

                        int customerExists = wWD.noteExistsCheck($"select ID_customer from Customers where inn = {inn} OR ogrn = {ogrn} or name = N'{customerName}';");
                        if (customerExists != 0)
                        {
                            MessageBox.Show("Такой клиент уже есть в базе!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int seller = Convert.ToInt32(wWD.executeScalar($"select id_worker from workers where account = '{CurrentUser.id}'"));

                            wWD.operationsBuilder($"insert into Customers (name, inn, kpp, ogrn, registration_form, worker) values (N'{customerName}', {inn} , {kpp}, {ogrn}, N'{registr}', {seller})");
                            MessageBox.Show("Данные внесены, ожидайте создания документов!", "Данные внесены", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            try
                            {
                                Word._Application oWord = new Word.Application();
                                oWord.Visible = false;
                                Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\soglas1.dotx");
                                oDoc.Bookmarks["int_orgname"].Range.Text = customerName;
                                oDoc.Bookmarks["int_curdate"].Range.Text = DateTime.Now.Day.ToString();
                                oDoc.Bookmarks["int_curmonth"].Range.Text = months_list[DateTime.Now.Month - 1];
                                oDoc.Bookmarks["int_curyear"].Range.Text = DateTime.Today.Year.ToString();

                                DirectoryInfo folder = new DirectoryInfo(pathSave);
                                if (folder.Exists == false)
                                {
                                    Directory.CreateDirectory(pathSave);
                                }
                                string saveFolder = folder.FullName + $"\\{customerName}";
                                if (Directory.Exists(saveFolder) == false)
                                {
                                    Directory.CreateDirectory(saveFolder);
                                    pathSave = saveFolder;
                                }

                                object outputFileName = pathSave + $"\\Обработка_данных_{customerName}.pdf";
                                object fileFormat = WdSaveFormat.wdFormatPDF;

                                oDoc.SaveAs(ref outputFileName, ref fileFormat);

                                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                                oDoc.Close(ref saveChanges);
                                oWord.Quit();

                                MessageBox.Show("Данные успешно добавлены, а также на рабочем столе создан документ об обработке данных клиента!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                pathSave = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\Документы_клиентов";
                            }
                            catch
                            {
                                MessageBox.Show("Не удалось создать документы для клиента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            };

                            wWD.updateTable(mainTable + $" WHERE worker = {seller}", customersDataGridView);
                            wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {seller};", "name", search_text);

                            searchOpenButton.Visible = true;
                            createNewPanel.Visible = false;
                            orgName.Clear();
                            innMaskedBox.Clear();
                            kppMaskedBox.Clear();
                            ogrnMaskedBox.Clear();
                        }
                    } 
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_note_Click(object sender, EventArgs e)
        {
            string customerName, INN, OGRN;
            Int32 selectedRowCount = customersDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                foreach (DataGridViewRow row in customersDataGridView.SelectedRows)
                {
                    try
                    {
                        DialogResult deleteResult = MessageBox.Show("Вы уверены, что хотите \nразорвать контракт с клиентом?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (deleteResult == DialogResult.Yes)
                        {
                            customerName = row.Cells[0].Value.ToString();
                            INN = row.Cells[1].Value.ToString();
                            OGRN = row.Cells[4].Value.ToString();

                            wWD.operationsBuilder($"delete from customers where name = '{customerName}' and inn = {INN} and ogrn = {OGRN}");

                            DirectoryInfo folder = new DirectoryInfo(pathSave);
                            if (folder.Exists)
                            {
                                DirectoryInfo customerFolder = new DirectoryInfo(pathSave + $"\\{customerName}");
                                Directory.Delete(customerFolder.ToString(), true);
                            }
                            MessageBox.Show("Данные успешно удалены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            int seller = Convert.ToInt32(wWD.executeScalar($"select id_worker from workers where account = '{CurrentUser.id}'"));
                            wWD.updateTable(mainTable + $" WHERE worker = {seller}", customersDataGridView);
                            wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {seller};", "name", search_text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления, закройте документ или папку клиента для корректного удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Невозможно удалить, выберите одну строку и попробуйте снова!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bigWindowModeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                this.BackgroundImage = Properties.Resources.background_table_big;
                customersDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
                customersDataGridView.DefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                this.BackgroundImage = Properties.Resources.authorization_background;
                customersDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
                customersDataGridView.DefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
            };
        }
    }
}
