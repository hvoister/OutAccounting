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
        string pathSave = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\Документы_клиентов";
        string[] months_list = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        public void updateAccountingTable()
        {
            dataBase.openConnection();
            SqlDataAdapter tableViewDataAdapter = new SqlDataAdapter("select Customers.name AS [Клиент], Tarifs.name AS [Тариф], " +
                "Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] " +
                "from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif;", dataBase.getConnection());
            SqlCommandBuilder tableViewCommandBuilder = new SqlCommandBuilder(tableViewDataAdapter);
            DataSet tableView = new DataSet();
            tableViewDataAdapter.Fill(tableView, "Result");
            accountingTable.DataSource = tableView.Tables["Result"];
            dataBase.closeConnection();
        }
            public accounting()
        {
            InitializeComponent();
            updateAccountingTable();

            accountingTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (current_user.level == 1)
            {
                deleteNote.Visible = false;
                addButton.Visible = false;
                accountingTable.Size = new Size(763, 349);
            }
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
                updateAccountingTable();

                if (current_user.level == 1)
                {
                    deleteNote.Visible = false;
                    addButton.Visible = false;
                    if (WindowState != FormWindowState.Maximized) accountingTable.Size = new Size(763, 349);
                }

                addPanel.Visible = false;
                searchPanel.Visible = false;
                searchOpenButton.Visible = true;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
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
                string requestCustomerName = Convert.ToString(customerNameText.SelectedValue);
                string requestTarifName = Convert.ToString(tarifNameText.SelectedValue);
                DateTime startDate = DateTime.Now.ToLocalTime();

                int months = ((int)monthsCountText.Value);
                string finishDateString = Convert.ToString(startDate.AddMonths(months));

                DateTime finishDate = Convert.ToDateTime(finishDateString);

                if (finishDate > startDate)
                {
                    string start = startDate.ToString("O");
                    string end = finishDate.ToString("O");

                    SqlCommand customerIDCommand = new SqlCommand($"Select id_customer from customers where name = N'{requestCustomerName}'", dataBase.getConnection());
                    SqlCommand tarifIDCommand = new SqlCommand($"Select id_tarif from tarifs where name = N'{requestTarifName}'", dataBase.getConnection());
                    dataBase.openConnection();
                    int customerID = Convert.ToInt32(customerIDCommand.ExecuteScalar());
                    int tarifId = Convert.ToInt32(tarifIDCommand.ExecuteScalar());

                    SqlCommand tarifPriceCommand = new SqlCommand($"Select price_per_month from tarifs where ID_tarif = N'{tarifId}'", dataBase.getConnection());
                    int tarifPrice = Convert.ToInt32(tarifPriceCommand.ExecuteScalar());
                    int total = tarifPrice * Convert.ToInt32(monthsCountText.Value);

                    SqlCommand accountingInsertCommand = new SqlCommand($"insert into accounting (customer, tarif, start_date, end_date, total) values ({customerID}, {tarifId}, '{start}', '{end}', {total})", dataBase.getConnection());
                    accountingInsertCommand.ExecuteNonQuery();
                    dataBase.closeConnection();

                    try
                    {
                        SqlCommand noteIDCommand = new SqlCommand($"Select ID_note from Accounting where customer = {customerID} AND tarif = {tarifId} and start_date = '{start}'", dataBase.getConnection());
                        SqlCommand servicesCommand = new SqlCommand($"Select services from tarifs where id_tarif = {tarifId}", dataBase.getConnection());
                        SqlCommand INNCommand = new SqlCommand($"Select inn from customers where id_customer = {customerID}", dataBase.getConnection());
                        SqlCommand KPPCommand = new SqlCommand($"Select kpp from customers where id_customer = {customerID}", dataBase.getConnection());
                        SqlCommand regFormCommand = new SqlCommand($"Select registration_form from customers where id_customer = {customerID}", dataBase.getConnection());
                        SqlCommand OGRNCommand = new SqlCommand($"Select ogrn from customers where id_customer = {customerID}", dataBase.getConnection());

                        dataBase.openConnection();
                        int number = Convert.ToInt32(noteIDCommand.ExecuteScalar());
                        string tarifDescription = Convert.ToString(servicesCommand.ExecuteScalar());
                        decimal INN = Convert.ToDecimal(INNCommand.ExecuteScalar());
                        decimal KPP = Convert.ToDecimal(KPPCommand.ExecuteScalar());
                        string regform = Convert.ToString(regFormCommand.ExecuteScalar());
                        decimal OGRN = Convert.ToDecimal(OGRNCommand.ExecuteScalar());
                        dataBase.closeConnection();

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

                        pathSave += $"\\{requestCustomerName}";
                        oDoc.SaveAs(FileName: pathSave + $"\\Предоставление_услуг_{requestCustomerName}.doc");
                        oDoc.Close();
                        oWord.Quit();
                        MessageBox.Show("Данные успешно добавлены, а также на рабочем столе создан документ об оказании услуг!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось создать документы для клиента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    updateAccountingTable();

                    addPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    customerName = row.Cells[0].Value.ToString();
                    tarifName = row.Cells[1].Value.ToString();
                    totalPrice = row.Cells[4].Value.ToString();
                    try
                    {
                        DialogResult deleteResult = MessageBox.Show("Вы уверены, что хотите \nразорвать контракт с клиентом?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (deleteResult == DialogResult.Yes)
                        {
                            SqlCommand customerIDCommand = new SqlCommand($"Select id_customer from customers where name = N'{customerName}'", dataBase.getConnection());
                            SqlCommand tarifIDCommand = new SqlCommand($"Select id_tarif from tarifs where name = N'{tarifName}'", dataBase.getConnection());
                            dataBase.openConnection();
                            int customerID = Convert.ToInt32(customerIDCommand.ExecuteScalar());
                            int tarifID = Convert.ToInt32(tarifIDCommand.ExecuteScalar());

                            SqlCommand command = new SqlCommand($"delete from accounting where customer = {customerID} and tarif = {tarifID} and total = {totalPrice}", dataBase.getConnection());
                            command.ExecuteNonQuery();
                            dataBase.closeConnection();

                            updateAccountingTable();
                            MessageBox.Show("Данные успешно удалены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно удалить, выберите одну строку и попробуйте снова!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (current_user.level == 1 && (WindowState != FormWindowState.Maximized)) accountingTable.Size = new Size(763, 294);
            searchPanel.Visible = true;
            searchOpenButton.Visible = false;
        }

        private void customer_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requesrCustomerName = Convert.ToString(customerSearchText.SelectedValue);
            SqlCommand customerIdCommand = new SqlCommand($"Select id_customer from customers where name = N'{requesrCustomerName}'", dataBase.getConnection());
            dataBase.openConnection();
            int selectedCustomerID = Convert.ToInt32(customerIdCommand.ExecuteScalar());
            dataBase.closeConnection();
            updateAccountingTable();
        }

        private void close_app_button_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Вы уверены, что хотите закрыть приложение? \nВсе несохранённые данные будут потеряны.", "Подтверждение закрытия приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
