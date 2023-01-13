using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository()
        {
            
        }
        public Task CreateEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
