
namespace LTW_rewrite_3rd.myForms.StudentForm
{
    partial class AddForm
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
            this.panel_info = new System.Windows.Forms.Panel();
            this.panel_gender = new System.Windows.Forms.Panel();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.label_gioiTinh = new System.Windows.Forms.Label();
            this.date_birthday = new System.Windows.Forms.DateTimePicker();
            this.label_birthday = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label_firsname = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label_lastname = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.panel_info2 = new System.Windows.Forms.Panel();
            this.btn_avatar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel_info.SuspendLayout();
            this.panel_gender.SuspendLayout();
            this.panel_info2.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.panel_gender);
            this.panel_info.Controls.Add(this.date_birthday);
            this.panel_info.Controls.Add(this.label_birthday);
            this.panel_info.Controls.Add(this.txt_firstname);
            this.panel_info.Controls.Add(this.label_firsname);
            this.panel_info.Controls.Add(this.txt_lastname);
            this.panel_info.Controls.Add(this.label_lastname);
            this.panel_info.Controls.Add(this.txt_id);
            this.panel_info.Controls.Add(this.label_id);
            this.panel_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_info.Location = new System.Drawing.Point(12, 96);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(346, 400);
            this.panel_info.TabIndex = 0;
            // 
            // panel_gender
            // 
            this.panel_gender.Controls.Add(this.rad_female);
            this.panel_gender.Controls.Add(this.rad_male);
            this.panel_gender.Controls.Add(this.label_gioiTinh);
            this.panel_gender.Location = new System.Drawing.Point(0, 288);
            this.panel_gender.Name = "panel_gender";
            this.panel_gender.Size = new System.Drawing.Size(346, 100);
            this.panel_gender.TabIndex = 5;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(137, 34);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(67, 35);
            this.rad_female.TabIndex = 1;
            this.rad_female.Text = "Nữ";
            this.rad_female.UseVisualStyleBackColor = true;
            this.rad_female.Click += new System.EventHandler(this.rad_male_Click);
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Checked = true;
            this.rad_male.Location = new System.Drawing.Point(40, 34);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(89, 35);
            this.rad_male.TabIndex = 1;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Nam";
            this.rad_male.UseVisualStyleBackColor = true;
            this.rad_male.Click += new System.EventHandler(this.rad_male_Click);
            // 
            // label_gioiTinh
            // 
            this.label_gioiTinh.AutoSize = true;
            this.label_gioiTinh.Location = new System.Drawing.Point(3, 0);
            this.label_gioiTinh.Name = "label_gioiTinh";
            this.label_gioiTinh.Size = new System.Drawing.Size(113, 31);
            this.label_gioiTinh.TabIndex = 0;
            this.label_gioiTinh.Text = "Giới tính";
            // 
            // date_birthday
            // 
            this.date_birthday.CustomFormat = "dd/MMM/yyyy";
            this.date_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_birthday.Location = new System.Drawing.Point(15, 243);
            this.date_birthday.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date_birthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Size = new System.Drawing.Size(317, 38);
            this.date_birthday.TabIndex = 4;
            this.date_birthday.Value = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Location = new System.Drawing.Point(9, 208);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(135, 31);
            this.label_birthday.TabIndex = 3;
            this.label_birthday.Text = "Ngày sinh";
            // 
            // txt_firstname
            // 
            this.txt_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_firstname.Location = new System.Drawing.Point(9, 170);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(323, 31);
            this.txt_firstname.TabIndex = 2;
            // 
            // label_firsname
            // 
            this.label_firsname.AutoSize = true;
            this.label_firsname.Location = new System.Drawing.Point(3, 136);
            this.label_firsname.Name = "label_firsname";
            this.label_firsname.Size = new System.Drawing.Size(61, 31);
            this.label_firsname.TabIndex = 0;
            this.label_firsname.Text = "Tên";
            // 
            // txt_lastname
            // 
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname.Location = new System.Drawing.Point(9, 102);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(323, 31);
            this.txt_lastname.TabIndex = 1;
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(3, 68);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(49, 31);
            this.label_lastname.TabIndex = 0;
            this.label_lastname.Text = "Họ";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Location = new System.Drawing.Point(9, 34);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(323, 31);
            this.txt_id.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(3, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(201, 31);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Mã số sinh viên";
            // 
            // panel_info2
            // 
            this.panel_info2.Controls.Add(this.btn_avatar);
            this.panel_info2.Controls.Add(this.textBox1);
            this.panel_info2.Controls.Add(this.label_address);
            this.panel_info2.Controls.Add(this.txt_phone);
            this.panel_info2.Controls.Add(this.label_phone);
            this.panel_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_info2.Location = new System.Drawing.Point(364, 96);
            this.panel_info2.Name = "panel_info2";
            this.panel_info2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_info2.Size = new System.Drawing.Size(430, 400);
            this.panel_info2.TabIndex = 1;
            // 
            // btn_avatar
            // 
            this.btn_avatar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_avatar.FlatAppearance.BorderSize = 0;
            this.btn_avatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avatar.Location = new System.Drawing.Point(271, 245);
            this.btn_avatar.Name = "btn_avatar";
            this.btn_avatar.Size = new System.Drawing.Size(150, 150);
            this.btn_avatar.TabIndex = 4;
            this.btn_avatar.Text = "Click để tải ảnh lên";
            this.btn_avatar.UseVisualStyleBackColor = false;
            this.btn_avatar.Click += new System.EventHandler(this.btn_avatar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(15, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 102);
            this.textBox1.TabIndex = 3;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(330, 103);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(97, 31);
            this.label_address.TabIndex = 2;
            this.label_address.Text = "Địa chỉ";
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone.Location = new System.Drawing.Point(15, 61);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(406, 31);
            this.txt_phone.TabIndex = 1;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(256, 14);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(171, 31);
            this.label_phone.TabIndex = 0;
            this.label_phone.Text = "Số điện thoại";
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_cancel);
            this.panel_buttons.Controls.Add(this.btn_add);
            this.panel_buttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_buttons.Location = new System.Drawing.Point(364, 513);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(429, 90);
            this.panel_buttons.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(170, 50);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(251, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(170, 50);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(806, 631);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.panel_info2);
            this.Controls.Add(this.panel_info);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel_gender.ResumeLayout(false);
            this.panel_gender.PerformLayout();
            this.panel_info2.ResumeLayout(false);
            this.panel_info2.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label label_firsname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.DateTimePicker date_birthday;
        private System.Windows.Forms.Panel panel_gender;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.Label label_gioiTinh;
        private System.Windows.Forms.Panel panel_info2;
        private System.Windows.Forms.Button btn_avatar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
    }
}