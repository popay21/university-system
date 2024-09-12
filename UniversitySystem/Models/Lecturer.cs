using System.Collections.Generic;

namespace UniversitySystem.Models
{
    public class Lecturer : Person
    {
        public string EmployeeNumber { get; set; }
        public List<Course> TeachingCourses { get; set; }
        public string Specialization { get; set; }
        public int StudentRating { get; set; }
        public string Department { get; set; }
        public double Rating { get; set; }

        public Lecturer()
        {
            TeachingCourses = new List<Course>();
        }
    }
}
