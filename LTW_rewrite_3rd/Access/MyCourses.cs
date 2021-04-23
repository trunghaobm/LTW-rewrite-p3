using LTW_rewrite_3rd.Database;
using LTW_rewrite_3rd.Models;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace LTW_rewrite_3rd.Access
{
    class MyCourses
    {
        MyDataContext MyDB = new MyDataContext();
        Courses crs = new Courses();

        public MyCourses() { }

        //get all Coursess from database
        public DataTable Gets()
        {
            SqlCommand command = new SqlCommand("SELECT * from Courses", MyDB.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get 1 Courses show to form not show in data grid view
        public Courses GetID(string id)
        {
            //tao query sql
            var query = "SELECT * FROM Courses WHERE c01_id = @id";
            //connected
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //check
            if (table.Rows.Count > 0)
            {
                crs.C01_id = table.Rows[0][0].ToString();
                crs.C02_name = table.Rows[0][1].ToString();
                crs.C03_datestart = (DateTime)table.Rows[0][2];
                crs.C04_dateend = (DateTime)table.Rows[0][3];
                return crs;
            }
            else
            {
                return null;
            }
        }

        //add one Courses to database
        public bool Add(Courses mcrs)
        {
            bool check;

            var query = "INSERT into Courses VALUES(@C01, @C02, @C03, @C04)";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.NVarChar).Value = mcrs.C01_id;
            command.Parameters.Add("@C02", SqlDbType.NVarChar).Value = mcrs.C02_name;
            command.Parameters.Add("@C03", SqlDbType.Date).Value = mcrs.C03_datestart;
            command.Parameters.Add("@C04", SqlDbType.Date).Value = mcrs.C04_dateend;

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

        //edit a Courses
        public bool Edit(Courses mcrs)
        {
            bool check;

            var query = "UPDATE Courses SET " +
                        "C02_name = @C02, " +
                        "C03_datestart = @C03, " +
                        "C04_dateend = @C04 " +
                        "WHERE c01_id = @C01";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.NVarChar).Value = mcrs.C01_id;
            command.Parameters.Add("@C02", SqlDbType.NVarChar).Value = mcrs.C02_name;
            command.Parameters.Add("@C03", SqlDbType.Date).Value = mcrs.C03_datestart;
            command.Parameters.Add("@C04", SqlDbType.Date).Value = mcrs.C04_dateend;

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

        //delete a Courses
        public bool Delete(Courses mcrs)
        {
            bool check;

            var query = "DELETE Courses " +
                        "WHERE c01_id = @C01";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.NVarChar).Value = mcrs.C01_id;

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

            var query = "DELETE Courses " +
                        "WHERE c01_id = @C01";
            SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            command.Parameters.Add("@C01", SqlDbType.NVarChar).Value = id;

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

        public static void DownloadWord(DataGridView DGV, string filename, string header)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Document myDoc = new Document();
                myDoc.Application.Visible = true;
                myDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                //header
                foreach (Section section in myDoc.Application.ActiveDocument.Sections) //Document myDoc have sections
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range; //section have ranges
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.Text = header;
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                }
                object start = 0;
                object end = 0;
                object myMissing = System.Reflection.Missing.Value;
                var myPara = myDoc.Content.Paragraphs.Add(ref myMissing);
                myPara.Range.Tables.Add(myPara.Range, RowCount, ColumnCount);
                myDoc.Application.ActiveDocument.Tables[1].Range.Font.Size = 11;
                myDoc.Application.ActiveDocument.Tables[1].set_Style("Plain Table 1");
                for (int c = 0; c < ColumnCount; c++)
                {
                    myDoc.Application.ActiveDocument.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText.ToString();
                }

                for (int r = 0; r <= RowCount - 2; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {
                        switch (c)
                        {
                            case int n when (n ==2 || n == 3):
                                string myDate = DGV.Rows[r].Cells[c].Value.ToString().Split(' ')[0];
                                myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Text = myDate;
                                break;
                            default :
                                myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Text = DGV.Rows[r].Cells[c].Value.ToString();
                                break;
                        }
                    }
                }

                //save the file
                myDoc.SaveAs2(filename);
            }
        }
    }
}
