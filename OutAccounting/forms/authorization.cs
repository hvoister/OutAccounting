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
        workingWithData wWD = new workingWithData();

        public authorization()
        {
            InitializeComponent();

            todayLabel.Text = Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")) + " " + Convert.ToString(DateTime.Now.ToString("HH:mm:ss")) + "     ";

            if (current_user.login != "guest" && current_user.login != null)
            {
                menuPanel.Visible = true;
                backauthButton.Visible = true;
                if (current_user.level == 1)
                {
                    archiveButton.Visible = true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            todayLabel.Text = Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")) + " " + Convert.ToString(DateTime.Now.ToString("HH:mm:ss")) + "     ";
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "")
                logMask.Visible = false;
            else logMask.Visible = true;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "")
                pasMask.Visible = false;
            else pasMask.Visible = true;
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.Text == "") || (passwordTextBox.Text == ""))
            {
                MessageBox.Show("Введите данные во все поля для ввода!", "Заполните все данные!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (loginTextBox.Text != "guest")
                {
                    current_user.login = loginTextBox.Text.Trim();
                    current_user.password = passwordTextBox.Text.Trim();

                    try
                    {
                        int userExists = wWD.noteExistsCheck($"select ID_account from Auth where login = N'{current_user.login}' and password = N'{current_user.password}'");
                        if (userExists == 1)
                        {
                            current_user.id = Convert.ToInt32(wWD.executeScalar($"select ID_account from Auth where login = N'{current_user.login}' and password = N'{current_user.password}'"));
                            current_user.level = Convert.ToInt32(wWD.executeScalar($"Select pass_level from Auth where login = N'{current_user.login}' and password = N'{current_user.password}'"));

                            MessageBox.Show($"Вы успешно вошли в свой аккаунт!", "Успех входа в аккаунт!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            if (current_user.level == 1)
                            {
                                archiveButton.Visible = true;
                            }
                            menuPanel.Visible = true;
                            backauthButton.Visible = true;
                            loginTextBox.Clear();
                            passwordTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Такого аккаунта не существует! \nПроверьте корректность данных или обратитесь к администратору для создания нового аккаунта!", "Ошибка входа в аккаунт!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Проверьте корректность данных или обратитесь к администратору для создания нового аккаунта!", "Неизвестная ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не можете получить доступ к остальным частям приложения с текущим уровнем аккаунта!", "Гостевой аккаунт!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            menuPanel.Visible = false;
            backauthButton.Visible = false;
            
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
            passwordTextBox.UseSystemPasswordChar = false;
            hide_button.Visible = false;
            showButton.Visible = true;
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            hide_button.Visible = true;
            showButton.Visible = false;
            
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

        private void close_app_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение? \nВсе несохранённые данные будут потеряны.", "Подтверждение закрытия приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            archive archive = new archive();
            archive.Show();
            this.Hide();
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            statistic statistic = new statistic();
            statistic.Show();
            this.Hide();
        }
    }
}
