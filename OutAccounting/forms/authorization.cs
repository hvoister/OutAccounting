using dataBaseConnection;
using OutAccounting.forms;
using OutAccounting.other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutAccounting
{
    public partial class authorization : Form
    {
        public current_user user;

        dataBase dataBase = new dataBase();

        public authorization()
        {
            InitializeComponent();

            today_lab.Text = Convert.ToString(DateTime.Now);

            if (current_user.login != "guest" && current_user.login != null)
            {
                menupanel.Visible = true;
                backauth_button.Visible = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            today_lab.Text = Convert.ToString(DateTime.Now);
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            if (login.Text != "")
                log_mask.Visible = false;
            else log_mask.Visible = true;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text != "")
                pas_mask.Visible = false;
            else pas_mask.Visible = true;
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            if ((login.Text == "") || (password.Text == ""))
            {
                MessageBox.Show("Введите данные во все поля для ввода!", "Заполните все данные!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                current_user.login = login.Text.Trim();
                current_user.password = password.Text.Trim();

                try
                {

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    string querystring = $"select ID_account from Auth where login = N'{current_user.login}' and password = N'{current_user.password}'";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        SqlCommand user_ID = new SqlCommand($"Select ID_account from Auth where login = N'{current_user.login}' and password = N'{current_user.password}'", dataBase.getConnection());
                        dataBase.openConnection();
                        int input_ID = Convert.ToInt32(user_ID.ExecuteScalar());
                        current_user.id = input_ID;
                        SqlCommand level = new SqlCommand($"Select pass_level from Auth where login = N'{current_user.login}' and password = N'{current_user.password}'", dataBase.getConnection());
                        current_user.level = Convert.ToInt32(level.ExecuteScalar());
                        dataBase.closeConnection();
                        MessageBox.Show($"Вы успешно вошли в свой аккаунт!", "Успех входа в аккаунт!", MessageBoxButtons.OK);
                        menupanel.Visible = true;
                        backauth_button.Visible = true;
                        login.Clear();
                        password.Clear();
                    }
                    else
                    {

                        MessageBox.Show("Такого аккаунта не существует! \nПроверьте корректность данных или обратитесь к администратору для создания нового аккаунта!", "Ошибка входа в аккаунт!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте корректность данных или обратитесь к администратору для создания нового аккаунта!", "Неизвестная ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tarifs_Click(object sender, EventArgs e)
        {
            current_user.login = "guest";
            current_user.password = "guest";
            current_user.level = 0;

            tarifs tarifs = new tarifs();
            tarifs.Show();
            this.Hide();
        }

        private void backauth_button_Click(object sender, EventArgs e)
        {
            menupanel.Visible = false;
            backauth_button.Visible = false;
            
        }

        private void tarifs_button_Click(object sender, EventArgs e)
        {
            tarifs tarifs = new tarifs();
            tarifs.Show();
            this.Hide();
        }

        private void customers_button_Click(object sender, EventArgs e)
        {
            customers customers = new customers();
            customers.Show();
            this.Hide();
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            hide_button.Visible = false;
            show_button.Visible = true;
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            hide_button.Visible = true;
            show_button.Visible = false;
            
        }

        private void authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void accounting_button_Click(object sender, EventArgs e)
        {
            accounting accounting = new accounting();
            accounting.Show();
            this.Hide();
        }
    }
}
