using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBaseConnection
{
    public class dataBase
    {
        /// <summary>
        /// Класс dataBase открывает, закрывает и получает подключение к базе дынных
        /// </summary>

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-8R9KQAA;Initial Catalog=accounting;Integrated Security=True");

            public void openConnection()
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
            }

            public void closeConnection()
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            public SqlConnection getConnection()
            {
                return sqlConnection;
            }
    }
}
