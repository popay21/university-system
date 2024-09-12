using System.Collections.Generic;
using System.Linq;
using UniversitySystem.Models;

public static class DatabaseHandler
{
    private static List<Course> courses = new List<Course>();
    private static List<Student> students = new List<Student>();
    private static List<Lecturer> lecturers = new List<Lecturer>();
    private static List<Message> messages = new List<Message>(); // רשימת ההודעות

    public static void Initialize(List<Person> people)
    {
        foreach (var person in people)
        {
            if (person is Student student)
                students.Add(student);
            else if (person is Lecturer lecturer)
                lecturers.Add(lecturer);

            if (person is Lecturer lec)
            {
                courses.AddRange(lec.TeachingCourses);
            }
        }
    }

    public static List<Course> GetAvailableCourses(Student student)
    {
        return courses.Where(c => !student.Courses.Contains(c)).ToList();
    }

    public static void UpdateStudentCourses(Student student)
    {
        var existingStudent = students.FirstOrDefault(s => s.Id == student.Id);
        if (existingStudent != null)
        {
            existingStudent.Courses = student.Courses;
        }
    }

    public static List<Lecturer> GetAllLecturers()
    {
        return lecturers;
    }

    public static void UpdateCourse(Course course)
    {
        var existingCourse = courses.FirstOrDefault(c => c.CourseCode == course.CourseCode);
        if (existingCourse != null)
        {
            int index = courses.IndexOf(existingCourse);
            courses[index] = course;
        }
    }

    public static void AddNewCourse(Course course)
    {
        courses.Add(course);
    }

    public static void UpdateStudentGrade(Student student, string courseCode, int grade)
    {
        var existingStudent = students.FirstOrDefault(s => s.Id == student.Id);
        if (existingStudent != null)
        {
            existingStudent.SetGradeForCourse(courseCode, grade);
        }
    }

    // פונקציה לשמירת הודעה
    public static void SaveMessage(Message message)
    {
        messages.Add(message); // שמירת ההודעה ברשימה

        // ניתן להוסיף כאן לוגיקה לשמירה במסד נתונים בפועל אם נדרש
    }
}
