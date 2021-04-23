using LTW_rewrite_3rd.Access;
using LTW_rewrite_3rd.Database;
using LTW_rewrite_3rd.Models;
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

namespace LTW_rewrite_3rd.myForms.StudentForm
{
    public partial class EditForm : Form
    {
        MyStudents mySTD = new MyStudents();
        Students std = new Students();
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string id)
        {
            std = mySTD.GetID(int.Parse(id));
            InitializeComponent();
        }

        private void _Load()
        {
            txt_id.Text = std.C01_ID.ToString();
            txt_firstname.Text = std.C02_FirstName ;
            txt_lastname.Text = std.C03_LastName;
            date_birthday.Value = std.C04_Birthday;
            rad_male.Checked = std.C05_Male;
            rad_female.Checked = !std.C05_Male;
            txt_phone.Text = std.C06_Phone;
            txt_address.Text = std.C07_Address;
            btn_avatar.BackgroundImage = AllUser.BinaryToImage(std.C08_Avatar);
        }

        private void _LoadBack_()
        {
            std.C01_ID = int.Parse(txt_id.Text);
            std.C02_FirstName = txt_firstname.Text;
            std.C03_LastName = txt_lastname.Text;
            std.C04_Birthday = date_birthday.Value;
            std.C05_Male = rad_male.Checked;
            std.C06_Phone = txt_phone.Text;
            std.C07_Address = txt_address.Text;
            std.C08_Avatar =AllUser.ImageToBinary(btn_avatar.BackgroundImage);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _LoadBack_();
            if(mySTD.Edit(std))
            {
                MessageBox.Show("done");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_avatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    btn_avatar.BackgroundImage = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            _Load();
        }
    }
}
