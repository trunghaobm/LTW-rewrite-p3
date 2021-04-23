using LTW_rewrite_3rd.Access;
using LTW_rewrite_3rd.myFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTW_rewrite_3rd.myForms.CourseForm
{
    public partial class FCourse : Form
    {
        MyCourses mycrs = new MyCourses();
        AddForm addsrc = new AddForm();
        EditForm edsrc = new EditForm();

        public FCourse()
        {
            InitializeComponent();
        }

        private void _Load()
        {
            dgv_list.DataSource = mycrs.Gets();
            dgv_list.Columns[0].HeaderText = "ID";
            dgv_list.Columns[1].HeaderText = "Name";
            dgv_list.Columns[2].HeaderText = "Begin";
            dgv_list.Columns[3].HeaderText = "Finish";
            dgv_list.AutoResizeColumns();
            panel_list.Controls.Clear();
            panel_list.Controls.Add(dgv_list);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            _Load();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            panel_list.Controls.Clear();
            AllUser.OpenChildForm(addsrc, panel_list);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int index = dgv_list.CurrentCell.RowIndex;
            edsrc = new EditForm(dgv_list.Rows[index].Cells[0].Value.ToString());
            panel_list.Controls.Clear();
            AllUser.OpenChildForm(edsrc, panel_list);
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";
            savefile.FileName = "khoa-hoc";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                MyCourses.DownloadWord(dgv_list, savefile.FileName, "DANH SÁCH KHÓA HỌC");
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = dgv_list.CurrentCell.RowIndex;
            string mid = dgv_list.Rows[index].Cells[0].Value.ToString();
            string mname = dgv_list.Rows[index].Cells[2].Value.ToString() + " "
                            + dgv_list.Rows[index].Cells[1].Value.ToString();
            DialogResult rs = MessageBox.Show("Xóa sinh viên " + mname, "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                mycrs.Delete(mid);
                _Load();
            }
        }

        private void FCourse_Load(object sender, EventArgs e)
        {
            _Load();
        }
    }
}
