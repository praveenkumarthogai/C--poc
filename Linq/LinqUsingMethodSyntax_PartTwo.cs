using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    internal class LinqUsingMethodSyntax_PartTwo
    {
        List<Student> Student = new List<Student>();
        List<Student> StudentOne = new List<Student>();
        public LinqUsingMethodSyntax_PartTwo()
        {
            Student = new List<Student>()
            {
                new Student{StudentId = 1, StudentName ="Vikram", Age = 16,Physics = 50 ,Chemistry = 60,Maths = 70  },
                new Student{StudentId = 1, StudentName ="mark", Age = 16,Physics = 50 ,Chemistry = 60,Maths = 70  },
                new Student{StudentId = 1, StudentName ="Jerry", Age = 16,Physics = 50 ,Chemistry = 60,Maths = 70  },
                new Student{StudentId = 2, StudentName = "John" ,Age = 17,Physics = 70 ,Chemistry = 90,Maths = 90 },
                new Student {StudentId  = 3 ,StudentName = "Alex", Age = 14, Physics = 80 ,Chemistry = 88,Maths = 100},
                new Student {StudentId = 20 ,  StudentName = "Karthick" ,Age = 20 ,Physics = 90 ,Chemistry = 60,Maths = 90}
            };

            StudentOne = new List<Student>()
            {
                new Student{StudentId = 1, StudentName ="Vikram", Age = 16,Physics = 50 ,Chemistry = 60,Maths = 70  },
                new Student{StudentId = 10, StudentName ="Surya", Age = 16,Physics = 50 ,Chemistry = 60,Maths = 70  },
                new Student{StudentId = 30, StudentName ="Dhanush", Age = 16,Physics = 50 ,Chemistry = 60,Maths = 70  },

            };
        }
        public List<Student> UsingDistinct()
        {
            return Student.Distinct(new StudentComparer()).ToList();
        }

        public int UsingSkip()
        {
            return Student.Skip(3).Count();
        }

        public int UsingTake()
        {
            return Student.Take(2).Count();
        }

        public int UsingAggregateFunction()
        {
            return Student.Max(x => x.Maths);
            // return Student.Min(x => x.Maths);
            //return Student.Sum(x => x.Maths);
        }

        //ToDo: union | intersect | except | Concat | group By |  join | left outer join | select Many


        public void UsingUnion()
        {
            var result = Student.Union(StudentOne, new StudentComparer());
        }

        public void UsingIntersect()
        {
            var result = Student.Intersect(StudentOne, new StudentComparer());
        }

        public void UsingExcept()
        {
            var result = Student.Except(StudentOne, new StudentComparer());
        }

        public void UsingConcat()
        {
            var result = Student.Concat(StudentOne);
        }

        public void UsingGroupBY()
        {
            var result = Student.GroupBy(x => x.Age);
            var result1 = Student.GroupBy(x => new { x.StudentId, x.Age }).Select(x => new Student { TotalMarks = x.Sum(x => x.Maths), StudentId = x.Key.StudentId });
        }

        public void UsingJoin()
        {
            var result = Student.Join(StudentOne,
                                      x => x.StudentId,
                                      y => y.StudentId,
                                      (x, xOne) => new { x, xOne }).
                                      Select(x => new Student
                                      {
                                          StudentId = x.xOne.StudentId,
                                          StudentName = x.x.StudentName
                                      });


        }

        public void SelectMany()
        {
            var developer = new List<Developer>()
            {
               new Developer{ Experiece = 5,Name = "praveen",role="software developer", Skills = new List<string>  {"C#","JS","Angular" } },
               new Developer{ Experiece = 5,Name = "praveen",role="software developer", Skills = new List<string>  {"AWS","Azure","reactjs" } },
            };

            var result = developer.SelectMany(x => x.Skills);
            var result1 = result.ToList();
        }
    }



    //union | intersect | except | distinct For complex data Iequality Comparer is mandatory for primitive data not needed
    //inner join will except one or more column match but intersect will except all the column to match
}
