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
    class MyStudents
    {
        MyDataContext MyDB = new MyDataContext();
        Students std = new Students();

        public MyStudents() { }

        //get all students from database
        public DataTable Gets()
        {
            SqlCommand command = new SqlCommand("SELECT * from student", MyDB.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get 1 student show to form not show in data grid view
        public Students GetID(int id)
        {
            //tao query sql
            var query = "SELECT * FROM student WHERE c01_id = @id";
            //connected
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //check
            if (table.Rows.Count > 0)
            {
                std.C01_ID = int.Parse(table.Rows[0][0].ToString());
                std.C02_FirstName = table.Rows[0][1].ToString();
                std.C03_LastName = table.Rows[0][2].ToString();
                std.C04_Birthday = (DateTime)table.Rows[0][3];
                std.C05_Male = bool.Parse(table.Rows[0][4].ToString());
                std.C06_Phone = table.Rows[0][5].ToString();
                std.C07_Address = table.Rows[0][6].ToString();
                byte[] pic;
                if (table.Rows[0][7].ToString() != null)
                {
                    try
                    {
                        pic = (byte[])table.Rows[0][7];
                        std.C08_Avatar = pic;
                    }
                    catch
                    {

                    }
                }
                else
                {
                    std.C08_Avatar = null;
                }
                return std;
            }
            else
            {
                return null;
            }
        }

        //get students by them gender
        public DataTable GetGender(bool male)
        {
            var query = "SELECT * from student " +
                        "WHERE C05_gender = @gender";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@gender", SqlDbType.Bit).Value = male;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get students by them bithday
        public DataTable GetBirthday(DateTime date)
        {
            var query = "SELECT * from student " +
                        "WHERE C04_birthday = @birthday";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = date.Date;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get students who birthday between date_first and date_last
        public DataTable GetBirthdayRange(DateTime date_first, DateTime date_last)
        {
            var query = "SELECT * from student " +
                        "WHERE convert(date,birthday) between @date_first and @date_last";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@date_last", SqlDbType.DateTime).Value = date_first.Date;
            command.Parameters.Add("@date_last", SqlDbType.DateTime).Value = date_last.Date;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //add one student to database
        public bool Add(Students std)
        {
            bool check;

            var query = "INSERT into student VALUES(@C01, @C02, @C03, @C04, @C05, @C06, @C07, @C08)";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.Int).Value = std.C01_ID;
            command.Parameters.Add("@C02", SqlDbType.NVarChar).Value = std.C02_FirstName;
            command.Parameters.Add("@C03", SqlDbType.NVarChar).Value = std.C03_LastName;
            command.Parameters.Add("@C04", SqlDbType.DateTime).Value = std.C04_Birthday;
            command.Parameters.Add("@C05", SqlDbType.Bit).Value = std.C05_Male;
            command.Parameters.Add("@C06", SqlDbType.NVarChar).Value = std.C06_Phone;
            command.Parameters.Add("@C07", SqlDbType.NVarChar).Value = std.C07_Address;
            command.Parameters.Add("@C08", SqlDbType.Image).Value = std.C08_Avatar;

            MyDB.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            MyDB.closedConection();
            return check;
        }

        //edit a student
        public bool Edit(Students std)
        {
            bool check;

            var query = "UPDATE  student SET " +
                        "c02_firstname = @C02, " +
                        "c03_lastname = @C03, " +
                        "c04_birthday = @C04, " +
                        "c05_gender = @C05, " +
                        "c06_phonenumber = @C06, " +
                        "c07_address = @C07, " +
                        "c08_avatar = @C08 " +
                        "WHERE c01_id = @C01";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.Int).Value = std.C01_ID;
            command.Parameters.Add("@C02", SqlDbType.NVarChar).Value = std.C02_FirstName;
            command.Parameters.Add("@C03", SqlDbType.NVarChar).Value = std.C03_LastName;
            command.Parameters.Add("@C04", SqlDbType.DateTime).Value = std.C04_Birthday;
            command.Parameters.Add("@C05", SqlDbType.Bit).Value = std.C05_Male;
            command.Parameters.Add("@C06", SqlDbType.NVarChar).Value = std.C06_Phone;
            command.Parameters.Add("@C07", SqlDbType.NVarChar).Value = std.C07_Address;
            command.Parameters.Add("@C08", SqlDbType.Image).Value = std.C08_Avatar;

            MyDB.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            MyDB.closedConection();
            return check;
        }

        //delete a student
        public bool Delete(Students std)
        {
            bool check;

            var query = "DELETE student " +
                        "WHERE c01_id = @C01";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.Int).Value = std.C01_ID;

            MyDB.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            MyDB.closedConection();

            return check;
        }

        public bool Delete(string id)
        {
            bool check;

            var query = "DELETE student " +
                        "WHERE c01_id = @C01";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.Int).Value = int.Parse(id);

            MyDB.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            MyDB.closedConection();

            return check;
        }
    }
}
