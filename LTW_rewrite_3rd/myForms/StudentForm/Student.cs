using LTW_rewrite_3rd.Access;
using LTW_rewrite_3rd.Models;
using LTW_rewrite_3rd.myFunctions;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LTW_rewrite_3rd.myForms.StudentForm
{
    public partial class Student : Form
    {
        MyStudents mstd = new MyStudents();
        AddForm addstd = new AddForm();
        EditForm edstd = new EditForm();
        MyStudents mySTD = new MyStudents();
        public Student()
        {
            InitializeComponent();
        }

        private void _Load()
        {
            dgv_listStudent.DataSource = mstd.Gets();
            dgv_listStudent.AutoResizeColumns();
            dgv_listStudent.RowTemplate.Height = 50;
            dgv_listStudent.Columns[0].HeaderText = "ID";
            dgv_listStudent.Columns[1].HeaderText = "First Name";
            dgv_listStudent.Columns[2].HeaderText = "Last Name";
            dgv_listStudent.Columns[3].HeaderText = "Birthday";
            dgv_listStudent.Columns[3].DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgv_listStudent.Columns[4].HeaderText = "Male";
            dgv_listStudent.Columns[5].HeaderText = "Phone";
            dgv_listStudent.Columns[6].HeaderText = "Address";
            dgv_listStudent.Columns[7].HeaderText = "Avatar";
            dgv_listStudent.Columns[7].Width = 50;
            DataGridViewImageColumn avtCol = new DataGridViewImageColumn();
            avtCol = (DataGridViewImageColumn)dgv_listStudent.Columns[7];
            avtCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            panel_list.Controls.Clear();
            panel_list.Controls.Add(dgv_listStudent);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            _Load();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            panel_list.Controls.Clear();
            AllUser.OpenChildForm(addstd, panel_list);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = dgv_listStudent.CurrentCell.RowIndex;
            string mid = dgv_listStudent.Rows[index].Cells[0].Value.ToString();
            string mname = dgv_listStudent.Rows[index].Cells[2].Value.ToString() + " "
                            + dgv_listStudent.Rows[index].Cells[1].Value.ToString();
            DialogResult rs = MessageBox.Show("Xóa sinh viên " + mname, "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                mySTD.Delete(mid);
                _Load();
            }
        }

        private void dgv_listStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_download_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                AllUser.DownloadWord(dgv_listStudent, savefile.FileName, "DANH SÁCH SINH VIÊN");
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int index = dgv_listStudent.CurrentCell.RowIndex;
            edstd = new EditForm(dgv_listStudent.Rows[index].Cells[0].Value.ToString());
            panel_list.Controls.Clear();
            AllUser.OpenChildForm(edstd, panel_list);
        }
    }
}
