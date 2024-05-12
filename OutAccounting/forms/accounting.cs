using dataBaseConnection;
using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using Font = System.Drawing.Font;
using Word = Microsoft.Office.Interop.Word;

namespace OutAccounting.forms
{
    public partial class accounting : Form
    {
        dataBase dataBase = new dataBase();
        workingWithData wWD = new workingWithData();

        string mainTable = "select Customers.name AS [Клиент], Tarifs.name AS [Тариф], " +
                "Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] " +
                "from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif";

        string pathSave = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\Документы_клиентов";
        string[] months_list = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

    public accounting()
    {
            InitializeComponent();
            wWD.comboBoxFuller($"SELECT name FROM customers;", "name", customerSearchText);
            if (current_user.level == 2)
            {
                int workerID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_worker FROM Workers WHERE account = {current_user.id};"));
                wWD.updateTable(mainTable + $" WHERE worker = {workerID}", accountingTable);
                wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {workerID};", "name", customerSearchText);
            }
            else
            {
                wWD.updateTable(mainTable, accountingTable);
            }

            if (current_user.level == 1)
            {
                deleteNote.Visible = false;
                addButton.Visible = false;
                accountingTable.Size = new Size(763, 349);
            }

            if (accountingTable.Rows.Count == 0)
            {
                searchOpenButton.Visible = false;
            }
            else
            {
                searchOpenButton.Visible = true;
            };
        }

        private void accounting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void accounting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (addPanel.Visible == false && searchPanel.Visible == false)
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                if (current_user.level == 2)
                {
                    int workerID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_worker FROM Workers WHERE account = {current_user.id};"));
                    wWD.updateTable(mainTable + $" WHERE worker = {workerID}", accountingTable);
                    wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {workerID};", "name", customerSearchText);
                }
                else
                {
                    wWD.updateTable(mainTable, accountingTable);
                }
                if (current_user.level == 1)
                {
                    deleteNote.Visible = false;
                    addButton.Visible = false;
                    accountingTable.Size = new Size(accountingTable.Width, accountingTable.Height + 55);
                }

                addPanel.Visible = false;
                searchPanel.Visible = false;
                if (accountingTable.Rows.Count == 0)
                {
                    searchOpenButton.Visible = false;
                }
                else
                {
                    searchOpenButton.Visible = true;
                };
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int workerID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_worker FROM Workers WHERE account = {current_user.id};"));
            int customersExist = wWD.noteExistsCheck($"SELECT ID_customer FROM customers WHERE worker = {workerID};");
            int tarifsExist = wWD.noteExistsCheck("SELECT ID_tarif FROM tarifs;");
            if (customersExist != 0)
            {
                if (tarifsExist != 0)
                {
                    wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {workerID};", "name", customerNameText);
                    addPanel.Visible = true;
                    searchOpenButton.Visible = false;
                }
                else
                {
                    MessageBox.Show("Добавьте тарифы для работы с заказами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Добавьте клиентов для работы с заказами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accounting_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Tarifs". При необходимости она может быть перемещена или удалена.
            this.tarifsTableAdapter.Fill(this.accountingDataSet.Tarifs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.accountingDataSet.Customers);

        }

        private void agree_add_Click(object sender, EventArgs e)
        {
            try
            {
                string requestCustomerName = Convert.ToString(customerNameText.SelectedItem);
                DirectoryInfo customerFolder = new DirectoryInfo(pathSave + $"{requestCustomerName}");
                if (customerFolder.Exists == false)
                {
                    Directory.CreateDirectory(pathSave + $"/{requestCustomerName}");
                    Word._Application oWord = new Word.Application();
                    oWord.Visible = false;
                    Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\soglas1.dotx");
                    oDoc.Bookmarks["int_orgname"].Range.Text = requestCustomerName;
                    oDoc.Bookmarks["int_curdate"].Range.Text = DateTime.Now.Day.ToString();
                    oDoc.Bookmarks["int_curmonth"].Range.Text = months_list[DateTime.Now.Month - 1];
                    oDoc.Bookmarks["int_curyear"].Range.Text = DateTime.Today.Year.ToString();

                    object outputFileName = pathSave + $"\\{requestCustomerName}\\Обработка_данных_{requestCustomerName}.pdf";
                    object fileFormat = WdSaveFormat.wdFormatPDF;

                    oDoc.SaveAs(ref outputFileName, ref fileFormat);

                    object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                    oDoc.Close(ref saveChanges);
                    oWord.Quit();
                };

                    string requestTarifName = Convert.ToString(tarifNameText.SelectedValue);
                    DateTime startDate = DateTime.Now.ToLocalTime();

                    int months = ((int)monthsCountText.Value);
                    string finishDateString = Convert.ToString(startDate.AddMonths(months));
                    DateTime finishDate = Convert.ToDateTime(finishDateString);

                    int customerID = Convert.ToInt32(wWD.executeScalar($"Select id_customer from customers where name = N'{requestCustomerName}'"));
                    int tarifID = Convert.ToInt32(wWD.executeScalar($"Select id_tarif from tarifs where name = N'{requestTarifName}'"));

                    int accountingExists = wWD.noteExistsCheck($"SELECT ID_note FROM Accounting WHERE customer = {customerID};");

                    if (accountingExists == 0)
                    {
                        if (finishDate > startDate)
                        {
                            string start = startDate.ToString("O");
                            string end = finishDate.ToString("O");

                            int tarifPrice = Convert.ToInt32(wWD.executeScalar($"Select price_per_month from tarifs where ID_tarif = N'{tarifID}'"));
                            int total = tarifPrice * Convert.ToInt32(monthsCountText.Value);

                            wWD.operationsBuilder($"insert into accounting (customer, tarif, start_date, end_date, total) values ({customerID}, {tarifID}, '{start}', '{end}', {total});");

                            try
                            {
                                int number = Convert.ToInt32(wWD.executeScalar($"Select ID_note from Accounting where customer = {customerID} AND tarif = {tarifID} and start_date = '{start}'"));
                                string tarifDescription = Convert.ToString(wWD.executeScalar($"Select services from tarifs where id_tarif = {tarifID}"));
                                decimal INN = Convert.ToDecimal(wWD.executeScalar($"Select inn from customers where id_customer = {customerID}"));
                                decimal KPP = Convert.ToDecimal(wWD.executeScalar($"Select kpp from customers where id_customer = {customerID}"));
                                string regform = Convert.ToString(wWD.executeScalar($"Select registration_form from customers where id_customer = {customerID}"));
                                decimal OGRN = Convert.ToDecimal(wWD.executeScalar($"Select ogrn from customers where id_customer = {customerID}"));

                                Word._Application oWord = new Word.Application();
                                oWord.Visible = false;
                                Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\customer_add2.dotx");
                                oDoc.Bookmarks["in_number"].Range.Text = number.ToString();
                                oDoc.Bookmarks["in_date"].Range.Text = startDate.Day.ToString();
                                oDoc.Bookmarks["in_month"].Range.Text = months_list[startDate.Month - 1];
                                oDoc.Bookmarks["in_year"].Range.Text = startDate.Year.ToString();
                                oDoc.Bookmarks["in_customer"].Range.Text = requestCustomerName;
                                oDoc.Bookmarks["in_accdate"].Range.Text = startDate.Day.ToString();
                                oDoc.Bookmarks["in_price"].Range.Text = tarifPrice.ToString();
                                oDoc.Bookmarks["in_payday"].Range.Text = startDate.Day.ToString();
                                oDoc.Bookmarks["in_stdate"].Range.Text = startDate.Day.ToString();
                                oDoc.Bookmarks["in_stmonth"].Range.Text = months_list[startDate.Month - 1];
                                oDoc.Bookmarks["in_styear"].Range.Text = startDate.Year.ToString();
                                oDoc.Bookmarks["in_endate"].Range.Text = finishDate.Day.ToString();
                                oDoc.Bookmarks["in_enmonth"].Range.Text = months_list[finishDate.Month - 1];
                                oDoc.Bookmarks["in_enyear"].Range.Text = finishDate.Year.ToString();
                                oDoc.Bookmarks["in_tarifop"].Range.Text = tarifDescription;
                                oDoc.Bookmarks["in_orgname"].Range.Text = requestCustomerName;
                                oDoc.Bookmarks["in_INN"].Range.Text = INN.ToString();
                                oDoc.Bookmarks["in_KPP"].Range.Text = KPP.ToString();
                                oDoc.Bookmarks["in_regform"].Range.Text = regform;
                                oDoc.Bookmarks["in_OGRN"].Range.Text = OGRN.ToString();

                                DirectoryInfo folder = new DirectoryInfo(pathSave);
                                string saveFolder = folder.FullName + $"\\{requestCustomerName}\\Договор";
                                if (Directory.Exists(saveFolder) == false)
                                {
                                    Directory.CreateDirectory(saveFolder);
                                }

                                object outputFileName = saveFolder + $"\\Предоставление_услуг_{requestCustomerName}_{requestTarifName}.pdf";
                                object fileFormat = WdSaveFormat.wdFormatPDF;

                                oDoc.SaveAs(ref outputFileName, ref fileFormat);

                                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                                oDoc.Close(ref saveChanges);
                                oWord.Quit();
                                MessageBox.Show("Данные успешно добавлены, а также на рабочем столе создан документ об оказании услуг!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            catch
                            {
                                MessageBox.Show("Не удалось создать документы для клиента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        int workerID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_worker FROM Workers WHERE account = {current_user.id};"));
                        wWD.updateTable(mainTable + $" WHERE worker = {workerID}", accountingTable);
                        wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {workerID};", "name", customerSearchText);

                        if (accountingTable.Rows.Count == 0)
                        {
                            searchOpenButton.Visible = false;
                        }
                        else
                        {
                            searchOpenButton.Visible = true;
                        };

                        addPanel.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Договор с этим клиентом уже заключен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void delete_note_Click(object sender, EventArgs e)
        {
            string customerName, tarifName, totalPrice;
            Int32 selectedRowCount =  accountingTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                foreach (DataGridViewRow row in accountingTable.SelectedRows)
                {
                        DialogResult deleteResult = MessageBox.Show("Вы уверены, что хотите \nразорвать контракт с клиентом?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (deleteResult == DialogResult.Yes)
                        {
                            customerName = row.Cells[0].Value.ToString();
                            tarifName = row.Cells[1].Value.ToString();
                            DateTime startDate = Convert.ToDateTime(row.Cells[2].Value.ToString());
                            DateTime endDate = Convert.ToDateTime(row.Cells[3].Value.ToString());
                            totalPrice = row.Cells[4].Value.ToString();

                            string start = startDate.ToString("O");
                            string end = endDate.ToString("O");

                            try
                            {
                                DateTime currentDate = DateTime.Now.ToLocalTime();

                                decimal inn = Convert.ToDecimal(wWD.executeScalar($"SELECT inn FROM customers WHERE name = '{customerName}'"));
                                decimal kpp = Convert.ToDecimal(wWD.executeScalar($"SELECT kpp FROM customers WHERE name = '{customerName}'"));
                                decimal ogrn = Convert.ToDecimal(wWD.executeScalar($"SELECT ogrn FROM customers WHERE name = '{customerName}'"));
                                string regist = wWD.executeScalar($"SELECT registration_form FROM customers WHERE name = '{customerName}'");

                                int worker = Convert.ToInt32(wWD.executeScalar($"SELECT worker FROM customers WHERE name = '{customerName}'"));
                                string workerName = Convert.ToString(wWD.executeScalar($"SELECT surname FROM workers WHERE ID_worker = {worker}"));

                                int customerID = Convert.ToInt32(wWD.executeScalar($"Select id_customer from customers where name = N'{customerName}'"));
                                int tarifID = Convert.ToInt32(wWD.executeScalar($"Select id_tarif from tarifs where name = N'{tarifName}'"));
                                int noteID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_note from accounting where customer = {customerID} and tarif = {tarifID} and total = {totalPrice}"));

                                DateTime accDateTime = Convert.ToDateTime(wWD.executeScalar($"SELECT start_date FROM accounting where ID_note = {noteID}"));
                                string accDate = accDateTime.ToShortDateString();

                                Word._Application oWord = new Word.Application();
                                oWord.Visible = false;
                                Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\rastorg.dotx");

                                oDoc.Bookmarks["customer_num"].Range.Text = noteID.ToString();
                                oDoc.Bookmarks["curday"].Range.Text = currentDate.Day.ToString();
                                oDoc.Bookmarks["curmonth"].Range.Text = months_list[currentDate.Month - 1];
                                oDoc.Bookmarks["curyear"].Range.Text = currentDate.Year.ToString();
                                oDoc.Bookmarks["customer"].Range.Text = customerName;
                                oDoc.Bookmarks["acc_num"].Range.Text = noteID.ToString();
                                oDoc.Bookmarks["acc_date"].Range.Text = accDate;
                                oDoc.Bookmarks["curdatefull"].Range.Text = currentDate.ToShortDateString();
                                oDoc.Bookmarks["adcustomer"].Range.Text = customerName;
                                oDoc.Bookmarks["inn"].Range.Text = inn.ToString();
                                oDoc.Bookmarks["kpp"].Range.Text = kpp.ToString();
                                oDoc.Bookmarks["regform"].Range.Text = regist;
                                oDoc.Bookmarks["ogrn"].Range.Text = ogrn.ToString();

                                DirectoryInfo folder = new DirectoryInfo(pathSave);
                                string saveFolder = folder.FullName + $"\\{customerName}\\Договор";
                                if (Directory.Exists(saveFolder) == false)
                                {
                                    Directory.CreateDirectory(saveFolder);
                                }

                                object outputFileName = pathSave + $"\\{customerName}\\Договор\\Отказ_от_оказания_услуг_{customerName}_{tarifName}.pdf";
                                object fileFormat = WdSaveFormat.wdFormatPDF;

                                oDoc.SaveAs(ref outputFileName, ref fileFormat);

                                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                                oDoc.Close(ref saveChanges);
                                oWord.Quit();

                                saveFolder = pathSave + $"\\{customerName}";
                                Directory.Move((pathSave + $"\\{customerName}\\Договор"), (pathSave + $"\\{customerName}\\расторжен_Договор_{noteID}"));

                                wWD.operationsBuilder($"INSERT INTO ArchiveAccounting (customer, inn, kpp, ogrn, registration_form, worker, tarif, start_date, end_date, total) VALUES ('{customerName}', {inn}, {kpp}, {ogrn}, '{regist}', '{workerName}', '{tarifName}', '{start}', '{DateTime.Now.ToString("dd.MM.yyyy")}', {totalPrice});");

                                wWD.operationsBuilder($"delete from accounting where ID_note = {noteID}");
                                MessageBox.Show("Создано Согласие на расторжение услуг, данные успешно удалены, копия записи сохранена в архив!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            catch
                            {
                                MessageBox.Show("Невозможно создать Согласие на расторжение Договора!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        int workerID = Convert.ToInt32(wWD.executeScalar($"SELECT ID_worker FROM Workers WHERE account = {current_user.id};"));
                        wWD.updateTable(mainTable + $" WHERE worker = {workerID}", accountingTable);
                        wWD.comboBoxFuller($"SELECT name FROM customers WHERE worker = {workerID};", "name", customerSearchText);
                    }
                }
            }
            else
            {
                MessageBox.Show("Невозможно удалить, выберите одну строку и попробуйте снова!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_open_Click(object sender, EventArgs e)
        {
            if (current_user.level == 1) accountingTable.Size = new Size(accountingTable.Width, accountingTable.Height - 55);
            searchPanel.Visible = true;
            searchOpenButton.Visible = false;
        }

        private void customer_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requesrCustomerName = Convert.ToString(customerSearchText.SelectedItem);
            int selectedCustomerID = Convert.ToInt32(wWD.executeScalar($"Select ID_customer from Customers where name = N'{requesrCustomerName}'"));

            wWD.updateTable("select Customers.name AS [Клиент], Tarifs.name AS [Тариф], " +
                "Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] " +
                $"from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif where ID_customer = {selectedCustomerID};", accountingTable);
        }

        private void close_app_button_Click(object sender, EventArgs e)
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
                accountingTable.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
                accountingTable.DefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                this.BackgroundImage = Properties.Resources.authorization_background;
                accountingTable.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
                accountingTable.DefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
            };
        }
    }
}
