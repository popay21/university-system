using System.Collections.Generic;

namespace UniversitySystem.Models
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public Lecturer Lecturer { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public bool CanRegister(Student student)
        {
            // Implement registration logic here
            return true;
        }
    }
}