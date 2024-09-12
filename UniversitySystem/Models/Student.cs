using System.Collections.Generic;
using System.Linq;

namespace UniversitySystem.Models
{
    public class Student : Person
    {
        public string StudentNumber { get; set; }
        public string Program { get; set; }
        public string Specialization { get; set; }
        public int CurrentCredits { get; set; }
        public int TotalCredits { get; set; }
        public int Credits { get; set; }
        public List<Course> Courses { get; set; }
        public bool IsRegisteredToCourse(string courseCode)
        {
            return Courses.Any(c => c.CourseCode == courseCode);
        }

        public void RegisterToCourse(Course course)
        {
            if (!IsRegisteredToCourse(course.CourseCode))
            {
                Courses.Add(course);
                course.Students.Add(this);
            }
        }

        private Dictionary<string, int> courseGrades = new Dictionary<string, int>();

        public int? GetGradeForCourse(string courseCode)
        {
            if (courseGrades.TryGetValue(courseCode, out int grade))
            {
                return grade;
            }
            return null;
        }

        public void SetGradeForCourse(string courseCode, int grade)
        {
            courseGrades[courseCode] = grade;
        }

        public Student()
        {
            Courses = new List<Course>();
        }
    }
}