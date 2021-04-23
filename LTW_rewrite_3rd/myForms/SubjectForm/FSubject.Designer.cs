
namespace LTW_rewrite_3rd.myForms.SubjectForm
{
    partial class FSubject
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
            this.panel_topmenu = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel_list = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel_topmenu.SuspendLayout();
            this.panel_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_topmenu
            // 
            this.panel_topmenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_topmenu.Controls.Add(this.btn_filter);
            this.panel_topmenu.Controls.Add(this.btn_search);
            this.panel_topmenu.Controls.Add(this.txt_search);
            this.panel_topmenu.Controls.Add(this.btn_download);
            this.panel_topmenu.Controls.Add(this.btn_edit);
            this.panel_topmenu.Controls.Add(this.btn_delete);
            this.panel_topmenu.Controls.Add(this.btn_add);
            this.panel_topmenu.Controls.Add(this.btn_home);
            this.panel_topmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topmenu.Location = new System.Drawing.Point(0, 0);
            this.panel_topmenu.Name = "panel_topmenu";
            this.panel_topmenu.Size = new System.Drawing.Size(806, 30);
            this.panel_topmenu.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(278, 0);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(300, 29);
            this.txt_search.TabIndex = 0;
            // 
            // panel_list
            // 
            this.panel_list.Controls.Add(this.panel1);
            this.panel_list.Controls.Add(this.dgv_list);
            this.panel_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_list.Location = new System.Drawing.Point(0, 30);
            this.panel_list.Name = "panel_list";
            this.panel_list.Size = new System.Drawing.Size(806, 631);
            this.panel_list.TabIndex = 1;
            // 
            // dgv_list
            // 
            this.dgv_list.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_list.Location = new System.Drawing.Point(0, 0);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.Size = new System.Drawing.Size(806, 631);
            this.dgv_list.TabIndex = 0;
            this.dgv_list.TabStop = false;
            this.dgv_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listStudent_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(527, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 232);
            this.panel1.TabIndex = 1;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_filter.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.filter_and_sort_24px;
            this.btn_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filter.FlatAppearance.BorderSize = 0;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Location = new System.Drawing.Point(608, 0);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(30, 30);
            this.btn_filter.TabIndex = 4;
            this.btn_filter.TabStop = false;
            this.btn_filter.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.search_icon_24px_512;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(578, 0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(30, 30);
            this.btn_search.TabIndex = 4;
            this.btn_search.TabStop = false;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_download
            // 
            this.btn_download.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.download_24px;
            this.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_download.FlatAppearance.BorderSize = 0;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Location = new System.Drawing.Point(90, 0);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(30, 30);
            this.btn_download.TabIndex = 3;
            this.btn_download.TabStop = false;
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.edit_icon_24px_512;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(60, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(30, 30);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.TabStop = false;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.remove_bin_512;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(776, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(30, 30);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.TabStop = false;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.add_icon_24px_512;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(30, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(30, 30);
            this.btn_add.TabIndex = 1;
            this.btn_add.TabStop = false;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_home
            // 
            this.btn_home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_home.BackgroundImage = global::LTW_rewrite_3rd.Properties.Resources.home_30px;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(30, 30);
            this.btn_home.TabIndex = 0;
            this.btn_home.TabStop = false;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 3;
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(806, 661);
            this.Controls.Add(this.panel_list);
            this.Controls.Add(this.panel_topmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSubject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.FSubject_Load);
            this.panel_topmenu.ResumeLayout(false);
            this.panel_topmenu.PerformLayout();
            this.panel_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_topmenu;
        private System.Windows.Forms.Panel panel_list;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}