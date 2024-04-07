
using dataBaseConnection;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using Application = System.Windows.Forms.Application;
using Point = System.Drawing.Point;

namespace OutAccounting.forms
{
    public partial class statistic : Form
    {
        dataBase dataBase = new dataBase();
        workingWithData wWD = new workingWithData();

        string mainTable = "SELECT Workers.surname as Работник, COUNT(Customers.name) as Клиенты FROM Customers JOIN Workers ON Workers.ID_worker = Customers.worker GROUP BY Workers.surname";

        public statistic()
        {
            InitializeComponent();

            wWD.updateTable(mainTable, statisticTable);

            try
            {
                workersStatistic.Series.Clear();
                workersStatistic.Series.Add("Количество \nклиентов \nработника");

                for (int i = 0; i < statisticTable.RowCount; i++)
                {
                    var name = statisticTable.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var value = statisticTable.Rows[i].Cells[1].Value?.ToString() ?? "";
                    workersStatistic.Series["Количество \nклиентов \nработника"].Points.AddXY(name, value);
                }
                workersStatistic.Titles.Clear();

                workersStatistic.ChartAreas[0].AxisX.Title = statisticTable.Columns[0].HeaderText;
                workersStatistic.ChartAreas[0].AxisY.Title = statisticTable.Columns[1].HeaderText;
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ошибка: Недостаточно столбцов в DataGridView", "Ошибка");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: недопустимые данные в DataGridView", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            authorization authorization = new authorization();
            authorization.Show();
            this.Hide();
        }

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Вы уверены, что хотите закрыть приложение? \nВсе несохранённые данные будут потеряны.", "Подтверждение закрытия приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void allTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allTimeRadioButton.Checked)
            {
                currentMonthRadioButton.Checked = false;
                wWD.updateTable(mainTable, statisticTable);
            }
        }

        private void currentMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMonthRadioButton.Checked)
            {
                allTimeRadioButton.Checked = false;
                // доделать
                wWD.updateTable(mainTable, statisticTable);
            }
        }
    }
}
