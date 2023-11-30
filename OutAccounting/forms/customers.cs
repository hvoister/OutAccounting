using dataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace OutAccounting.forms
{
    public partial class customers : Form
    {
        dataBase dataBase = new dataBase();
        string pathSave = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\Customers_docs";
        string[] months_list = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        public customers()
        {
            InitializeComponent();

            dataBase.openConnection();

            SqlDataAdapter da = new SqlDataAdapter("select Customers.name as [Организация], inn as [ИНН], kpp as [КПП], registration_form as [Форма регистрации], ogrn as [ОГРН], Workers.surname as [Сотрудник] from customers join Workers on worker = Workers.ID_worker;", dataBase.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Result");
            customersDataGridView.DataSource = ds.Tables["Result"];
            dataBase.closeConnection();

            customersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customersDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customersDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customersDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customersDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customersDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.customersDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (current_user.level == 1)
            {
                delete_note.Visible = false;
                add_button.Visible = false;
                customersDataGridView.Size = new Size(817, 363);
            };
        }

        private void customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.accountingDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.accountingDataSet.Customers);

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (infopanel.Visible == false && search_panel.Visible == false)
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                dataBase.openConnection();
                SqlDataAdapter da = new SqlDataAdapter("select Customers.name as [Организация], inn as [ИНН], kpp as [КПП], registration_form as [Форма регистрации], ogrn as [ОГРН], Workers.surname as [Сотрудник] from customers join Workers on worker = Workers.ID_worker;", dataBase.getConnection());
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "Result");
                customersDataGridView.DataSource = ds.Tables["Result"];
                dataBase.closeConnection();

                if (current_user.level == 1)
                {
                    delete_note.Visible = false;
                    add_button.Visible = false;
                    customersDataGridView.Size = new Size(817, 363);
                };

                infopanel.Visible = false;
                search_panel.Visible = false;
                search_open.Visible = true;

                orgname.Clear();
                innMaskedBox.Clear();
                kppMaskedBox.Clear();
                ogrnMaskedBox.Clear();
            }
        }

        private void customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void search_open_Click(object sender, EventArgs e)
        {
            customersDataGridView.Size = new Size(817, 311);

            infopanel.Visible = false;
            search_panel.Visible = true;
            search_open.Visible = false;
        }

        private void search_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reqcusname = Convert.ToString(search_text.SelectedValue);
            SqlCommand cmd_cusID = new SqlCommand($"Select id_customer from customers where name = N'{reqcusname}'", dataBase.getConnection());
            dataBase.openConnection();
            int selectedCustomer_id = Convert.ToInt32(cmd_cusID.ExecuteScalar());

            SqlDataAdapter da = new SqlDataAdapter($"select Customers.name as [Организация], inn as [ИНН], kpp as [КПП], registration_form as [Форма регистрации], ogrn as [ОГРН], Workers.surname as [Сотрудник] from customers join Workers on worker = Workers.ID_worker where Customers.ID_customer = {selectedCustomer_id};", dataBase.getConnection());
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Result");
            customersDataGridView.DataSource = ds.Tables["Result"];
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

        private void agreecreatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (orgname.Text == "" || innMaskedBox.Text == "" || kppMaskedBox.Text == "" || registration_formMaskedBox.Text == "" || ogrnMaskedBox.Text == "")
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cusname = orgname.Text;
                    decimal inn = Convert.ToDecimal(innMaskedBox.Text);
                    decimal kpp = Convert.ToDecimal(kppMaskedBox.Text);
                    string registr = Convert.ToString(registration_formMaskedBox.SelectedItem);
                    decimal ogrn = Convert.ToDecimal(ogrnMaskedBox.Text);
                    string worker_sur = Convert.ToString(worker_surname.SelectedValue);


                    dataBase.openConnection();
                    SqlCommand worker = new SqlCommand($"select id_worker from workers where surname = '{worker_sur}'", dataBase.getConnection());
                    int seller = Convert.ToInt32(worker.ExecuteScalar());

                    string querystring = $"insert into Customers (name, inn, kpp, ogrn, registration_form, worker) values (N'{cusname}', {inn} , {kpp}, {ogrn}, N'{registr}', {seller})";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    try
                    {
                        Word._Application oWord = new Word.Application();
                        oWord.Visible = false;
                        Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\soglas1.dotx");
                        oDoc.Bookmarks["int_orgname"].Range.Text = cusname;
                        oDoc.Bookmarks["int_curdate"].Range.Text = DateTime.Now.Day.ToString();
                        oDoc.Bookmarks["int_curmonth"].Range.Text = months_list [DateTime.Now.Month-1];
                        oDoc.Bookmarks["int_curyear"].Range.Text = DateTime.Today.Year.ToString();

                        DirectoryInfo folder = new DirectoryInfo(pathSave);
                        if (folder.Exists == false)
                        {
                            Directory.CreateDirectory(pathSave);
                        }
                        string saveFolder = folder.FullName + $"\\{cusname}";
                        if (Directory.Exists(saveFolder) == false)
                        {
                            Directory.CreateDirectory(saveFolder);
                            pathSave = saveFolder;
                        }

                        oDoc.SaveAs(FileName: pathSave + $"\\Обработка_данных_{cusname}.doc");
                        oDoc.Close();
                        oWord.Quit();
                        MessageBox.Show("Данные успешно добавлены, а также на рабочем столе создан документ об обработке данных клиента!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось создать документы для клиента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataBase.openConnection();
                    SqlDataAdapter da = new SqlDataAdapter("select Customers.name as [Организация], inn as [ИНН], kpp as [КПП], registration_form as [Форма регистрации], ogrn as [ОГРН], Workers.surname as [Сотрудник] from customers join Workers on worker = Workers.ID_worker;", dataBase.getConnection());
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Result");
                    customersDataGridView.DataSource = ds.Tables["Result"];
                    dataBase.closeConnection();

                    infopanel.Visible = false;
                    orgname.Clear();
                    innMaskedBox.Clear();
                    kppMaskedBox.Clear();
                    ogrnMaskedBox.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            infopanel.Visible = true;
        }

        private void delete_note_Click(object sender, EventArgs e)
        {
            string customer_name, INN, OGRN;
            Int32 selectedRowCount = customersDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                foreach (DataGridViewRow row in customersDataGridView.SelectedRows)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите \nразорвать контракт с клиентом?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            customer_name = row.Cells[0].Value.ToString();
                            INN = row.Cells[1].Value.ToString();
                            OGRN = row.Cells[4].Value.ToString();

                            dataBase.openConnection();
                            string querystring = $"delete from customers where name = '{customer_name}' and inn = {INN} and ogrn = {OGRN}";
                            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                            command.ExecuteNonQuery();

                            SqlDataAdapter da = new SqlDataAdapter("select Customers.name as [Организация], inn as [ИНН], kpp as [КПП], registration_form as [Форма регистрации], ogrn as [ОГРН], Workers.surname as [Сотрудник] from customers join Workers on worker = Workers.ID_worker;", dataBase.getConnection());
                            SqlCommandBuilder cb = new SqlCommandBuilder(da);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "Result");
                            customersDataGridView.DataSource = ds.Tables["Result"];
                            dataBase.closeConnection();

                            DirectoryInfo folder = new DirectoryInfo(pathSave);
                            if (folder.Exists)
                            {
                                DirectoryInfo cus_folder = new DirectoryInfo(pathSave);
                                Directory.Delete(cus_folder.ToString(), true);
                            }
                            MessageBox.Show("Данные успешно удалены!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления, выберите одну строку и попробуйте снова!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Невозможно удалить, выберите одну строку и попробуйте снова!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
