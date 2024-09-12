namespace UniversitySystem.Forms
{
    partial class ComposeMessageForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cmbRecipient = new System.Windows.Forms.ComboBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(208, 221);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 33);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "שלח";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(47, 116);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(292, 76);
            this.txtContent.TabIndex = 13;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(47, 77);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(292, 20);
            this.txtSubject.TabIndex = 12;
            // 
            // cmbRecipient
            // 
            this.cmbRecipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecipient.FormattingEnabled = true;
            this.cmbRecipient.Location = new System.Drawing.Point(47, 33);
            this.cmbRecipient.Name = "cmbRecipient";
            this.cmbRecipient.Size = new System.Drawing.Size(292, 21);
            this.cmbRecipient.TabIndex = 11;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(16, 100);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(34, 13);
            this.lblContent.TabIndex = 10;
            this.lblContent.Text = "תוכן:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(10, 57);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(40, 13);
            this.lblSubject.TabIndex = 9;
            this.lblSubject.Text = " נושא:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(22, 17);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 13);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = " אל:";
            // 
            // ComposeMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.cmbRecipient);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Name = "ComposeMessageForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "שליחת הודעה חדשה";
      //      this.Load += new System.EventHandler(this.ComposeMessageForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cmbRecipient;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTo;
    }
}