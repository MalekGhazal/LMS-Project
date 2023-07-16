using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_Project.Classes;
using System.Windows.Forms;

namespace LMS_Project.DataBase
{
    internal class MyDB
    {
        private SqlConnection conn = new SqlConnection("data source=DESKTOP-39IEJT0\\SQLEXPRESS;database=LMS;integrated security=True");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

    }
}
