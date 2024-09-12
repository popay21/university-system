using System;
using System.Collections.Generic;
using UniversitySystem.Models;

namespace UniversitySystem
{
    public static class DataInitializer
    {
        public static List<Person> InitializeData()
        {
            var people = new List<Person>();

            // יצירת מרצים
            var lecturer1 = new Lecturer
            {
                Id = "L001",
                Name = "ד\"ר יעל כהן",
                Age = 45,
                PhoneNumber = "050-1234567",
                Email = "yael@university.com",
                ImagePath = "path/to/yael_image.jpg",
                LastLoginDate = DateTime.Now.AddDays(-1),
                EmployeeNumber = "E001",
                Department = "מדעי המחשב",
                Specialization = "אלגוריתמים",
                StudentRating = 90,
                Rating = 4.5
            };

            var lecturer2 = new Lecturer
            {
                Id = "L002",
                Name = "פרופ' דוד לוי",
                Age = 55,
                PhoneNumber = "050-2345678",
                Email = "david@university.com",
                ImagePath = "path/to/david_image.jpg",
                LastLoginDate = DateTime.Now.AddDays(-2),
                EmployeeNumber = "E002",
                Department = "מתמטיקה",
                Specialization = "אלגברה",
                StudentRating = 85,
                Rating = 4.8
            };

            // יצירת ראש מחלקה
            var departmentHead = new DepartmentHead
            {
                Id = "DH001",
                Name = "פרופ' שרה ישראלי",
                Age = 50,
                PhoneNumber = "050-3456789",
                Email = "sarah@university.com",
                ImagePath = "path/to/sarah_image.jpg",
                LastLoginDate = DateTime.Now.AddHours(-12),
                EmployeeNumber = "E003",
                Department = "מדעי המחשב",
                Specialization = "בינה מלאכותית",
                StudentRating = 95,
                Rating = 4.9,
                ManagedPrograms = new List<string> { "מדעי המחשב", "הנדסת תוכנה" }
            };

            // יצירת סטודנטים
            var student1 = new Student
            {
                Id = "S001",
                Name = "יוסי ישראלי",
                Age = 22,
                PhoneNumber = "052-1234567",
                Email = "yossi@student.university.com",
                ImagePath = "path/to/yossi_image.jpg",
                LastLoginDate = DateTime.Now.AddHours(-3),
                StudentNumber = "123456",
                Program = "מדעי המחשב",
                Specialization = "אבטחת מידע",
                CurrentCredits = 80,
                TotalCredits = 120
            };

            var student2 = new Student
            {
                Id = "S002",
                Name = "רונית כהן",
                Age = 21,
                PhoneNumber = "052-2345678",
                Email = "ronit@student.university.com",
                ImagePath = "path/to/ronit_image.jpg",
                LastLoginDate = DateTime.Now.AddHours(-5),
                StudentNumber = "234567",
                Program = "מתמטיקה",
                Specialization = "סטטיסטיקה",
                CurrentCredits = 60,
                TotalCredits = 120
            };

            // יצירת קורסים
            var course1 = new Course
            {
                CourseCode = "CS101",
                Name = "מבוא למדעי המחשב",
                Credits = 5,
                Lecturer = lecturer1
            };

            var course2 = new Course
            {
                CourseCode = "MATH101",
                Name = "אלגברה לינארית",
                Credits = 4,
                Lecturer = lecturer2
            };

            // הוספת סטודנטים לקורסים
            course1.Students.Add(student1);
            course1.Students.Add(student2);
            course2.Students.Add(student1);

            // הוספת קורסים למרצים ולסטודנטים
            lecturer1.TeachingCourses.Add(course1);
            lecturer2.TeachingCourses.Add(course2);
            student1.Courses.Add(course1);
            student1.Courses.Add(course2);
            student2.Courses.Add(course1);

            // הוספת ציונים לסטודנטים
            student1.SetGradeForCourse("CS101", 85);
            student1.SetGradeForCourse("MATH101", 90);
            student2.SetGradeForCourse("CS101", 78);

            // הוספת קורסים למחלקה
            departmentHead.DepartmentCourses.Add(course1);
            departmentHead.DepartmentCourses.Add(course2);

            // הוספת כפיפים לראש המחלקה
            departmentHead.Subordinates.Add(lecturer1);
            departmentHead.Subordinates.Add(lecturer2);
            departmentHead.ManagedLecturers.Add(lecturer1);
            departmentHead.ManagedLecturers.Add(lecturer2);
            departmentHead.ManagedStudents.Add(student1);
            departmentHead.ManagedStudents.Add(student2);

            // יצירת הודעות לדוגמה
            var message1 = new Message
            {
                Sender = lecturer1,
                Receiver = student1,
                Content = "תזכורת: יש להגיש את העבודה עד יום ראשון",
                Date = DateTime.Now.AddDays(-1),
                IsFavorite = false
            };

            var message2 = new Message
            {
                Sender = student2,
                Receiver = lecturer2,
                Content = "שאלה לגבי התרגיל האחרון",
                Date = DateTime.Now.AddHours(-5),
                IsFavorite = true
            };

            // הוספת הודעות למשתמשים
            lecturer1.Messages.Add(message1);
            student1.Messages.Add(message1);
            lecturer2.Messages.Add(message2);
            student2.Messages.Add(message2);

            // הוספת כל האנשים לרשימה
            people.Add(lecturer1);
            people.Add(lecturer2);
            people.Add(departmentHead);
            people.Add(student1);
            people.Add(student2);

            return people;
        }
    }
}
