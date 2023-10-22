using dataBaseConnection;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OutAccounting.forms
{
    public partial class accounting : Form
    {
        dataBase dataBase = new dataBase();
        public accounting()
        {
            InitializeComponent();

            dataBase.openConnection();

            SqlDataAdapter da = new SqlDataAdapter("select Customers.name AS [Клиент], Tarifs.name AS [Тариф], Accounting.start_date as [Дата начала], Accounting.end_date as [Дата окончания], total as [Итого] from Accounting join customers on customer = customers.id_customer join Tarifs on tarif = tarifs.ID_tarif;", dataBase.getConnection());
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
            if (add_panel.Visible == false)
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                add_panel.Visible = false;
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
            //try
            //{
                string reqcusname = Convert.ToString(customer_name.SelectedValue);
                string reqtarifname = Convert.ToString(tarif_name.SelectedValue);
                DateTime start_date = DateTime.Now.ToLocalTime();
                DateTime finish_date = Convert.ToDateTime(end_date.Text);

                if (finish_date > start_date)
                {
                    string start = start_date.ToString("O");
                    string end = finish_date.ToString("O");

                    SqlCommand cmd_cusID = new SqlCommand($"Select id_customer from customers where name = N'{reqcusname}'", dataBase.getConnection());
                    SqlCommand cmd_tarifID = new SqlCommand($"Select id_tarif from tarifs where name = N'{reqtarifname}'", dataBase.getConnection());
                    dataBase.openConnection();
                    int cusid = Convert.ToInt32(cmd_cusID.ExecuteScalar());
                    int tarifid = Convert.ToInt32(cmd_tarifID.ExecuteScalar());
                    dataBase.closeConnection();

                    int months = 0;
                    if ((finish_date.Year - start_date.Year) == 0)
                    {
                        months = finish_date.Month - start_date.Month;
                    }
                    else
                    {
                        if (finish_date.Month != start_date.Month)
                        {
                            months = ((12 - start_date.Month) + finish_date.Month) * (finish_date.Year - start_date.Year);
                        }
                        else
                        { months = 12 * (finish_date.Year - start_date.Year); }
                    }

                    SqlCommand cmd_tarifprice = new SqlCommand($"Select price_per_month from tarifs where ID_tarif = N'{tarifid}'", dataBase.getConnection());
                    dataBase.openConnection();
                    int tarifprice = Convert.ToInt32(cmd_tarifprice.ExecuteScalar());
                    dataBase.closeConnection();

                    int total = tarifprice * months;

                    dataBase.openConnection();

                    string querystring = $"insert into accounting (customer, tarif, start_date, end_date, total) values ({cusid}, {tarifid}, '{start}', '{end}', {total})";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                    command.ExecuteNonQuery();

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
            //}
            //catch
            //{
            //    MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
