using CSharpNotes.AbstractClass;
using System;

namespace CSharpNotes
{
    internal class Program
    {
        //Reason of using abstract class instead of concrete class
        //To avoid creating instance of base class on its own
        //Same Method signature but with different implementation can be added in the abstract base class as abstract method
        static void Main(string[] args)
        {
            //As per Liksov Principle Parent class should be replaced by child class
            //If anything is specific to child class and not common move specific to particular child class;
            //GetDepartment() is specific to Teacher One so it is not part of base class
            
            School school = new TeacherOne();
            Console.WriteLine(school.GetWorkExperience());

            School school1 = new TeacherTwo();
            Console.WriteLine(school1.GetWorkExperience());

            TeacherOne teacherOne = new TeacherOne();
            Console.WriteLine(teacherOne.GetSchoolName());//Method inherited from base class

            TeacherTwo teacherTwo = new TeacherTwo();
            Console.WriteLine(teacherTwo.GetSchoolAddress());//Method inherited from base class
        }
    }
}
