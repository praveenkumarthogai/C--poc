using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        public int TotalMarks { get; set; }
    }


    public class StudentMarks
    {
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
    }
}
