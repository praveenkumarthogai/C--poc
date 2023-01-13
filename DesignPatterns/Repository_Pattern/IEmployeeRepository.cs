using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    internal interface IEmployeeRepository
    {

        Task<Employee> GetAllEmployees();

        Task CreateEmployee();
    }
}
