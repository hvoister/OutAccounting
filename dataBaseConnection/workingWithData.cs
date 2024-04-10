﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace dataBaseConnection
{
    public class workingWithData
    {
        dataBase dataBase = new dataBase();

        public void operationsBuilder(string query)
        {
            dataBase.openConnection();
            SqlCommand commandBuilder = new SqlCommand(query, dataBase.getConnection());
            commandBuilder.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public void updateTable(string querty, DataGridView resultTable)
        {
            dataBase.openConnection();
            SqlDataAdapter table = new SqlDataAdapter(querty, dataBase.getConnection());
            SqlCommandBuilder creatingTable = new SqlCommandBuilder(table);
            DataSet orderTable = new DataSet();
            table.Fill(orderTable, "orderTableName");
            resultTable.DataSource = orderTable.Tables["orderTableName"];
            dataBase.closeConnection();

            if (resultTable.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для отображения!", "Таблица пуста", MessageBoxButtons.OK, MessageBoxIcon.Question);
            };

            for (int i = 0; i < resultTable.Columns.Count; i++)
            {
                resultTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            resultTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public void comboBoxFuller(string query, string column, ComboBox resultComboBox)
        {
            resultComboBox.DataSource = null;
            resultComboBox.Items.Clear();
            dataBase.openConnection();
            SqlDataAdapter table = new SqlDataAdapter(query, dataBase.getConnection());
            DataTable orderTable = new DataTable();
            table.Fill(orderTable);
            dataBase.closeConnection();
            for (int i = 0; i < orderTable.Rows.Count; i++)
            {
                resultComboBox.Items.Add(orderTable.Rows[i][column]);
            };
        }

        public string executeScalar(string query)
        {
            dataBase.openConnection();
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            string result = Convert.ToString(command.ExecuteScalar());
            dataBase.closeConnection();
            return result;
        }

        public int noteExistsCheck(string query)
        {
            dataBase.openConnection();

            DataTable resultTable = new DataTable();
            SqlDataAdapter noteExistsCheck = new SqlDataAdapter(query, dataBase.getConnection());
            noteExistsCheck.Fill(resultTable);

            dataBase.closeConnection();

            int result = resultTable.Rows.Count;
            return result;
        }

        public void graphicPicture(Chart chart, DataGridView table, string resultName)
        {
            try
            {
                chart.Series[0].Points.Clear();
                chart.Series.Clear();
                chart.Series.Add(resultName);

                for (int i = 0; i < table.RowCount; i++)
                {
                    var name = table.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var value = table.Rows[i].Cells[1].Value?.ToString() ?? "";
                    chart.Series[resultName].Points.AddXY(name, value);
                }
                chart.Titles.Clear();

                chart.ChartAreas[0].AxisX.Title = table.Columns[0].HeaderText;
                chart.ChartAreas[0].AxisY.Title = table.Columns[1].HeaderText;
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
    }
}
