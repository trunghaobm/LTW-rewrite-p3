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

namespace LTW_rewrite_3rd.myForms.StudentForm
{
    public partial class Main : Form
    {
        Welcome wlc = new Welcome();
        LoginForStart lg = new LoginForStart();
        Student std = new Student();
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
    }
}
