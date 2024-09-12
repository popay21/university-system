using System.Collections.Generic;

namespace UniversitySystem.Models
{
    public class DepartmentHead : Lecturer
    {
        public List<string> ManagedPrograms { get; set; }
        public List<Person> Subordinates { get; set; }
        public List<Lecturer> ManagedLecturers { get; set; }
        public List<Student> ManagedStudents { get; set; }
        public List<Course> DepartmentCourses { get; set; }

        public DepartmentHead()
        {
            ManagedPrograms = new List<string>();
            Subordinates = new List<Person>();
            ManagedLecturers = new List<Lecturer>();
            ManagedStudents = new List<Student>();
            DepartmentCourses = new List<Course>();
        }
    }
}
