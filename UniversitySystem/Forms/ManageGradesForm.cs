using System;
using System.Windows.Forms;
using UniversitySystem.Models;

namespace UniversitySystem.Forms
{
    public partial class ManageGradesForm : Form
    {
        private Course currentCourse;

        public ManageGradesForm(Course course)
        {
            InitializeComponent();
            currentCourse = course;
        }

        private void ManageGradesForm_Load(object sender, EventArgs e)
        {
            lblCourseInfo.Text = $"קורס: {currentCourse.Name} ({currentCourse.CourseCode})";
            LoadStudents();
        }

        private void LoadStudents()
        {
            lvStudents.Items.Clear();
            foreach (var student in currentCourse.Students)
            {
                var item = new ListViewItem(student.Name);
                item.SubItems.Add(student.StudentNumber);
                item.SubItems.Add(student.GetGradeForCourse(currentCourse.CourseCode)?.ToString() ?? "");
                item.Tag = student; // שמירת אובייקט הסטודנט ב-Tag לשימוש מאוחר יותר
                lvStudents.Items.Add(item);
            }
        }

        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count > 0 && !string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                if (int.TryParse(txtGrade.Text, out int grade) && grade >= 0 && grade <= 100)
                {
                    var student = (Student)lvStudents.SelectedItems[0].Tag;
                    student.SetGradeForCourse(currentCourse.CourseCode, grade);
                    DatabaseHandler.UpdateStudentGrade(student, currentCourse.CourseCode, grade);

                    LoadStudents(); // רענון הרשימה
                    txtGrade.Clear();
                }
                else
                {
                    MessageBox.Show("אנא הזן ציון תקין בין 0 ל-100.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("אנא בחר סטודנט והזן ציון.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count > 0)
            {
                txtGrade.Text = lvStudents.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
