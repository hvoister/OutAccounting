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
        workingWithData wWD = new workingWithData();
        public tarifs()
        {
            InitializeComponent();

            for ( int i = 0; i < tarifsDataGridView.Columns.Count; i++ )
            {
                tarifsDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            tarifsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (current_user.level != 2)
            { 
                tarifsDataGridView.Size = new Size(712, 348);
                addTarifButton.Visible = false;
                deleteNote.Visible = false;
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
                DialogResult exitResult = MessageBox.Show("Вы уверены, что хотите \nудалить данный тариф?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exitResult == DialogResult.Yes)
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
            if (infoPanel.Visible == false && searchPanel.Visible == false) 
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else 
            {
                if ((current_user.level == 1 || current_user.level == 0) && searchPanel.Visible == true)
                {
                    tarifsDataGridView.Size = new Size(tarifsDataGridView.Width, tarifsDataGridView.Height + 50);
                }
                infoPanel.Visible = false;
                searchOpenButton.Visible = true;
                searchPanel.Visible = false;
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
                    string tarName = nameTextBox.Text;
                    double price = Convert.ToDouble(price_per_monthTextBox.Text);
                    string description = servicesTextBox.Text;

                    wWD.operationsBuilder($"insert into tarifs (name, price_per_month, services) values (N'{tarName}', {price} , N'{description}');");
                    MessageBox.Show("Данные успешно добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    tarifsTableAdapter.Fill(accountingDataSet.Tarifs);
                    infoPanel.Visible=false;
                    searchOpenButton.Visible = true;
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
        

        private void search_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = "name";
            int index = tarifsBindingSource.Find(name, searchText.SelectedValue);
            tarifsBindingSource.Position = index;
        }

        private void close_app_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение? \nВсе несохранённые данные будут потеряны.", "Подтверждение закрытия приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addTarifButton_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = true;
            searchOpenButton.Visible = false;
        }

        private void search_open_Click(object sender, EventArgs e)
        {
            if ((current_user.level == 1 || current_user.level == 0))
            {
                tarifsDataGridView.Size = new Size(tarifsDataGridView.Width, tarifsDataGridView.Height - 50);
            }

            searchPanel.Visible = true;
            searchOpenButton.Visible = false;
        }

        private void bigWindowModeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                this.BackgroundImage = Properties.Resources.background_table_big;
                tarifsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
                tarifsDataGridView.DefaultCellStyle.Font = new Font("Linux Biolinum G", 12);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                this.BackgroundImage = Properties.Resources.authorization_background;
                tarifsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
                tarifsDataGridView.DefaultCellStyle.Font = new Font("Linux Biolinum G", 18);
            };
        }
    }
}
