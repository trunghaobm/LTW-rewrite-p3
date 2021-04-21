using LTW_rewrite_3rd.Database;
using LTW_rewrite_3rd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_rewrite_3rd.Access
{
    class MyLogin
    {
        MyDataContext MyDB = new MyDataContext();
        public DataTable getUser()
        {
            SqlCommand command = new SqlCommand("select * from Login", MyDB.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool CheckLogin(string user, string pass)
        {
            //khoi tao gia tri tra ve
            bool check = true;
            //truy van toi csdl
            SqlCommand command = new SqlCommand("SELECT * from login WHERE  username=@user AND password=@pass", MyDB.GetConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            /*neu co user thoa man thi tra ve true
             neu khong tra ve false*/
            if (dt.Rows.Count > 0)
            {
                check = true;
            }
            else check = false;
            return check;
        }

        //register
        public bool Add(Logins lg)
        {
            //khoi tao gia tri tra ve
            bool check = true;
            //truy van toi csdl
            var query = "INSERT into Login VALUES(@user, @pass)";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = lg.Username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = lg.Password;

            MyDB.openConection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch
            {
                check = false;
            }
            MyDB.closedConection();
            return check;
        }
    }
}
