using LTW_rewrite_3rd.Access;
using LTW_rewrite_3rd.Models;
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
    public partial class EditForm : Form
    {
        MyCourses myCRS = new MyCourses();
        Courses crs = new Courses();
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string id)
        {
            crs = myCRS.GetID(id);
            InitializeComponent();
        }

        private void _Load()
        {
            txt_id.Text = crs.C01_id.ToString();
            txt_name.Text = crs.C02_name;
            date_start.Value = crs.C03_datestart;
            date_end.Value = crs.C04_dateend;
        }

        private void _LoadBack_()
        {
            crs.C01_id = txt_id.Text;
            crs.C02_name = txt_name.Text;
            crs.C03_datestart = date_start.Value;
            crs.C04_dateend = date_end.Value;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _LoadBack_();
            if (myCRS.Edit(crs))
            {
                MessageBox.Show("done");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            _Load();
        }
    }
}
