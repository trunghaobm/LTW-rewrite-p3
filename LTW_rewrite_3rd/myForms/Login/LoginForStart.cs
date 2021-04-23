using LTW_rewrite_3rd.Access;
using LTW_rewrite_3rd.Database;
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

namespace LTW_rewrite_3rd.myForms.Login
{
    public partial class LoginForStart : Form
    {
        public bool loginaccess = false;
        MyDataContext mydb = new MyDataContext();
        MyLogin lg = new MyLogin();
        Logins mode_lg = new Logins();

        public LoginForStart()
        {
            InitializeComponent();
        }

        private void LoginForStart_Load(object sender, EventArgs e)
        {
            pic_rePass.Visible = txt_rePass.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("không được để trường nào trống");
            }
            else
            {
                if (lg.CheckLogin(txt_username.Text, txt_password.Text))
                {
                    loginaccess = true;
                    this.Close();
                }
                else
                {
                    loginaccess = false;
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
                } 
            }
        }

        private void LoginForStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            mydb.closedConection();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (pic_rePass.Visible)
            {
                pic_rePass.Visible = txt_rePass.Visible = false;
                btn_login.Enabled = true;
                txt_username.Focus();
            }
            else
            {
                loginaccess = false;
                this.Close();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (pic_rePass.Visible)
            {
                if (txt_username.Text == "" || txt_password.Text == "" || txt_rePass.Text == "")
                {
                    MessageBox.Show("không được để trường nào trống");
                }
                else
                {
                    if (txt_password.Text == txt_rePass.Text)
                    {
                        mode_lg.Username = txt_username.Text;
                        mode_lg.Password = txt_password.Text;
                        if (lg.Add(mode_lg))
                        {
                            MessageBox.Show("Done");
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không khớp");
                    }
                }
            } 
            else
            {
                pic_rePass.Visible = txt_rePass.Visible = true;
                btn_login.Enabled = false;
                txt_username.Focus();
            }   
        }

        private void LoginForStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == 13)
            //{
            //    if (btn_login.Visible)
            //    {
            //        btn_login_Click(null, null);
            //    }
            //    else
            //    {
            //        btn_register_Click(null, null);
            //    }
            //}
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

        private void Login_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (btn_login.Visible)
                {
                    btn_login_Click(null, null);
                }
                else
                {
                    btn_register_Click(null, null);
                }
            }
        }
    }
}
