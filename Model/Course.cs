using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSProject.Model
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Credit { get; set; }
        public int Midterm { get; set; }
        public int Final { get; set; }

        public double Average
        {
            get
            {
                return Midterm * 0.4 + Final * 0.6;
            }
        }

        public string Status
        {
            get
            {
                return Average >= 50 ? "GEÇTİ" : "KALDI";
            }
        }
    }
}
