using System;
using System.Windows.Forms;
using UniversitySystem.Models;

namespace UniversitySystem.Forms
{
    public partial class AddEditCourseForm : Form
    {
        private Course editingCourse;
        private bool isEditMode;

        public Course NewCourse { get; private set; }

        public AddEditCourseForm(Course course = null)
        {
            InitializeComponent();
            editingCourse = course;
            isEditMode = (course != null);
        }

        private void AddEditCourseForm_Load(object sender, EventArgs e)
        {
            LoadLecturers();
            if (isEditMode)
            {
                LoadCourseData();
                this.Text = "עריכת קורס";
            }
            else
            {
                this.Text = "הוספת קורס חדש";
            }
        }

        private void LoadLecturers()
        {
            var lecturers = DatabaseHandler.GetAllLecturers();
            cmbLecturer.DataSource = lecturers;
            cmbLecturer.DisplayMember = "Name";
            cmbLecturer.ValueMember = "Id";
        }

        private void LoadCourseData()
        {
            txtCourseCode.Text = editingCourse.CourseCode;
            txtCourseName.Text = editingCourse.Name;
            nudCredits.Value = editingCourse.Credits;
            cmbLecturer.SelectedValue = editingCourse.Lecturer.Id;

            txtCourseCode.Enabled = false; // לא מאפשרים לשנות קוד קורס בעריכה
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (isEditMode)
                {
                    UpdateExistingCourse();  // עדכון קורס קיים
                }
                else
                {
                    CreateNewCourse();  // יצירת קורס חדש
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text) ||
                string.IsNullOrWhiteSpace(txtCourseName.Text) ||
                cmbLecturer.SelectedItem == null)
            {
                MessageBox.Show("אנא מלא את כל השדות.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // פונקציה לעדכון קורס קיים
        private void UpdateExistingCourse()
        {
            editingCourse.Name = txtCourseName.Text;
            editingCourse.Credits = (int)nudCredits.Value;
            editingCourse.Lecturer = (Lecturer)cmbLecturer.SelectedItem;

            DatabaseHandler.UpdateCourse(editingCourse);
            MessageBox.Show("הקורס עודכן בהצלחה.", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // פונקציה ליצירת קורס חדש
        private void CreateNewCourse()
        {
            NewCourse = new Course
            {
                CourseCode = txtCourseCode.Text,
                Name = txtCourseName.Text,
                Credits = (int)nudCredits.Value,
                Lecturer = (Lecturer)cmbLecturer.SelectedItem
            };

            DatabaseHandler.AddNewCourse(NewCourse);
            MessageBox.Show("הקורס נוסף בהצלחה.", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
