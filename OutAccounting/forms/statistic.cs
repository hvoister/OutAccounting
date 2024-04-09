
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

        string mainTableCustomers = "SELECT Workers.surname as Работник, COUNT(Customers.name) as Клиенты FROM Customers JOIN Workers ON Workers.ID_worker = Customers.worker GROUP BY Workers.surname ORDER BY COUNT(Customers.name) DESC";
        string sideTableCustomers = $"SELECT Workers.surname as Работник, COUNT(Customers.name) as Клиенты FROM Customers JOIN Workers ON Workers.ID_worker = Customers.worker JOIN Accounting ON Customers.ID_customer = Accounting.customer WHERE start_date >= '01.{DateTime.Today.Month}.{DateTime.Today.Year}' GROUP BY Workers.surname ORDER BY COUNT(Customers.name) DESC";

        string MTCArchive = "SELECT worker as Работник, COUNT(customer) as Клиенты FROM ArchiveAccounting GROUP BY worker ORDER BY COUNT(customer) DESC";
        string STBArchive = $"SELECT worker as Работник, COUNT(customer) as Клиенты FROM ArchiveAccounting WHERE start_date >= '01.{DateTime.Today.Month}.{DateTime.Today.Year}' GROUP BY worker ORDER BY COUNT(customer) DESC";

        string mainTableTarif = "SELECT Tarifs.name as Тариф, COUNT(Accounting.tarif) as Использование FROM Accounting JOIN Tarifs ON Tarifs.ID_tarif = Accounting.tarif GROUP BY Tarifs.name ORDER BY COUNT(Accounting.tarif) DESC;";
        string sideTableTarif = $"SELECT Tarifs.name as Тариф, COUNT(Accounting.tarif) as Использование FROM Accounting JOIN Tarifs ON Tarifs.ID_tarif = Accounting.tarif WHERE start_date >= '01.{DateTime.Today.Month}.{DateTime.Today.Year}' GROUP BY Tarifs.name ORDER BY COUNT(Accounting.tarif) DESC;";

        string MTTArchive = "SELECT tarif as Тариф, COUNT(tarif) as Использование FROM ArchiveAccounting GROUP BY tarif ORDER BY COUNT(tarif) DESC";
        string STTArchive = $"SELECT tarif as Тариф, COUNT(tarif) as Использование FROM ArchiveAccounting WHERE start_date >= '01.{DateTime.Today.Month}.{DateTime.Today.Year}' GROUP BY tarif ORDER BY COUNT(tarif) DESC";

        public statistic()
        {
            InitializeComponent();

            allTimeRadioButton.Checked = true;
            choiseComboBox.SelectedIndex = 0;
            wWD.updateTable(mainTableCustomers, statisticTable);
            wWD.graphicPicture(workersStatistic, statisticTable, "Клиенты \nданного \nработника");
        }

        private void updateTableAndGraphic(Boolean current)
        {
            if (current)
            {
                switch (choiseComboBox.SelectedIndex)
                {
                    case 0:
                        wWD.updateTable(mainTableCustomers, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Клиенты \nданного \nработника");
                        break;
                    case 1:
                        wWD.updateTable(MTCArchive, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Клиенты \nданного \nработника \nв архиве");
                        break;
                    case 2:
                        wWD.updateTable(mainTableTarif, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Использование \nданного \nтарифа");
                        break;
                    case 3:
                        wWD.updateTable(MTTArchive, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Использование \nданного \nтарифа \nв архиве");
                        break;
                }
            }
            else
            {
                switch (choiseComboBox.SelectedIndex)
                {
                    case 0:
                        wWD.updateTable(sideTableCustomers, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Клиенты \nданного \nработника");
                        break;
                    case 1:
                        wWD.updateTable(STBArchive, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Клиенты \nданного \nработника \nв архиве");
                        break;
                    case 2:
                        wWD.updateTable(sideTableTarif, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Использование \nданного \nтарифа");
                        break;
                    case 3:
                        wWD.updateTable(STTArchive, statisticTable);
                        wWD.graphicPicture(workersStatistic, statisticTable, "Использование \nданного \nтарифа \nв архиве");
                        break;
                }
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
                updateTableAndGraphic(true);
            }
        }

        private void currentMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMonthRadioButton.Checked)
            {
                allTimeRadioButton.Checked = false;
                updateTableAndGraphic(false);
            }
        }

        private void choiseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allTimeRadioButton.Checked = true;
            if (allTimeRadioButton.Checked)
            {
                currentMonthRadioButton.Checked = false;
                updateTableAndGraphic(true);
            }
            else
            {
                allTimeRadioButton.Checked = false;
                updateTableAndGraphic(false);
            }
        }
    }
}
