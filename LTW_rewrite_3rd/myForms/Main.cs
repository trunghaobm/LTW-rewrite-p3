using LTW_rewrite_3rd.myFunctions;
using LTW_rewrite_3rd.myForms.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTW_rewrite_3rd.myForms.StudentForm;
using LTW_rewrite_3rd.myForms.CourseForm;

namespace LTW_rewrite_3rd.myForms
{
    public partial class Main : Form
    {
        Welcome wlc = new Welcome();
        LoginForStart lg = new LoginForStart();
        FStudent std = new FStudent();
        FCourse crs = new FCourse();
        public Main()
        {
            InitializeComponent();
        }

        private bool Loggingin()
        {
            this.Hide();
            lg.ShowDialog();
            return lg.loginaccess;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Loggingin())
            {
                this._Load();
                this.Show();
            }
            else
            {
                this.Close();
            }    
        }

        private void _Load()
        {
            panel_main.Controls.Clear();
            AllUser.OpenChildForm(wlc, panel_main);
        }

        private void btn_sinhVien_Click(object sender, EventArgs e)
        {
            if(btn_sinhVien.BackColor == SystemColors.ControlDarkDark)
            {
                TurnOffAllButton();

                btn_sinhVien.BackColor = SystemColors.ControlDark;
                panel_main.Controls.Clear();
                AllUser.OpenChildForm(std, panel_main);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (Loggingin())
            {
                this._Load();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            if (btn_course.BackColor == SystemColors.ControlDarkDark)
            {
                TurnOffAllButton();

                btn_course.BackColor = SystemColors.ControlDark;
                panel_main.Controls.Clear();
                AllUser.OpenChildForm(crs, panel_main);
            }
        }

        private void TurnOffAllButton()
        {
            btn_sinhVien.BackColor = SystemColors.ControlDarkDark;
            btn_course.BackColor = SystemColors.ControlDarkDark;
        }
    }
}
