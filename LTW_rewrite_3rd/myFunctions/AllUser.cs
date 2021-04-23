using LTW_rewrite_3rd.Access;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTW_rewrite_3rd.myFunctions
{
    public class AllUser
    {
        public static void OpenChildForm(Form childform, Panel panelMain)
        {
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childform);
            panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        //public static void DownloadWord(DataGridView DGV, string filename, string header)
        //{
        //    if (DGV.Rows.Count != 0)
        //    {
        //        int RowCount = DGV.Rows.Count;
        //        int ColumnCount = DGV.Columns.Count;
        //        Document myDoc = new Document();
        //        myDoc.Application.Visible = true;
        //        myDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
        //        //header
        //        foreach (Section section in myDoc.Application.ActiveDocument.Sections) //Document myDoc have sections
        //        {
        //            Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range; //section have ranges
        //            headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
        //            headerRange.Text = header;
        //            headerRange.Font.Size = 16;
        //            headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        //        }
        //        object start = 0;
        //        object end = 0;
        //        string myTemp = ""; //string myTemp to store content EXCEPT PICTURE
        //        Object myMissing = System.Reflection.Missing.Value;
        //        var myPara = myDoc.Content.Paragraphs.Add(ref myMissing);
        //        myPara.Range.Tables.Add(myPara.Range, RowCount, ColumnCount);
        //        myDoc.Application.ActiveDocument.Tables[1].Range.Font.Size = 11;
        //        myDoc.Application.ActiveDocument.Tables[1].set_Style("Plain Table 1");
        //        for (int c = 0; c < ColumnCount - 1; c++)
        //        {
        //            myDoc.Application.ActiveDocument.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText.ToString();
        //        }

        //        for (int r = 0; r <= RowCount - 2; r++)
        //        {
        //            for (int c = 0; c < ColumnCount - 1; c++)
        //            {
        //                switch (c)
        //                {
        //                    case 3:     //chỉ lấy format ngày
        //                        string myDate = DGV.Rows[r].Cells[c].Value.ToString().Split(' ')[0];
        //                        myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Text = myDate; 
        //                        break;
        //                    case 4: //cột giới tính
        //                        string gen = "Nữ";
        //                        if ((bool)DGV.Rows[r].Cells[c].Value)
        //                        {
        //                            gen = "Nam";
        //                        }
        //                        myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Text = gen;
        //                        break;
        //                    default:
        //                        myDoc.Application.ActiveDocument.Tables[1].Cell(r + 2, c + 1).Range.Text = DGV.Rows[r].Cells[c].Value.ToString(); 
        //                        break;
        //                }
        //            }
        //        }

        //        for (int r = 2; r <= RowCount; r++)//cột avatar
        //        {
        //            if (DGV.Rows[r - 2].Cells[7].Value.ToString() != null)
        //            {
        //                try
        //                {
        //                    byte[] imgbyte = (byte[])DGV.Rows[r - 2].Cells[7].Value;
        //                    MemoryStream ms = new MemoryStream(imgbyte);
        //                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
        //                    Clipboard.SetDataObject(finalPic);
        //                    Image sparePicture = Image.FromStream(ms);
        //                }
        //                catch
        //                {

        //                }
        //            }
        //            else
        //            {

        //            }
        //            myDoc.Application.ActiveDocument.Tables[1].Cell(r, ColumnCount).Range.Paste();
        //        }

        //        //save the file
        //        myDoc.SaveAs2(filename);
        //    }
        //}

        public static byte[] ImageToBinary(Image source)
        {
            MemoryStream ms = new MemoryStream();
            source.Save(ms, source.RawFormat);
            return ms.ToArray();
        }

        public static Image BinaryToImage(byte[] source)
        {
            try
            {
                MemoryStream ms = new MemoryStream(source, 0, source.Length);
                ms.Write(source, 0, source.Length);
                return Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return null;
        }
    }
}
