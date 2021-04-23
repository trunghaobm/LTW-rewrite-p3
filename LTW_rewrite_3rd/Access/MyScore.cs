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

namespace LTW_rewrite_3rd.Access
{
    class MyScore
    {
        MyDataContext MyDB = new MyDataContext();
        //Students std = new Students();

        public MyScore() { }

        //get all students from database
        public System.Data.DataTable Gets()
        {
            SqlCommand command = new SqlCommand("SELECT * from student", MyDB.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new System.Data.DataTable();
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
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            //check
            if (table.Rows.Count > 0)
            {
                //std.C01_ID = int.Parse(table.Rows[0][0].ToString());
                //std.C02_FirstName = table.Rows[0][1].ToString();
                //std.C03_LastName = table.Rows[0][2].ToString();
                //std.C04_Birthday = (DateTime)table.Rows[0][3];
                //std.C05_Male = bool.Parse(table.Rows[0][4].ToString());
                //std.C06_Phone = table.Rows[0][5].ToString();
                //std.C07_Address = table.Rows[0][6].ToString();
                //byte[] pic;
                //if (table.Rows[0][7].ToString() != null)
                //{
                //    try
                //    {
                //        pic = (byte[])table.Rows[0][7];
                //        std.C08_Avatar = pic;
                //    }
                //    catch
                //    {

                //    }
                //}
                //else
                //{
                //    std.C08_Avatar = null;
                //}
                //return std;
            }
            else
            {
                return null;
            }

            return null;
        }

        //add one student to database
        public bool Add(/*Students std*/)
        {
            bool check = true;

            //var query = "INSERT into student VALUES(@C01, @C02, @C03, @C04, @C05, @C06, @C07, @C08)";
            //SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            //command.Parameters.Add("@C01", SqlDbType.Int).Value = std.C01_ID;
            //command.Parameters.Add("@C02", SqlDbType.NVarChar).Value = std.C02_FirstName;
            //command.Parameters.Add("@C03", SqlDbType.NVarChar).Value = std.C03_LastName;
            //command.Parameters.Add("@C04", SqlDbType.DateTime).Value = std.C04_Birthday;
            //command.Parameters.Add("@C05", SqlDbType.Bit).Value = std.C05_Male;
            //command.Parameters.Add("@C06", SqlDbType.NVarChar).Value = std.C06_Phone;
            //command.Parameters.Add("@C07", SqlDbType.NVarChar).Value = std.C07_Address;
            //command.Parameters.Add("@C08", SqlDbType.Image).Value = std.C08_Avatar;

            //MyDB.openConection();
            //if (command.ExecuteNonQuery() == 1)
            //{
            //    check = true;
            //}
            //else
            //{
            //    check = false;
            //}
            //MyDB.closedConection();
            return check;
        }

        //edit a student
        public bool Edit(/*Students std*/)
        {
            bool check = true;

            //var query = "UPDATE student SET " +
            //            "c02_firstname = @C02, " +
            //            "c03_lastname = @C03, " +
            //            "c04_birthday = @C04, " +
            //            "c05_gender = @C05, " +
            //            "c06_phonenumber = @C06, " +
            //            "c07_address = @C07, " +
            //            "c08_avatar = @C08 " +
            //            "WHERE c01_id = @C01";
            //SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            //command.Parameters.Add("@C01", SqlDbType.Int).Value = std.C01_ID;
            //command.Parameters.Add("@C02", SqlDbType.NVarChar).Value = std.C02_FirstName;
            //command.Parameters.Add("@C03", SqlDbType.NVarChar).Value = std.C03_LastName;
            //command.Parameters.Add("@C04", SqlDbType.Date).Value = std.C04_Birthday;
            //command.Parameters.Add("@C05", SqlDbType.Bit).Value = std.C05_Male;
            //command.Parameters.Add("@C06", SqlDbType.NVarChar).Value = std.C06_Phone;
            //command.Parameters.Add("@C07", SqlDbType.NVarChar).Value = std.C07_Address;
            //command.Parameters.Add("@C08", SqlDbType.Image).Value = std.C08_Avatar;

            //MyDB.openConection();
            //if (command.ExecuteNonQuery() == 1)
            //{
            //    check = true;
            //}
            //else
            //{
            //    check = false;
            //}

            //MyDB.closedConection();
            return check;
        }

        //delete a student
        public bool Delete(/*Students std*/)
        {
            bool check = true;

            //var query = "DELETE student " +
            //            "WHERE c01_id = @C01";
            //SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            //command.Parameters.Add("@C01", SqlDbType.Int).Value = std.C01_ID;

            //MyDB.openConection();
            //if (command.ExecuteNonQuery() == 1)
            //{
            //    check = true;
            //}
            //else
            //{
            //    check = false;
            //}
            //MyDB.closedConection();

            return check;
        }

        public bool Delete(string id)
        {
            bool check = true;

            //var query = "DELETE student " +
            //            "WHERE c01_id = @C01";
            //SqlCommand command = new SqlCommand(query, MyDB.GetConnection);
            //command.Parameters.Add("@C01", SqlDbType.Int).Value = int.Parse(id);

            //MyDB.openConection();
            //if (command.ExecuteNonQuery() == 1)
            //{
            //    check = true;
            //}
            //else
            //{
            //    check = false;
            //}
            //MyDB.closedConection();

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
                            //case 3:     //chỉ lấy format ngày
                            //    string myDate = DGV.Rows[r].Cells[c].Value.ToString().Split(' ')[0];
                            //    myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Text = myDate;
                            //    break;
                            //case 4: //cột giới tính
                            //    string gen = "Nữ";
                            //    if ((bool)DGV.Rows[r].Cells[c].Value)
                            //    {
                            //        gen = "Nam";
                            //    }
                            //    myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Text = gen;
                            //    break;
                            //case 7:
                            //    if (DGV.Rows[r].Cells[c].Value.ToString() != null)
                            //    {
                            //        byte[] imgbyte = (byte[])DGV.Rows[r].Cells[c].Value;
                            //        MemoryStream ms = new MemoryStream(imgbyte);
                            //        Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                            //        Clipboard.SetDataObject(finalPic);
                            //        Image sparePicture = Image.FromStream(ms);
                            //        myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Paste();
                            //    }
                            //    break;
                            default:
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
