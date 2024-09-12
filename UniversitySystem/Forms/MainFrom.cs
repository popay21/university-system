
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UniversitySystem.Models;
using System.Drawing;

namespace UniversitySystem.Forms
{
    public partial class MainForm : Form
    {
        private Person currentUser;

        public MainForm(Person user)
        {
            InitializeComponent();
            currentUser = user;
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.Text = $"מערכת אוניברסיטאית - {currentUser.Name}";
            lblStatusUser.Text = $"משתמש מחובר: {currentUser.Name}";

            LoadPersonalInfo();
            SetupMessagesTab();
            SetupCoursesTab();
            SetupSearchTab();
            SetupOptionsTab();
        }

        #region Personal Info Tab

        private void LoadPersonalInfo()
        {
            lblName.Text = $"שם: {currentUser.Name}";
            lblId.Text = $"ת.ז.: {currentUser.Id}";
            lblEmail.Text = $"אימייל: {currentUser.Email}";
            lblLastLogin.Text = $"כניסה אחרונה: {currentUser.LastLoginDate:dd/MM/yyyy HH:mm:ss}";

            LoadUserImage();
            LoadRecentMessages();
            LoadUserSpecificInfo();
        }

        private void LoadUserSpecificInfo()
        {
            if (currentUser is Student student)
            {
                lblUserType.Text = "סוג משתמש: סטודנט";
                lblSpecificInfo1.Text = $"מספר סטודנט: {student.StudentNumber}";
                lblSpecificInfo2.Text = $"מסלול לימודים: {student.Program}";
                lblSpecificInfo3.Text = $"נקודות זכות: {student.Credits}";
            }
            else if (currentUser is Lecturer lecturer)
            {
                lblUserType.Text = "סוג משתמש: מרצה";
                lblSpecificInfo1.Text = $"מספר עובד: {lecturer.EmployeeNumber}";
                lblSpecificInfo2.Text = $"מחלקה: {lecturer.Department}";
                lblSpecificInfo3.Text = $"דירוג: {lecturer.Rating}";
            }
            else if (currentUser is DepartmentHead head)
            {
                lblUserType.Text = "סוג משתמש: ראש מחלקה";
                lblSpecificInfo1.Text = $"מספר עובד: {head.EmployeeNumber}";
                lblSpecificInfo2.Text = $"מחלקה: {head.Department}";
                lblSpecificInfo3.Text = $"מספר כפיפים: {head.Subordinates.Count}";
            }
        }

        private void LoadUserImage()
        {
            if (!string.IsNullOrEmpty(currentUser.ImagePath) && File.Exists(currentUser.ImagePath))
            {
                try
                {
                    using (var stream = new FileStream(currentUser.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        picUserImage.Image = Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"שגיאה בטעינת תמונת המשתמש: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDefaultUserImage(); // טוען את תמונת ברירת המחדל במקרה של שגיאה
                }
            }
            else
            {
                LoadDefaultUserImage(); // טוען את תמונת ברירת המחדל במקרה שאין תמונה
            }
        }

        private void LoadDefaultUserImage()
        {
            try
            {
                byte[] imageData = UniversitySystem.Properties.Resources.UserDefaultImage;

                using (var ms = new MemoryStream(imageData))
                {
                    picUserImage.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה בטעינת תמונת ברירת המחדל: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picUserImage.Image = null;
            }
        }

        private void LoadRecentMessages()
        {
            lstRecentMessages.Items.Clear();
            var recentMessages = currentUser.GetRecentMessages(5);
            foreach (var message in recentMessages)
            {
                lstRecentMessages.Items.Add($"{message.Date:dd/MM/yyyy HH:mm} - מאת: {message.Sender.Name}");
            }
        }

        private void ShowMessageDetails(UniversitySystem.Models.Message message)
        {
            var detailsForm = new MessageDetailsForm(message);
            detailsForm.ShowDialog();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            using (var updateForm = new UpdatePersonalInfoForm(currentUser))
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPersonalInfo(); // טען מחדש את המידע המעודכן
                }
            }
        }

        #endregion

        #region Messages Tab

        private void SetupMessagesTab()
        {
            lvAllMessages.Columns.Add("תאריך", 100);
            lvAllMessages.Columns.Add("שולח", 100);
            lvAllMessages.Columns.Add("תוכן", 300);
            lvAllMessages.Columns.Add("מועדף", 50);

            LoadAllMessages();

            btnSortByDate.Click += (sender, e) => SortMessages(SortType.Date);
            btnSortByFavorite.Click += (sender, e) => SortMessages(SortType.Favorite);
            btnSortBySenderImportance.Click += (sender, e) => SortMessages(SortType.SenderImportance);
            btnSendMessage.Click += BtnSendMessage_Click;

            // הוספת אירוע ללחיצה כפולה על הודעה
            lvAllMessages.DoubleClick += LvAllMessages_DoubleClick;
        }

        private void LoadAllMessages()
        {
            lvAllMessages.Items.Clear();
            foreach (var message in currentUser.Messages)
            {
                var item = new ListViewItem(message.Date.ToShortDateString());
                item.SubItems.Add(message.Sender.Name);
                item.SubItems.Add(message.Content.Length > 50 ? message.Content.Substring(0, 47) + "..." : message.Content);
                item.SubItems.Add(message.IsFavorite ? "כן" : "לא");
                item.Tag = message;
                lvAllMessages.Items.Add(item);
            }
        }

        private void LvAllMessages_DoubleClick(object sender, EventArgs e)
        {
            if (lvAllMessages.SelectedItems.Count > 0)
            {
                var selectedMessage = (UniversitySystem.Models.Message)lvAllMessages.SelectedItems[0].Tag;
                ShowMessageDetails(selectedMessage);
            }
        }

        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            string messageContent = txtNewMessage.Text;
            if (!string.IsNullOrWhiteSpace(messageContent))
            {
                var newMessage = new UniversitySystem.Models.Message
                {
                    Content = messageContent,
                    Sender = currentUser,
                    Date = DateTime.Now,
                    IsFavorite = false
                };

                currentUser.Messages.Add(newMessage);

                // TODO: שמירת ההודעה במסד הנתונים
                // DatabaseHandler.SaveMessage(newMessage);

                MessageBox.Show("ההודעה נשלחה בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewMessage.Clear();
                LoadAllMessages();
            }
            else
            {
                MessageBox.Show("אנא הזן תוכן להודעה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SortMessages(SortType sortType)
        {
            switch (sortType)
            {
                case SortType.Date:
                    currentUser.Messages = currentUser.Messages.OrderByDescending(m => m.Date).ToList();
                    break;
                case SortType.Favorite:
                    currentUser.Messages = currentUser.Messages.OrderByDescending(m => m.IsFavorite).ThenByDescending(m => m.Date).ToList();
                    break;
                case SortType.SenderImportance:
                    currentUser.Messages = currentUser.Messages.OrderByDescending(m => GetSenderImportance(m.Sender)).ThenByDescending(m => m.Date).ToList();
                    break;
            }
            LoadAllMessages();
        }

        private int GetSenderImportance(Person sender)
        {
            if (sender is DepartmentHead) return 3;
            if (sender is Lecturer) return 2;
            if (sender is Student) return 1;
            return 0;
        }

        #endregion

        #region Courses Tab

        private void SetupCoursesTab()
        {
            lvCourses.Items.Clear();
            lvCourses.Columns.Clear();

            if (currentUser is Student)
            {
                SetupStudentCoursesView();
            }
            else if (currentUser is Lecturer)
            {
                SetupLecturerCoursesView();
            }
            else if (currentUser is DepartmentHead)
            {
                SetupDepartmentHeadCoursesView();
            }
        }

        private void SetupStudentCoursesView()
        {
            lvCourses.Columns.Add("קוד קורס", 100);
            lvCourses.Columns.Add("שם הקורס", 200);
            lvCourses.Columns.Add("מרצה", 150);
            lvCourses.Columns.Add("נקודות זכות", 100);

            LoadStudentCourses();

            btnRegisterCourse.Visible = true;
            btnManageGrades.Visible = false;
            btnAddCourse.Visible = false;
            btnEditCourse.Visible = false;

            btnRegisterCourse.Click += BtnRegisterCourse_Click;
        }

        private void LoadStudentCourses()
        {
            var student = (Student)currentUser;
            foreach (var course in student.Courses)
            {
                var item = new ListViewItem(course.CourseCode);
                item.SubItems.Add(course.Name);
                item.SubItems.Add(course.Lecturer.Name);
                item.SubItems.Add(course.Credits.ToString());
                lvCourses.Items.Add(item);
            }
        }

        private void BtnRegisterCourse_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterCourseForm((Student)currentUser))
            {
                if (registerForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStudentCourses(); // רענון רשימת הקורסים
                }
            }
        }

        private void btnManageGrades_Click(object sender, EventArgs e)
        {
            if (currentUser is Student student)
            {
                var selectedCourse = student.Courses.FirstOrDefault(); // שליפת הקורס הראשון של הסטודנט
                using (var addEditCourseForm = new AddEditCourseForm(selectedCourse))
                {
                    if (addEditCourseForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadStudentCourses(); // רענון הקורסים לאחר העריכה
                    }
                }

            }
            else
            {
                MessageBox.Show("רק סטודנטים יכולים לנהל ציונים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupLecturerCoursesView()
        {
            lvCourses.Columns.Add("קוד קורס", 100);
            lvCourses.Columns.Add("שם הקורס", 200);
            lvCourses.Columns.Add("מספר סטודנטים", 100);
            LoadLecturerCourses();
        }

        private void LoadLecturerCourses()
        {
            var lecturer = (Lecturer)currentUser;
            foreach (var course in lecturer.TeachingCourses)
            {
                var item = new ListViewItem(course.CourseCode);
                item.SubItems.Add(course.Name);
                item.SubItems.Add(course.Students.Count.ToString());
                lvCourses.Items.Add(item);
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (currentUser is Lecturer lecturer)
            {
                var selectedCourse = lecturer.TeachingCourses.FirstOrDefault(); // בחירת הקורס הראשון לעריכה
                using (var addEditCourseForm = new AddEditCourseForm(selectedCourse))
                {
                    if (addEditCourseForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadLecturerCourses(); // רענון רשימת הקורסים לאחר העריכה
                    }
                }
            }
            else if (currentUser is DepartmentHead head)
            {
                var selectedCourse = head.DepartmentCourses.FirstOrDefault(); // בחירת הקורס הראשון לעריכה
                using (var addEditCourseForm = new AddEditCourseForm(selectedCourse))
                {
                    if (addEditCourseForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDepartmentCourses(); // רענון רשימת הקורסים לאחר העריכה
                    }
                }
            }
            else
            {
                MessageBox.Show("רק מרצים וראשי מחלקות יכולים לערוך קורסים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (currentUser is Lecturer lecturer)
            {
                using (var addEditCourseForm = new AddEditCourseForm())
                {
                    if (addEditCourseForm.ShowDialog() == DialogResult.OK)
                    {
                        lecturer.TeachingCourses.Add(addEditCourseForm.NewCourse);
                        LoadLecturerCourses();
                    }
                }
            }
            else if (currentUser is DepartmentHead head)
            {
                using (var addEditCourseForm = new AddEditCourseForm())
                {
                    if (addEditCourseForm.ShowDialog() == DialogResult.OK)
                    {
                        head.DepartmentCourses.Add(addEditCourseForm.NewCourse);
                        LoadDepartmentCourses();
                    }
                }
            }
            else
            {
                MessageBox.Show("רק מרצים וראשי מחלקות יכולים להוסיף קורסים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDepartmentHeadCoursesView()
        {
            lvCourses.Columns.Add("קוד קורס", 100);
            lvCourses.Columns.Add("שם הקורס", 200);
            lvCourses.Columns.Add("מרצה", 150);
            lvCourses.Columns.Add("מספר סטודנטים", 100);
            LoadDepartmentCourses();
        }

        private void LoadDepartmentCourses()
        {
            var departmentHead = (DepartmentHead)currentUser;
            foreach (var course in departmentHead.DepartmentCourses)
            {
                var item = new ListViewItem(course.CourseCode);
                item.SubItems.Add(course.Name);
                item.SubItems.Add(course.Lecturer.Name);
                item.SubItems.Add(course.Students.Count.ToString());
                lvCourses.Items.Add(item);
            }
        }

        #endregion

        #region Search Tab

        private void SetupSearchTab()
        {
            cmbSearchType.Items.AddRange(new string[] { "סטודנט", "מרצה", "ראש מחלקה" });
            cmbSearchType.SelectedIndex = 0;

            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchTerm.Text;
            string searchType = cmbSearchType.SelectedItem.ToString();

            // כאן תממש את לוגיקת החיפוש
            // ותציג את התוצאות ב-lvSearchResults
        }

        #endregion

        #region Options Tab

        private void SetupOptionsTab()
        {
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            trkFontSize.Scroll += TrkFontSize_Scroll;
            btnChangeColor.Click += BtnChangeColor_Click;
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                EnableDarkMode();
            }
            else
            {
                DisableDarkMode();
            }
        }

        private void EnableDarkMode()
        {
            this.BackColor = Color.FromArgb(45, 45, 48); // שינוי צבע רקע של הטופס

            // עדכון צבעים של תוויות, כפתורים, ותיבות טקסט
            foreach (Label label in this.Controls.OfType<Label>())
            {
                label.ForeColor = Color.White;
            }
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.BackColor = Color.FromArgb(30, 30, 30);
                textBox.ForeColor = Color.White;
            }
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.FromArgb(60, 60, 60);
                button.ForeColor = Color.White;
            }
        }

        private void DisableDarkMode()
        {
            this.BackColor = SystemColors.Control; // חזרה לצבע הרגיל של הטופס

            // עדכון הצבעים חזרה
            foreach (Label label in this.Controls.OfType<Label>())
            {
                label.ForeColor = Color.Black;
            }
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
            }
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = Color.Black;
            }
        }


        private void TrkFontSize_Scroll(object sender, EventArgs e)
        {
            if (trkFontSize.Value > 0)  // ודא שהערך גדול מ-0
            {
                this.Font = new Font(this.Font.FontFamily, trkFontSize.Value);
            }
            else
            {
                MessageBox.Show("גודל הגופן חייב להיות גדול מ-0", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialogBackground.Color;
            }
        }

        #endregion

        #region Menu Items

        private void mnuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // סגירת הטופס הנוכחי ופתיחת טופס התחברות מחדש
        }

        private void mnuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("כאן תוצג העזרה למערכת", "עזרה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("מערכת אוניברסיטאית\nגרסה 1.0\n© 2023 כל הזכויות שמורות", "אודות", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            // כאן תוכל להוסיף כל לוגיקה שצריכה לרוץ בעת טעינת הטופס
        }

        private void lvCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCourses.SelectedItems.Count > 0)
            {
                var selectedCourse = (Course)lvCourses.SelectedItems[0].Tag;
                // בצע פעולה על הקורס שנבחר
            }
        }

        private void btnSortBySenderImportance_Click(object sender, EventArgs e)
        {
            SortMessages(SortType.SenderImportance);
        }

        private void btnSortByFavorite_Click(object sender, EventArgs e)
        {
            SortMessages(SortType.Favorite);
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            SortMessages(SortType.Date);
        }

        private void btnChangeColor_Click_1(object sender, EventArgs e)
        {

        }

        private void tabCourses_Click(object sender, EventArgs e)
        {

        }
    }

    public enum SortType
    {
        Date,
        Favorite,
        SenderImportance
    }
}