using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    internal interface IEmployeeService
    {
        Task CreateEmployee();
        Task<Employee> GetAllEmployees();

    }
}
