namespace UniversitySystem.Forms
{
    partial class AddEditCourseForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbLecturer = new System.Windows.Forms.ComboBox();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbLecturer
            // 
            this.cmbLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLecturer.FormattingEnabled = true;
            this.cmbLecturer.Location = new System.Drawing.Point(147, 104);
            this.cmbLecturer.Name = "cmbLecturer";
            this.cmbLecturer.Size = new System.Drawing.Size(200, 21);
            this.cmbLecturer.TabIndex = 16;
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Location = new System.Drawing.Point(37, 107);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(37, 13);
            this.lblLecturer.TabIndex = 15;
            this.lblLecturer.Text = "מרצה:";
            // 
            // nudCredits
            // 
            this.nudCredits.Location = new System.Drawing.Point(147, 74);
            this.nudCredits.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCredits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCredits.Name = "nudCredits";
            this.nudCredits.Size = new System.Drawing.Size(60, 20);
            this.nudCredits.TabIndex = 14;
            this.nudCredits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(37, 77);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(73, 13);
            this.lblCredits.TabIndex = 13;
            this.lblCredits.Text = "נקודות זכות:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(147, 44);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(200, 20);
            this.txtCourseName.TabIndex = 12;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(37, 47);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(61, 13);
            this.lblCourseName.TabIndex = 11;
            this.lblCourseName.Text = "שם הקורס:";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(147, 14);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(200, 20);
            this.txtCourseCode.TabIndex = 10;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(37, 17);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(57, 13);
            this.lblCourseCode.TabIndex = 9;
            this.lblCourseCode.Text = "קוד קורס:";
            // 
            // AddEditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbLecturer);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.nudCredits);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.Name = "AddEditCourseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "הוספת/עריכת קורס";
 //           this.Load += new System.EventHandler(this.AddEditCourseForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbLecturer;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.NumericUpDown nudCredits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseCode;
    }
}