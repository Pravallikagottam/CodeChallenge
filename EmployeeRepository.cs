using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeChallenge1
{
    public class EmployeeRepository : IEmployeeRepository,IDisposable
    {
        public string connectionString;
        public List<Employee> GetEmployees()
        {
            using (EmployeeDataContext dataContext = new EmployeeDataContext(connectionString))
            {
                return dataContext.GetEmployees();
            }

            //return new List<Employee>();
        }
        public Employee GetEmployeeById(int employeeId)
        {
            using (EmployeeDataContext dataContext = new EmployeeDataContext(connectionString))
            {
                return dataContext.GetEmployeeById(employeeId);
            }

            //return new Employee();

        }
        public bool SaveEmployee(Employee employee)
        {
            using (EmployeeDataContext dataContext = new EmployeeDataContext(connectionString))
            {
                var result = dataContext.SaveEmployee(employee);
                if (result.EmployeeId > 0)
                    return true;
                else
                    return false;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}