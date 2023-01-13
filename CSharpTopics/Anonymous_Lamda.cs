using CSharpTopics.Model;
using System;
using System.Collections.Generic;

namespace CSharpTopics
{
    public class Anonymous_Lamda
    {
        public void Test()
        {
            List<EmployeeInfo> employeeInfos = new List<EmployeeInfo>()
            {
                new EmployeeInfo()
                {
                    Designation = "Software developer",
                    Id=1,
                    Location = "Noida",
                    Name  = "James"
                },
                new EmployeeInfo()
                {
                    Name = "John",
                    Location = "Bangalore",
                    Id = 2,
                    Designation="Team Lead"
                },
                new EmployeeInfo()
                {
                    Name = "Jack",
                    Location = "Chennai",
                    Id = 3,
                    Designation="Manager"
                }
            };

            //Basically delegate is a reference to a method | delegate work as a callback

            //step2
            //Create instance of predicateDelegate and pass method name as paramter
            Predicate<EmployeeInfo> predicateDelegate = new Predicate<EmployeeInfo>(FindEmployee);

            //step3
            //here predicate instance is passed as argument
            EmployeeInfo resultD = employeeInfos.Find(x => predicateDelegate(x));

            //using Anonymous method(using this technique avoiding step 1,2,3)
            //Anonymous method is method without method name
            //they provide way for  creating delegate instance without having to write separate method
            EmployeeInfo resultA = employeeInfos.Find(delegate(EmployeeInfo emp) { return emp.Location == "Bangalore"; });

            //using Lamda Operator(here anonymous method can be shortened by lamda operator)
            //No need of delegate keyword and no need of mentioning datatype in parameter (most usecase in linq queries)
            EmployeeInfo resultL = employeeInfos.Find(x => x.Location == "Bangalore");
        }

        //step1
        public static bool FindEmployee(EmployeeInfo emp)
        {
            return emp.Location == "Bangalore";
        }

    }
}
