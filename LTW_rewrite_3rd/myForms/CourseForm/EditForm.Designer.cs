
namespace LTW_rewrite_3rd.myForms.CourseForm
{
    partial class EditForm
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label_start = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label_end = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.panel_info2 = new System.Windows.Forms.Panel();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.panel_info = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_buttons.SuspendLayout();
            this.panel_info2.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(15, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(170, 50);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_cancel);
            this.panel_buttons.Controls.Add(this.btn_edit);
            this.panel_buttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_buttons.Location = new System.Drawing.Point(364, 479);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(429, 90);
            this.panel_buttons.TabIndex = 8;
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
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(252, 14);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(175, 31);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "Ngày bắt đầu";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(9, 116);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(323, 31);
            this.txt_name.TabIndex = 1;
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(246, 89);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(181, 31);
            this.label_end.TabIndex = 2;
            this.label_end.Text = "Ngày kết thúc";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(9, 48);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(323, 31);
            this.txt_id.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(3, 14);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(168, 31);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Mã khóa học";
            // 
            // panel_info2
            // 
            this.panel_info2.Controls.Add(this.date_end);
            this.panel_info2.Controls.Add(this.date_start);
            this.panel_info2.Controls.Add(this.label_end);
            this.panel_info2.Controls.Add(this.label_start);
            this.panel_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_info2.Location = new System.Drawing.Point(364, 62);
            this.panel_info2.Name = "panel_info2";
            this.panel_info2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_info2.Size = new System.Drawing.Size(430, 400);
            this.panel_info2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.date_end.CustomFormat = "dd/MMM/yyyy";
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_end.Location = new System.Drawing.Point(104, 123);
            this.date_end.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date_end.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_end.Name = "dateTimePicker1";
            this.date_end.Size = new System.Drawing.Size(317, 38);
            this.date_end.TabIndex = 5;
            this.date_end.Value = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            // 
            // date_start
            // 
            this.date_start.CustomFormat = "dd/MMM/yyyy";
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_start.Location = new System.Drawing.Point(104, 48);
            this.date_start.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date_start.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(317, 38);
            this.date_start.TabIndex = 5;
            this.date_start.Value = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.txt_name);
            this.panel_info.Controls.Add(this.label_name);
            this.panel_info.Controls.Add(this.txt_id);
            this.panel_info.Controls.Add(this.label_id);
            this.panel_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_info.Location = new System.Drawing.Point(12, 62);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(346, 400);
            this.panel_info.TabIndex = 6;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(3, 82);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(178, 31);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Tên khóa học";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(806, 631);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.panel_info2);
            this.Controls.Add(this.panel_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.panel_buttons.ResumeLayout(false);
            this.panel_info2.ResumeLayout(false);
            this.panel_info2.PerformLayout();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Panel panel_info2;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label label_name;
    }
}