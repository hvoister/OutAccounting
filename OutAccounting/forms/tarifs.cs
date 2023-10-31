using dataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutAccounting
{
    public partial class tarifs : Form
    {
        dataBase dataBase = new dataBase();
        public tarifs()
        {
            InitializeComponent();
            this.tarifsdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (current_user.level == 2)
            {
                workerpic.Visible = true;
                deletebutton.Visible = true;
                createbitton.Visible = true;
                deletbutton.Visible = false;

                gueststarif.Visible = false;
            }
            else
            {
                gueststarif.Visible = true;
                workerpic.Visible = false;
                deletebutton.Visible = false;
                createbitton.Visible = false;
                deletbutton.Visible = true;

                fulltarifs.Visible = true;
            }
        }

        private void tarifs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tarifs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Tarifs". При необходимости она может быть перемещена или удалена.
            this.tarifsTableAdapter.Fill(this.accountingDataSet.Tarifs);

        }

        private void delete_note_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите \nудалить данный тариф?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    tarifsBindingSource.RemoveCurrent();
                    tarifsTableAdapter.Update(accountingDataSet);
                    MessageBox.Show("Данные успешно удалены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Операция не была проведена! Нечего удалять.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                search_panel.Visible = false;
            }
        }

        private void moveleft_Click(object sender, EventArgs e)
        {
            tarifsBindingSource.MovePrevious();
        }

        private void moveright_Click(object sender, EventArgs e)
        {
            tarifsBindingSource.MoveNext();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            infopanel.Visible = false;
            delete_note.Enabled = true;
        }

        private void fulltarifs_Click(object sender, EventArgs e)
        {
            infopanel.Visible = false;
        }

        private void createbitton_Click(object sender, EventArgs e)
        {
            try
            {
                tarifsBindingSource.AddNew();
                agreecreatebutton.Visible = true;
                deletebutton.Visible = false;
                moveleft.Visible = false;
                moveright.Visible = false;

                nameTextBox.ReadOnly = false;
                price_per_monthTextBox.ReadOnly = false;
                servicesTextBox.ReadOnly = false;
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
                if (nameTextBox.Text == "" || Convert.ToDouble(price_per_monthTextBox.Text) == 0 || servicesTextBox.Text == "")
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tarname = nameTextBox.Text;
                    double price = Convert.ToDouble(price_per_monthTextBox.Text);
                    string description = servicesTextBox.Text;

                    dataBase.openConnection();

                    string querystring = $"insert into tarifs (name, price_per_month, services) values (N'{tarname}', {price} , N'{description}')";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                    command.ExecuteNonQuery();

                    dataBase.closeConnection();
                    MessageBox.Show("Данные успешно добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.tarifsTableAdapter.Fill(this.accountingDataSet.Tarifs);
                    agreecreatebutton.Visible = false;

                    moveleft.Visible = true;
                    moveright.Visible = true;
                    deletebutton.Visible = true;
                    agreecreatebutton.Visible = false;
                    tarifsBindingSource.MoveFirst();

                    nameTextBox.ReadOnly = true;
                    price_per_monthTextBox.ReadOnly = true;
                    servicesTextBox.ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tarifs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void search_open_Click(object sender, EventArgs e)
        {
            deletbutton.Visible = true;
            infopanel.Visible = false;
            search_panel.Visible = true;
        }

        private void search_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = "name";
            int index = tarifsBindingSource.Find(name, search_text.SelectedValue);
            tarifsBindingSource.Position = index;
        }
    }
}
