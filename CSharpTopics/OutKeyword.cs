using CSharpTopics.Model;
using System.Collections.Generic;

namespace CSharpTopics
{
    public class OutKeyword
    {
        public string GetEmployeeName(int ID)
        {
            string name;
            GetEmployeeNameByID(out name, ID);
            return name;
        }

        public void GetEmployeeNameByID(out string name, int id)
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


            name = employeeInfos.Find(x => x.Id == id).Name;
        }
    }

}
