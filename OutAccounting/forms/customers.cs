using dataBaseConnection;
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

namespace OutAccounting.forms
{
    public partial class customers : Form
    {
        dataBase dataBase = new dataBase();
        public customers()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            authorization authorization = new authorization();
            authorization.Show();
            this.Hide();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            infopanel.Visible = false;
            delete_note.Enabled = true;
        }

        private void moveleft_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void moveright_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }

        private void createbitton_Click(object sender, EventArgs e)
        {
            try
            {
                customersBindingSource.AddNew();
                agreecreatebutton.Visible = true;
                deletebutton.Visible = false;
                moveleft.Visible = false;
                moveright.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка введения данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agreecreatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "" || innTextBox.Text == "" || kppTextBox.Text == "" || registration_formTextBox.Text == "")
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cusname = nameTextBox.Text;
                    string inn = innTextBox.Text;
                    string kpp = kppTextBox.Text;
                    string registr = registration_formTextBox.Text;


                    //dataBase.openConnection();

                    //string querystring = $"insert into customers (name, price_per_month, services) values (N'{tarname}', {price} , N'{description}')";
                    //SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                    //command.ExecuteNonQuery();

                    //dataBase.closeConnection();
                    //MessageBox.Show("Данные успешно добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //this.tarifsTableAdapter.Fill(this.accountingDataSet.Tarifs);
                    //agreecreatebutton.Visible = false;

                    //moveleft.Visible = true;
                    //moveright.Visible = true;
                    //deletebutton.Visible = true;
                    //agreecreatebutton.Visible = false;
                    //tarifsBindingSource.MoveFirst();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.accountingDataSet.Customers);

        }
    }
}
