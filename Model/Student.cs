using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSProject.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Department { get; set; }

        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            return $"{StudentNumber} - {FirstName} {LastName}";
        }
    }
}
