namespace UniversitySystem.Forms
{
    partial class RegisterCourseForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lstAvailableCourses = new System.Windows.Forms.ListBox();
            this.lblAvailableCourses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 220);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 30);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "הירשם לקורס";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lstAvailableCourses
            // 
            this.lstAvailableCourses.FormattingEnabled = true;
            this.lstAvailableCourses.Location = new System.Drawing.Point(12, 30);
            this.lstAvailableCourses.Name = "lstAvailableCourses";
            this.lstAvailableCourses.Size = new System.Drawing.Size(360, 173);
            this.lstAvailableCourses.TabIndex = 5;
            // 
            // lblAvailableCourses
            // 
            this.lblAvailableCourses.AutoSize = true;
            this.lblAvailableCourses.Location = new System.Drawing.Point(12, 10);
            this.lblAvailableCourses.Name = "lblAvailableCourses";
            this.lblAvailableCourses.Size = new System.Drawing.Size(84, 13);
            this.lblAvailableCourses.TabIndex = 4;
            this.lblAvailableCourses.Text = "קורסים זמינים:";
            // 
            // RegisterCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lstAvailableCourses);
            this.Controls.Add(this.lblAvailableCourses);
            this.Name = "RegisterCourseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "הרשמה לקורס";
            this.Load += new System.EventHandler(this.RegisterCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lstAvailableCourses;
        private System.Windows.Forms.Label lblAvailableCourses;
    }
}