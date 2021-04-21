using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_rewrite_3rd.Database
{
    class MyDataContext
    {
        //string connectionstring = "Data Source=GIDEON;Database=LTW;Integrated Security=True";
        SqlConnection conn = new SqlConnection("Data Source=GIDEON;Database=LTW;Integrated Security=True");

        //lay thong tin ket noi
        public SqlConnection GetConnection
        {
            get { return conn; }
        }
        //mo ket noi
        public void openConection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        //ong ket noi
        public void closedConection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
