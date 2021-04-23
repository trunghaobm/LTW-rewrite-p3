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
        SqlConnection con = new SqlConnection(@"data source=GIDEON;initial catalog=LTW;integrated security=True");
        public SqlConnection GetConnection
        {
            get { return con; }
        }

        public void openConection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closedConection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
