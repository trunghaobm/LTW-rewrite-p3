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
    public partial class AddForm : Form
    {
        MyCourses myCRS = new MyCourses();
        public AddForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try 
            { 
                Courses crs = new Courses
                {
                    C01_id = txt_id.Text,
                    C02_name = txt_name.Text,
                    C03_datestart = date_start.Value,
                    C04_dateend = date_end.Value
                };
                myCRS.Add(crs);
                MessageBox.Show("Done");
                _Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        public bool _Close()
        {
            _Load();
            this.Close();
            return true;
        }

        public void _Load()
        {
            this.txt_id.Text = "";
            this.txt_name.Text = "";
            this.date_start.Value = DateTime.Today;
            this.date_end.Value = DateTime.Today;
            this.Close();
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            _Close();
        }
    }
}
