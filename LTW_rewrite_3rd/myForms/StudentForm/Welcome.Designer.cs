
namespace LTW_rewrite_3rd.myForms.StudentForm
{
    partial class Welcome
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
            this.label_bannẻ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_bannẻ
            // 
            this.label_bannẻ.AutoSize = true;
            this.label_bannẻ.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bannẻ.Location = new System.Drawing.Point(268, 204);
            this.label_bannẻ.Name = "label_bannẻ";
            this.label_bannẻ.Size = new System.Drawing.Size(247, 76);
            this.label_bannẻ.TabIndex = 0;
            this.label_bannẻ.Text = "Gideon";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(806, 661);
            this.Controls.Add(this.label_bannẻ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bannẻ;
    }
}