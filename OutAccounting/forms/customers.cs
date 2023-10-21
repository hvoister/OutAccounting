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

            this.customersDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (current_user.level == 2)
            {
                workerpic.Visible = true;
                deletebutton.Visible = true;
                createbitton.Visible = true;
                deletbutton.Visible = false;
            }
            else
            {
                gueststarif.Visible = true;
                workerpic.Visible = false;
                deletebutton.Visible = false;
                createbitton.Visible = false;
                deletbutton.Visible = true;

                fullcustomers.Visible = true;
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (infopanel.Visible == true)
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                infopanel.Visible = true;
                delete_note.Enabled = false;
            }
        }

            private void deletebutton_Click(object sender, EventArgs e)
        {
            infopanel.Visible = false;
            deletbutton.Visible = false;
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

                innTextBox.Visible = false;
                kppTextBox.Visible = false;
                registration_formTextBox.Visible = false;
                ogrnTextBox.Visible = false;
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
                if (nameTextBox.Text == "" || innMaskedBox.Text == "" || kppMaskedBox.Text == "" || registration_formMaskedBox.Text == "")
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cusname = nameTextBox.Text;
                    decimal inn = Convert.ToDecimal(innMaskedBox.Text);
                    decimal kpp = Convert.ToDecimal(kppMaskedBox.Text);
                    string registr = Convert.ToString(registration_formMaskedBox.SelectedItem);
                    decimal ogrn = Convert.ToDecimal(ogrnMaskedBox.Text);
                    


                    dataBase.openConnection();

                    SqlCommand worker = new SqlCommand($"select id_worker from workers where account = {current_user.id}", dataBase.getConnection());
                    int seller = Convert.ToInt32(worker.ExecuteScalar());


                    string querystring = $"insert into Customers (name, inn, kpp, ogrn, registration_form, worker) values (N'{cusname}', {inn} , {kpp}, {ogrn}, N'{registr}', {seller})";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                    command.ExecuteNonQuery();

                    dataBase.closeConnection();
                    MessageBox.Show("Данные успешно добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.customersTableAdapter.Fill(this.accountingDataSet.Customers);
                    agreecreatebutton.Visible = false;

                    moveleft.Visible = true;
                    moveright.Visible = true;
                    deletebutton.Visible = true;
                    agreecreatebutton.Visible = false;
                    customersBindingSource.MoveFirst();

                    innTextBox.Visible = true;
                    kppTextBox.Visible = true;
                    registration_formTextBox.Visible = true;
                    ogrnTextBox.Visible = true;
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

        private void delete_note_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите \nразорвать контракт с клиентом?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    customersBindingSource.RemoveCurrent();
                    customersTableAdapter.Update(accountingDataSet);
                    MessageBox.Show("Данные успешно удалены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Операция не была проведена! Нечего удалять.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void fullcustomers_Click(object sender, EventArgs e)
        {
            infopanel.Visible = false;
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
    }
}
