using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSProject.Model;

namespace SSProject.Controller
{
    public class StudentController
    {
        private List<Student> students = new List<Student>();

        public bool TryAddStudent(Student student)
        {
            if (student == null || StudentNumberExists(student.StudentNumber))
            {
                return false;
            }
            students.Add(student);
            return true;
        }

        public bool StudentNumberExists(string studentNumber)
        {
            return students.Any(student => student.StudentNumber == studentNumber);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public void AddCourseToStudent(Student student, Course course)
        {
            student.Courses.Add(course);
        }

        public bool CourseCodeExists(Student student, string courseCode)
        {
            return student.Courses.Any(course => course.CourseCode == courseCode);
        }

        public List<Course> GetCoursesOfStudent(Student student)
        {
            return student.Courses;
        }
    }
}
