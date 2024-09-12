using System.Collections.Generic;
using System.Windows.Forms;
using System;
using UniversitySystem.Models;

namespace UniversitySystem.Forms
{
    public partial class RegisterCourseForm : Form
    {
        private Student currentStudent;
        private List<Course> availableCourses;

        public RegisterCourseForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void RegisterCourseForm_Load(object sender, EventArgs e)
        {
            LoadAvailableCourses();
        }

        private void LoadAvailableCourses()
        {
            availableCourses = DatabaseHandler.GetAvailableCourses(currentStudent);

            lstAvailableCourses.Items.Clear();
            foreach (var course in availableCourses)
            {
                lstAvailableCourses.Items.Add($"{course.CourseCode} - {course.Name} ({course.Credits} נק\"ז)");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (lstAvailableCourses.SelectedIndex != -1)
            {
                var selectedCourse = availableCourses[lstAvailableCourses.SelectedIndex];

                if (currentStudent.IsRegisteredToCourse(selectedCourse.CourseCode))
                {
                    MessageBox.Show("אתה כבר רשום לקורס זה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!selectedCourse.CanRegister(currentStudent))
                {
                    MessageBox.Show("אינך עומד בתנאי הקדם לקורס זה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentStudent.RegisterToCourse(selectedCourse);
                DatabaseHandler.UpdateStudentCourses(currentStudent);

                MessageBox.Show("נרשמת בהצלחה לקורס.", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("אנא בחר קורס מהרשימה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
