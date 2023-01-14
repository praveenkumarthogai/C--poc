using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Linq
{
    internal class LinqUsingMethodSyntax
    {
        List<Student> Student;
        public LinqUsingMethodSyntax()
        {
            Student = new List<Student>()
            {
                new Student{StudentId = 1, StudentName ="Vikram", Age = 16,Physics = 50 ,Chemistry = 60,Maths = 70  },
                new Student{StudentId = 2, StudentName = "John" ,Age = 17,Physics = 70 ,Chemistry = 90,Maths = 90 },
                new Student {StudentId  = 3 ,StudentName = "Alex", Age = 14, Physics = 80 ,Chemistry = 88,Maths = 100},
                new Student {StudentId = 20 ,  StudentName = "Karthick" ,Age = 20 ,Physics = 90 ,Chemistry = 60,Maths = 90}
            };
        }

        public List<Student> UsingWhere()
        {
            return Student.Where(x => x.Age < 20).ToList();
        }

        public List<Student> UsingWhereWithMultipleCondition()
        {
            return Student.Where(x => x.Maths > 50 && x.Physics > 60 && x.Chemistry > 80).ToList();
        }

        public List<StudentMarks> UsingWhereAndSelect()
        {
            return Student.Where(x => x.Age < 20).Select(x => new StudentMarks { 
                Chemistry = x.Chemistry,
                Maths = x.Maths,
                Physics = x.Physics
            }).ToList();
        }

        public List<Student> UsingOrderBy()
        {
            return Student.Where(x => x.Age < 20).OrderByDescending(x => x.Age).ToList();
        }


        public List<Student> UsingThenBy()
        {
            return Student.Where(x => x.Age < 20).OrderBy(x => x.Age).ThenByDescending(x => x.Age).ToList();
        }

        public int UsingCount()
        {
            return Student.Where(x => x.Age < 20).Count();
        }

        public int UsingCountWithoutExplicitWhere()
        {
            return Student.Count(x => x.Age < 20);
        }

        public Student UsingFirst()
        {
            return Student.First();
        }

        public Student UsingFirstWithCondition()
        {
            return Student.First(x=>x.Maths > 100); // throws error
            //return Student.First(x => x.Maths < 100);
        }

        public Student UsingFirstOrDefault()
        {
            return Student.FirstOrDefault();
        }

        public Student UsingFirstOrDefaultUsingCondition()
        {
            //return Student.FirstOrDefault(x => x.Maths < 100);
            return Student.FirstOrDefault(x => x.Maths > 100);  //returns null since no record matches | no erro thrown
        }
    }
}
