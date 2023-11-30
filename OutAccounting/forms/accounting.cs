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
using Word = Microsoft.Office.Interop.Word;

namespace OutAccounting.forms
{
    public partial class accounting : Form
    {
        dataBase dataBase = new dataBase();
        string pathSave = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\Customers_docs";
        string[] months_list = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        public accounting()
        {
            InitializeComponent();

            dataBase.openConnection();

            SqlDataAdapter da = new SqlDataAdapter("select Customers.name AS [Клиент], Tarifs.name AS [Тариф], " +
                "Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] " +
                "from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif;", dataBase.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Result");

            accountingtable.DataSource = ds.Tables["Result"];
            dataBase.closeConnection();

            accountingtable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingtable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingtable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingtable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountingtable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (current_user.level == 1)
            {
                delete_note.Visible = false;
                add_button.Visible = false;
                accountingtable.Size = new Size(763, 349);
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
            if (add_panel.Visible == false && search_panel.Visible == false)
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select Customers.name AS [Клиент], Tarifs.name AS [Тариф], Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif;", dataBase.getConnection());
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds, "Result");

                accountingtable.DataSource = ds.Tables["Result"];
                dataBase.closeConnection();

                if (current_user.level == 1)
                {
                    delete_note.Visible = false;
                    add_button.Visible = false;
                    accountingtable.Size = new Size(763, 349);
                }

                add_panel.Visible = false;
                search_panel.Visible = false;
                search_open.Visible = true;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_panel.Visible = true;
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
                string reqcusname = Convert.ToString(customer_name.SelectedValue);
                string reqtarifname = Convert.ToString(tarif_name.SelectedValue);
                DateTime start_date = DateTime.Now.ToLocalTime();

                int months = ((int)months_count.Value);
                string finish_date_str = Convert.ToString(start_date.AddMonths(months));

                DateTime finish_date = Convert.ToDateTime(finish_date_str);

                if (finish_date > start_date)
                {
                    string start = start_date.ToString("O");
                    string end = finish_date.ToString("O");

                    SqlCommand cmd_cusID = new SqlCommand($"Select id_customer from customers where name = N'{reqcusname}'", dataBase.getConnection());
                    SqlCommand cmd_tarifID = new SqlCommand($"Select id_tarif from tarifs where name = N'{reqtarifname}'", dataBase.getConnection());
                    dataBase.openConnection();
                    int cusid = Convert.ToInt32(cmd_cusID.ExecuteScalar());
                    int tarifid = Convert.ToInt32(cmd_tarifID.ExecuteScalar());
                    SqlCommand cmd_tarifprice = new SqlCommand($"Select price_per_month from tarifs where ID_tarif = N'{tarifid}'", dataBase.getConnection());
                    int tarifprice = Convert.ToInt32(cmd_tarifprice.ExecuteScalar());
                    dataBase.closeConnection();

                    int total = tarifprice * Convert.ToInt32(months_count.Value);

                    dataBase.openConnection();
                    string querystring = $"insert into accounting (customer, tarif, start_date, end_date, total) values ({cusid}, {tarifid}, '{start}', '{end}', {total})";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();

                    try
                    {
                        SqlCommand cmd_noteID = new SqlCommand($"Select ID_note from Accounting where customer = {cusid} AND tarif = {tarifid} and start_date = '{start}'", dataBase.getConnection());
                        SqlCommand cmd_tarif = new SqlCommand($"Select services from tarifs where id_tarif = {tarifid}", dataBase.getConnection());
                        SqlCommand cmd_INN = new SqlCommand($"Select inn from customers where id_customer = {cusid}", dataBase.getConnection());
                        SqlCommand cmd_KPP = new SqlCommand($"Select kpp from customers where id_customer = {cusid}", dataBase.getConnection());
                        SqlCommand cmd_regform = new SqlCommand($"Select registration_form from customers where id_customer = {cusid}", dataBase.getConnection());
                        SqlCommand cmd_OGRN = new SqlCommand($"Select ogrn from customers where id_customer = {cusid}", dataBase.getConnection());

                        dataBase.openConnection();
                        int number = Convert.ToInt32(cmd_noteID.ExecuteScalar());
                        string tarifop = Convert.ToString(cmd_tarif.ExecuteScalar());
                        decimal INN = Convert.ToDecimal(cmd_INN.ExecuteScalar());
                        decimal KPP = Convert.ToDecimal(cmd_KPP.ExecuteScalar());
                        string regform = Convert.ToString(cmd_regform.ExecuteScalar());
                        decimal OGRN = Convert.ToDecimal(cmd_OGRN.ExecuteScalar());
                        dataBase.closeConnection();

                        Word._Application oWord = new Word.Application();
                        oWord.Visible = false;
                        Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\customer_add2.dotx");
                        oDoc.Bookmarks["in_number"].Range.Text = number.ToString();
                        oDoc.Bookmarks["in_date"].Range.Text = start_date.Day.ToString();
                        oDoc.Bookmarks["in_month"].Range.Text = months_list[start_date.Month - 1];
                        oDoc.Bookmarks["in_year"].Range.Text = start_date.Year.ToString();
                        oDoc.Bookmarks["in_customer"].Range.Text = reqcusname;
                        oDoc.Bookmarks["in_accdate"].Range.Text = start_date.Day.ToString();
                        oDoc.Bookmarks["in_price"].Range.Text = tarifprice.ToString();
                        oDoc.Bookmarks["in_payday"].Range.Text = start_date.Day.ToString();
                        oDoc.Bookmarks["in_stdate"].Range.Text = start_date.Day.ToString();
                        oDoc.Bookmarks["in_stmonth"].Range.Text = months_list[start_date.Month - 1];
                        oDoc.Bookmarks["in_styear"].Range.Text = start_date.Year.ToString();
                        oDoc.Bookmarks["in_endate"].Range.Text = finish_date.Day.ToString();
                        oDoc.Bookmarks["in_enmonth"].Range.Text = months_list[finish_date.Month - 1];
                        oDoc.Bookmarks["in_enyear"].Range.Text = finish_date.Year.ToString();
                        oDoc.Bookmarks["in_tarifop"].Range.Text = tarifop;
                        oDoc.Bookmarks["in_orgname"].Range.Text = reqcusname;
                        oDoc.Bookmarks["in_INN"].Range.Text = INN.ToString();
                        oDoc.Bookmarks["in_KPP"].Range.Text = KPP.ToString();
                        oDoc.Bookmarks["in_regform"].Range.Text = regform;
                        oDoc.Bookmarks["in_OGRN"].Range.Text = OGRN.ToString();

                        pathSave += $"\\{reqcusname}";
                        oDoc.SaveAs(FileName: pathSave + $"\\Предоставление_услуг_{reqcusname}.doc");
                        oDoc.Close();
                        oWord.Quit();
                        MessageBox.Show("Данные успешно добавлены, а также на рабочем столе создан документ об оказании услуг!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось создать документы для клиента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    SqlDataAdapter da = new SqlDataAdapter("select Customers.name AS [Клиент], Tarifs.name AS [Тариф], Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif;", dataBase.getConnection());
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Result");
                    accountingtable.DataSource = ds.Tables["Result"];
                    dataBase.closeConnection();
                    add_panel.Visible = false;
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
            string customer_name, tarif_name, totalprice;
            Int32 selectedRowCount =  accountingtable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                foreach (DataGridViewRow row in accountingtable.SelectedRows)
                {
                    customer_name = row.Cells[0].Value.ToString();
                    tarif_name = row.Cells[1].Value.ToString();
                    totalprice = row.Cells[4].Value.ToString();
                    try
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите \nразорвать контракт с клиентом?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            SqlCommand cmd_cusID = new SqlCommand($"Select id_customer from customers where name = N'{customer_name}'", dataBase.getConnection());
                            SqlCommand cmd_tarifID = new SqlCommand($"Select id_tarif from tarifs where name = N'{tarif_name}'", dataBase.getConnection());
                            dataBase.openConnection();
                            int cusid = Convert.ToInt32(cmd_cusID.ExecuteScalar());
                            int tarifid = Convert.ToInt32(cmd_tarifID.ExecuteScalar());

                            string querystring = $"delete from accounting where customer = {cusid} and tarif = {tarifid} and total = {totalprice}";
                            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                            command.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter("select Customers.name AS [Клиент], Tarifs.name AS [Тариф], Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif;", dataBase.getConnection());
                            SqlCommandBuilder cb = new SqlCommandBuilder(da);

                            DataSet ds = new DataSet();
                            da.Fill(ds, "Result");

                            accountingtable.DataSource = ds.Tables["Result"];
                            dataBase.closeConnection();
                            MessageBox.Show("Данные успешно удалены!");
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
            accountingtable.Size = new Size(763, 294);
            search_panel.Visible = true;
            search_open.Visible = false;
        }

        private void customer_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reqcusname = Convert.ToString(customer_search.SelectedValue);
            SqlCommand cmd_cusID = new SqlCommand($"Select id_customer from customers where name = N'{reqcusname}'", dataBase.getConnection());
            dataBase.openConnection();
            int selectedCustomer_id = Convert.ToInt32(cmd_cusID.ExecuteScalar());

            SqlDataAdapter da = new SqlDataAdapter($"select Customers.name AS [Клиент], Tarifs.name AS [Тариф], Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif where Customers.ID_customer = {selectedCustomer_id};", dataBase.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Result");

            accountingtable.DataSource = ds.Tables["Result"];
            dataBase.closeConnection();
        }

        private void close_app_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение? \nВсе несохранённые данные будут потеряны.", "Подтверждение закрытия приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
