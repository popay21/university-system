namespace UniversitySystem.Forms
{
    partial class ManageGradesForm
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
            this.lvStudents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvStudents.FullRowSelect = true;
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(12, 40);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(460, 250);
            this.lvStudents.TabIndex = 6;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ציון";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "מספר סטודנט";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שם הסטודנט";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 150;
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.AutoSize = true;
            this.lblCourseInfo.Location = new System.Drawing.Point(12, 10);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(121, 13);
            this.lblCourseInfo.TabIndex = 5;
            this.lblCourseInfo.Text = "פרטי הקורס יוצגו כאן";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(372, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "סגור";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.Location = new System.Drawing.Point(122, 300);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateGrade.TabIndex = 8;
            this.btnUpdateGrade.Text = "עדכן ציון";
            this.btnUpdateGrade.UseVisualStyleBackColor = true;
            this.btnUpdateGrade.Click += new System.EventHandler(this.btnUpdateGrade_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(12, 300);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 7;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // ManageGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.lblCourseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateGrade);
            this.Controls.Add(this.txtGrade);
            this.Name = "ManageGradesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ניהול ציונים";
            this.Load += new System.EventHandler(this.ManageGradesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblCourseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.TextBox txtGrade;
    }
}