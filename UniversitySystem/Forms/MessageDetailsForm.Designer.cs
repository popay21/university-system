namespace UniversitySystem.Forms
{
    partial class MessageDetailsForm
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
            this.chkFavorite = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkFavorite
            // 
            this.chkFavorite.AutoSize = true;
            this.chkFavorite.Location = new System.Drawing.Point(36, 65);
            this.chkFavorite.Name = "chkFavorite";
            this.chkFavorite.Size = new System.Drawing.Size(80, 17);
            this.chkFavorite.TabIndex = 11;
            this.chkFavorite.Text = "checkBox1";
            this.chkFavorite.UseVisualStyleBackColor = true;
            this.chkFavorite.Click += new System.EventHandler(this.chkFavorite_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(694, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "סגור";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(35, 88);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(734, 279);
            this.txtContent.TabIndex = 9;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(32, 40);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(35, 13);
            this.lblSender.TabIndex = 8;
            this.lblSender.Text = "מאת :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(32, 53);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "תאריך :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "פרטי הודעה";
            // 
            // MessageDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkFavorite);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Name = "MessageDetailsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "פרטי הודעה";
            this.Load += new System.EventHandler(this.MessageDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFavorite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
    }
}