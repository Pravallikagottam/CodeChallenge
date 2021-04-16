using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
   public interface IEmployeeRepository
    {
         List<Employee> GetEmployees();
         Employee GetEmployeeById(int employeeId);
         bool SaveEmployee(Employee employee);
    }
}
