
namespace LTW_rewrite_3rd.myForms.Login
{
    partial class LoginForStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lable_banner = new System.Windows.Forms.Label();
            this.txt_rePass = new System.Windows.Forms.TextBox();
            this.pic_rePass = new System.Windows.Forms.PictureBox();
            this.pic_password = new System.Windows.Forms.PictureBox();
            this.pic_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(93, 145);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(227, 38);
            this.txt_username.TabIndex = 0;
            this.txt_username.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_username.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txt_username.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(93, 189);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = 'x';
            this.txt_password.Size = new System.Drawing.Size(227, 38);
            this.txt_password.TabIndex = 1;
            this.txt_password.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_password.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txt_password.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(36, 302);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 50);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(142, 302);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(100, 50);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            this.btn_register.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(248, 302);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 50);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // lable_banner
            // 
            this.lable_banner.AutoSize = true;
            this.lable_banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_banner.Location = new System.Drawing.Point(99, 52);
            this.lable_banner.Name = "lable_banner";
            this.lable_banner.Size = new System.Drawing.Size(208, 63);
            this.lable_banner.TabIndex = 7;
            this.lable_banner.Text = "Gideon";
            this.lable_banner.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // txt_rePass
            // 
            this.txt_rePass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_rePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rePass.Location = new System.Drawing.Point(93, 233);
            this.txt_rePass.Name = "txt_rePass";
            this.txt_rePass.PasswordChar = 'x';
            this.txt_rePass.Size = new System.Drawing.Size(227, 38);
            this.txt_rePass.TabIndex = 2;
            this.txt_rePass.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_rePass.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txt_rePass.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // pic_rePass
            // 
            this.pic_rePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_rePass.Location = new System.Drawing.Point(57, 237);
            this.pic_rePass.Name = "pic_rePass";
            this.pic_rePass.Size = new System.Drawing.Size(30, 30);
            this.pic_rePass.TabIndex = 1;
            this.pic_rePass.TabStop = false;
            this.pic_rePass.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // pic_password
            // 
            this.pic_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_password.Location = new System.Drawing.Point(57, 193);
            this.pic_password.Name = "pic_password";
            this.pic_password.Size = new System.Drawing.Size(30, 30);
            this.pic_password.TabIndex = 1;
            this.pic_password.TabStop = false;
            this.pic_password.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // pic_user
            // 
            this.pic_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_user.Location = new System.Drawing.Point(57, 149);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(30, 30);
            this.pic_user.TabIndex = 0;
            this.pic_user.TabStop = false;
            this.pic_user.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            // 
            // LoginForStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.lable_banner);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_rePass);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pic_rePass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pic_password);
            this.Controls.Add(this.pic_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForStart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForStart_FormClosing);
            this.Load += new System.EventHandler(this.LoginForStart_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForStart_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Login_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_rePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.PictureBox pic_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lable_banner;
        private System.Windows.Forms.PictureBox pic_rePass;
        private System.Windows.Forms.TextBox txt_rePass;
    }
}