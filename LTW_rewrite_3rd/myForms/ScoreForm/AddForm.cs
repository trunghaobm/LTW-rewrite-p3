using LTW_rewrite_3rd.Access;
using LTW_rewrite_3rd.Database;
using LTW_rewrite_3rd.Models;
using LTW_rewrite_3rd.myFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTW_rewrite_3rd.myForms.ScoreForm
{
    public partial class AddForm : Form
    {
        //MyStudents mySTD = new MyStudents();

        public AddForm()
        {
            InitializeComponent();
        }

        private void btn_avatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    //btn_avatar.BackgroundImage = new Bitmap(open.FileName);
                }
                //btn_avatar.Text = "";
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }

        }

        public void _Load()
        {
            //this.DialogResult = DialogResult.OK;
            //this.txt_id.Text = "";
            //this.txt_firstname.Text = "";
            //this.txt_lastname.Text = "";
            //this.date_birthday.Value = DateTime.Today;
            //this.rad_male.Checked = true;
            //this.txt_phone.Text = "";
            //this.txt_address.Text = "";
            //this.btn_avatar.BackgroundImage = null;
            //this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Students std = new Students
                {
                    //C01_ID = int.Parse(txt_id.Text),
                    //C02_FirstName = txt_firstname.Text,
                    //C03_LastName = txt_lastname.Text,
                    //C04_Birthday = date_birthday.Value,
                    //C05_Male = rad_male.Checked,
                    //C06_Phone = txt_phone.Text,
                    //C07_Address = txt_address.Text,
                    //C08_Avatar = AllUser.ImageToBinary(btn_avatar.BackgroundImage)
                };
                //mySTD.Add(std);
                MessageBox.Show("Done");
                _Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool _Close()
        {
            _Load();
            this.Close();
            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _Close();
        }

        private void rad_male_Click(object sender, EventArgs e)
        {
            //if (rad_female.Checked != rad_male.Checked)
            //{
            //    RadioButton rad = (RadioButton)sender;
            //    if (rad.Checked == true) rad.Checked = false;
            //    else rad.Checked = true;
            //}
        }
    }
}
