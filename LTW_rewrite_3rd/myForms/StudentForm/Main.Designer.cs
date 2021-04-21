
namespace LTW_rewrite_3rd.myForms.StudentForm
{
    partial class Main
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
            this.panel_leftmenu = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_sinhVien = new System.Windows.Forms.Button();
            this.pic_banner = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_leftmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_leftmenu
            // 
            this.panel_leftmenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_leftmenu.Controls.Add(this.btn_Logout);
            this.panel_leftmenu.Controls.Add(this.btn_sinhVien);
            this.panel_leftmenu.Controls.Add(this.pic_banner);
            this.panel_leftmenu.Location = new System.Drawing.Point(0, 0);
            this.panel_leftmenu.Name = "panel_leftmenu";
            this.panel_leftmenu.Size = new System.Drawing.Size(175, 675);
            this.panel_leftmenu.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(0, 636);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(175, 25);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_sinhVien
            // 
            this.btn_sinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sinhVien.FlatAppearance.BorderSize = 0;
            this.btn_sinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sinhVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sinhVien.Location = new System.Drawing.Point(0, 175);
            this.btn_sinhVien.Name = "btn_sinhVien";
            this.btn_sinhVien.Size = new System.Drawing.Size(175, 50);
            this.btn_sinhVien.TabIndex = 1;
            this.btn_sinhVien.Text = "Sinh Viên";
            this.btn_sinhVien.UseVisualStyleBackColor = true;
            this.btn_sinhVien.Click += new System.EventHandler(this.btn_sinhVien_Click);
            // 
            // pic_banner
            // 
            this.pic_banner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_banner.Location = new System.Drawing.Point(0, 0);
            this.pic_banner.Name = "pic_banner";
            this.pic_banner.Size = new System.Drawing.Size(175, 175);
            this.pic_banner.TabIndex = 0;
            this.pic_banner.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_main.Location = new System.Drawing.Point(178, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(806, 661);
            this.panel_main.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_leftmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gideon";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_leftmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_leftmenu;
        private System.Windows.Forms.PictureBox pic_banner;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_sinhVien;
        private System.Windows.Forms.Panel panel_main;
    }
}