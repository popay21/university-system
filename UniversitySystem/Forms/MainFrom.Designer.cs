namespace UniversitySystem.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.lvSearchResults = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.trkFontSize = new System.Windows.Forms.TrackBar();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialogBackground = new System.Windows.Forms.ColorDialog();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSpecificInfo3 = new System.Windows.Forms.Label();
            this.lblSpecificInfo2 = new System.Windows.Forms.Label();
            this.lblSpecificInfo1 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lstRecentMessages = new System.Windows.Forms.ListBox();
            this.picUserImage = new System.Windows.Forms.PictureBox();
            this.Age = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtNewMessage = new System.Windows.Forms.TextBox();
            this.btnSortBySenderImportance = new System.Windows.Forms.Button();
            this.btnSortByFavorite = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.lvAllMessages = new System.Windows.Forms.ListView();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.btnManageGrades = new System.Windows.Forms.Button();
            this.btnRegisterCourse = new System.Windows.Forms.Button();
            this.lvCourses = new System.Windows.Forms.ListView();
            this.tabSearch.SuspendLayout();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).BeginInit();
            this.tabMessages.SuspendLayout();
            this.tabCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(400, 270);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(120, 30);
            this.btnEditCourse.TabIndex = 4;
            this.btnEditCourse.Text = "עריכת קורס";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Visible = false;
//            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "קוד קורס";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "שם הקורס";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "מרצה";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "נקודות זכות";
            this.columnHeader4.Width = 100;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.lvSearchResults);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.cmbSearchType);
            this.tabSearch.Controls.Add(this.txtSearchTerm);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(792, 400);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "חיפוש אנשים";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // lvSearchResults
            // 
            this.lvSearchResults.HideSelection = false;
            this.lvSearchResults.Location = new System.Drawing.Point(286, 243);
            this.lvSearchResults.Name = "lvSearchResults";
            this.lvSearchResults.Size = new System.Drawing.Size(274, 97);
            this.lvSearchResults.TabIndex = 3;
            this.lvSearchResults.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 203);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = true;
          //  this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "סטודנט",
            "מרצה",
            "ראש מחלקה"});
            this.cmbSearchType.Location = new System.Drawing.Point(362, 176);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchType.TabIndex = 1;
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(286, 127);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(274, 20);
            this.txtSearchTerm.TabIndex = 0;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.btnChangeColor);
            this.tabOptions.Controls.Add(this.trkFontSize);
            this.tabOptions.Controls.Add(this.chkDarkMode);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(792, 400);
            this.tabOptions.TabIndex = 4;
            this.tabOptions.Text = "אפשרויות";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(296, 230);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "צבע טקסט";
            this.btnChangeColor.UseVisualStyleBackColor = true;
           // this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click_1);
            // 
            // trkFontSize
            // 
            this.trkFontSize.Location = new System.Drawing.Point(296, 162);
            this.trkFontSize.Minimum = 1;
            this.trkFontSize.Name = "trkFontSize";
            this.trkFontSize.Size = new System.Drawing.Size(104, 45);
            this.trkFontSize.TabIndex = 1;
            this.trkFontSize.Value = 1;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(296, 106);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(80, 17);
            this.chkDarkMode.TabIndex = 0;
            this.chkDarkMode.Text = "checkBox1";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAbout,
            this.mnuItemHelp,
            this.mnuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(48, 20);
            this.mnuItemAbout.Text = "אודות";
           // this.mnuItemAbout.Click += new System.EventHandler(this.mnuItemAbout_Click);
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(45, 20);
            this.mnuItemHelp.Text = "עזרה";
            //this.mnuItemHelp.Click += new System.EventHandler(this.mnuItemHelp_Click);
            // 
            // mnuItemLogout
            // 
            this.mnuItemLogout.Name = "mnuItemLogout";
            this.mnuItemLogout.Size = new System.Drawing.Size(58, 20);
            this.mnuItemLogout.Text = "התנתק";
            //this.mnuItemLogout.Click += new System.EventHandler(this.mnuItemLogout_Click);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(118, 17);
            this.lblStatusUser.Text = "toolStripStatusLabel2";
            // 
            // colorDialogBackground
            // 
            this.colorDialogBackground.Color = System.Drawing.Color.DimGray;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(270, 270);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(120, 30);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "הוספת קורס";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Visible = false;
            //this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPersonalInfo);
            this.tabControlMain.Controls.Add(this.tabMessages);
            this.tabControlMain.Controls.Add(this.tabCourses);
            this.tabControlMain.Controls.Add(this.tabSearch);
            this.tabControlMain.Controls.Add(this.tabOptions);
            this.tabControlMain.Location = new System.Drawing.Point(0, 26);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 426);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.button1);
            this.tabPersonalInfo.Controls.Add(this.lblSpecificInfo3);
            this.tabPersonalInfo.Controls.Add(this.lblSpecificInfo2);
            this.tabPersonalInfo.Controls.Add(this.lblSpecificInfo1);
            this.tabPersonalInfo.Controls.Add(this.lblUserType);
            this.tabPersonalInfo.Controls.Add(this.lblLastLogin);
            this.tabPersonalInfo.Controls.Add(this.lblEmail);
            this.tabPersonalInfo.Controls.Add(this.lstRecentMessages);
            this.tabPersonalInfo.Controls.Add(this.picUserImage);
            this.tabPersonalInfo.Controls.Add(this.Age);
            this.tabPersonalInfo.Controls.Add(this.lblId);
            this.tabPersonalInfo.Controls.Add(this.lblName);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(792, 400);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "אזור אישי";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "עדכן פרטים";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // lblSpecificInfo3
            // 
            this.lblSpecificInfo3.AutoSize = true;
            this.lblSpecificInfo3.Location = new System.Drawing.Point(12, 225);
            this.lblSpecificInfo3.Name = "lblSpecificInfo3";
            this.lblSpecificInfo3.Size = new System.Drawing.Size(13, 13);
            this.lblSpecificInfo3.TabIndex = 10;
            this.lblSpecificInfo3.Text = "3";
            // 
            // lblSpecificInfo2
            // 
            this.lblSpecificInfo2.AutoSize = true;
            this.lblSpecificInfo2.Location = new System.Drawing.Point(12, 212);
            this.lblSpecificInfo2.Name = "lblSpecificInfo2";
            this.lblSpecificInfo2.Size = new System.Drawing.Size(13, 13);
            this.lblSpecificInfo2.TabIndex = 9;
            this.lblSpecificInfo2.Text = "2";
            // 
            // lblSpecificInfo1
            // 
            this.lblSpecificInfo1.AutoSize = true;
            this.lblSpecificInfo1.Location = new System.Drawing.Point(12, 199);
            this.lblSpecificInfo1.Name = "lblSpecificInfo1";
            this.lblSpecificInfo1.Size = new System.Drawing.Size(13, 13);
            this.lblSpecificInfo1.TabIndex = 8;
            this.lblSpecificInfo1.Text = "1";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(12, 186);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(70, 13);
            this.lblUserType.TabIndex = 7;
            this.lblUserType.Text = "סוג משתמש:";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Location = new System.Drawing.Point(12, 136);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(108, 13);
            this.lblLastLogin.TabIndex = 6;
            this.lblLastLogin.Text = "תאריך כניסה אחרון";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "אימייל";
            // 
            // lstRecentMessages
            // 
            this.lstRecentMessages.FormattingEnabled = true;
            this.lstRecentMessages.Location = new System.Drawing.Point(338, 179);
            this.lstRecentMessages.Name = "lstRecentMessages";
            this.lstRecentMessages.Size = new System.Drawing.Size(120, 95);
            this.lstRecentMessages.TabIndex = 4;
            // 
            // picUserImage
            // 
            this.picUserImage.Location = new System.Drawing.Point(15, 44);
            this.picUserImage.Name = "picUserImage";
            this.picUserImage.Size = new System.Drawing.Size(100, 50);
            this.picUserImage.TabIndex = 3;
            this.picUserImage.TabStop = false;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(12, 110);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(25, 13);
            this.Age.TabIndex = 2;
            this.Age.Text = "גיל";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 97);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "תעודת זהות";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "שם משתמש";
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.btnSendMessage);
            this.tabMessages.Controls.Add(this.txtNewMessage);
            this.tabMessages.Controls.Add(this.btnSortBySenderImportance);
            this.tabMessages.Controls.Add(this.btnSortByFavorite);
            this.tabMessages.Controls.Add(this.btnSortByDate);
            this.tabMessages.Controls.Add(this.lvAllMessages);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(792, 400);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "הודעות";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(338, 300);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(124, 23);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "שליחת הודעה";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // txtNewMessage
            // 
            this.txtNewMessage.Location = new System.Drawing.Point(281, 274);
            this.txtNewMessage.Name = "txtNewMessage";
            this.txtNewMessage.Size = new System.Drawing.Size(248, 20);
            this.txtNewMessage.TabIndex = 4;
            // 
            // btnSortBySenderImportance
            // 
            this.btnSortBySenderImportance.Location = new System.Drawing.Point(171, 210);
            this.btnSortBySenderImportance.Name = "btnSortBySenderImportance";
            this.btnSortBySenderImportance.Size = new System.Drawing.Size(75, 23);
            this.btnSortBySenderImportance.TabIndex = 3;
            this.btnSortBySenderImportance.Text = "חשיבות";
            this.btnSortBySenderImportance.UseVisualStyleBackColor = true;
          //  this.btnSortBySenderImportance.Click += new System.EventHandler(this.btnSortBySenderImportance_Click);
            // 
            // btnSortByFavorite
            // 
            this.btnSortByFavorite.Location = new System.Drawing.Point(362, 210);
            this.btnSortByFavorite.Name = "btnSortByFavorite";
            this.btnSortByFavorite.Size = new System.Drawing.Size(75, 23);
            this.btnSortByFavorite.TabIndex = 2;
            this.btnSortByFavorite.Text = "מועדף";
            this.btnSortByFavorite.UseVisualStyleBackColor = true;
          //  this.btnSortByFavorite.Click += new System.EventHandler(this.btnSortByFavorite_Click);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Location = new System.Drawing.Point(535, 210);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(75, 23);
            this.btnSortByDate.TabIndex = 1;
            this.btnSortByDate.Text = "תאריך";
            this.btnSortByDate.UseVisualStyleBackColor = true;
         //   this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // lvAllMessages
            // 
            this.lvAllMessages.HideSelection = false;
            this.lvAllMessages.Location = new System.Drawing.Point(171, 81);
            this.lvAllMessages.Name = "lvAllMessages";
            this.lvAllMessages.Size = new System.Drawing.Size(439, 97);
            this.lvAllMessages.TabIndex = 0;
            this.lvAllMessages.UseCompatibleStateImageBehavior = false;
            this.lvAllMessages.Click += new System.EventHandler(this.LvAllMessages_DoubleClick);
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.btnEditCourse);
            this.tabCourses.Controls.Add(this.btnAddCourse);
            this.tabCourses.Controls.Add(this.btnManageGrades);
            this.tabCourses.Controls.Add(this.btnRegisterCourse);
            this.tabCourses.Controls.Add(this.lvCourses);
            this.tabCourses.Location = new System.Drawing.Point(4, 22);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(10);
            this.tabCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCourses.Size = new System.Drawing.Size(792, 400);
            this.tabCourses.TabIndex = 2;
            this.tabCourses.Text = "קורסים";
            this.tabCourses.UseVisualStyleBackColor = true;
          //  this.tabCourses.Click += new System.EventHandler(this.tabCourses_Click);
            // 
            // btnManageGrades
            // 
            this.btnManageGrades.Location = new System.Drawing.Point(140, 270);
            this.btnManageGrades.Name = "btnManageGrades";
            this.btnManageGrades.Size = new System.Drawing.Size(120, 30);
            this.btnManageGrades.TabIndex = 2;
            this.btnManageGrades.Text = "ניהול ציונים";
            this.btnManageGrades.UseVisualStyleBackColor = true;
            this.btnManageGrades.Visible = false;
          //  this.btnManageGrades.Click += new System.EventHandler(this.btnManageGrades_Click);
            // 
            // btnRegisterCourse
            // 
            this.btnRegisterCourse.Location = new System.Drawing.Point(10, 270);
            this.btnRegisterCourse.Name = "btnRegisterCourse";
            this.btnRegisterCourse.Size = new System.Drawing.Size(120, 30);
            this.btnRegisterCourse.TabIndex = 1;
            this.btnRegisterCourse.Text = "הרשמה לקורס";
            this.btnRegisterCourse.UseVisualStyleBackColor = true;
            this.btnRegisterCourse.Visible = false;
            this.btnRegisterCourse.Click += new System.EventHandler(this.BtnRegisterCourse_Click);
            // 
            // lvCourses
            // 
            this.lvCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvCourses.FullRowSelect = true;
            this.lvCourses.HideSelection = false;
            this.lvCourses.Location = new System.Drawing.Point(10, 10);
            this.lvCourses.Name = "lvCourses";
            this.lvCourses.Size = new System.Drawing.Size(772, 250);
            this.lvCourses.TabIndex = 0;
            this.lvCourses.UseCompatibleStateImageBehavior = false;
            this.lvCourses.View = System.Windows.Forms.View.Details;
        //    this.lvCourses.SelectedIndexChanged += new System.EventHandler(this.lvCourses_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).EndInit();
            this.tabMessages.ResumeLayout(false);
            this.tabMessages.PerformLayout();
            this.tabCourses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.ListView lvSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.TrackBar trkFontSize;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogout;
        private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ColorDialog colorDialogBackground;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSpecificInfo3;
        private System.Windows.Forms.Label lblSpecificInfo2;
        private System.Windows.Forms.Label lblSpecificInfo1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ListBox lstRecentMessages;
        private System.Windows.Forms.PictureBox picUserImage;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtNewMessage;
        private System.Windows.Forms.Button btnSortBySenderImportance;
        private System.Windows.Forms.Button btnSortByFavorite;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.ListView lvAllMessages;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.Button btnManageGrades;
        private System.Windows.Forms.Button btnRegisterCourse;
        private System.Windows.Forms.ListView lvCourses;
    }
}