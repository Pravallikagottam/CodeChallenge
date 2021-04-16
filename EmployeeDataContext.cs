using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeChallenge1
{
    public class EmployeeDataContext : IDisposable
    {
        public EmployeeDataContext(string connection)
        {

        }
        public List<Employee> GetEmployees()
        {
            var fakeData = new List<Employee>() {
                                new Employee { FirstName = "Jane", LastName = "Doe", Address = "123 Main St", EmployeeId = 101, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 101, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                                new Employee { FirstName = "Jane", LastName = "Doe", Address = "123 Main St", EmployeeId = 102, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 102, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                                new Employee { FirstName = "Jane1", LastName = "Doe", Address = "123 Main St", EmployeeId = 103, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 103, EmployeeType = EmployeeType.Manager, AnnualSalary=100000,ExpenseAmount=200.00M } },
                                new Employee { FirstName = "Jane2", LastName = "Doe", Address = "123 Main St", EmployeeId = 104, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 104, EmployeeType = EmployeeType.Manager, AnnualSalary=150000,ExpenseAmount=250.00M  } },
                                new Employee { FirstName = "Jane3", LastName = "Doe", Address = "123 Main St", EmployeeId = 105, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 105, EmployeeType = EmployeeType.Supervisor, AnnualSalary=120000 } },
                                new Employee { FirstName = "Jane4", LastName = "Doe", Address = "123 Main St", EmployeeId = 106, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 106, EmployeeType = EmployeeType.Supervisor, AnnualSalary=100000  } },
                                new Employee { FirstName = "Jane5", LastName = "Doe", Address = "123 Main St", EmployeeId = 107, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 107, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                            };

            return fakeData;
        }

        public Employee SaveEmployee(Employee empInfo)
        {
            var fakeData = new List<Employee>() {
                                new Employee { FirstName = "Jane", LastName = "Doe", Address = "123 Main St", EmployeeId = 101, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 101, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                                new Employee { FirstName = "Jane", LastName = "Doe", Address = "123 Main St", EmployeeId = 102, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 102, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                                new Employee { FirstName = "Jane1", LastName = "Doe", Address = "123 Main St", EmployeeId = 103, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 103, EmployeeType = EmployeeType.Manager, AnnualSalary=100000,ExpenseAmount=200.00M } },
                                new Employee { FirstName = "Jane2", LastName = "Doe", Address = "123 Main St", EmployeeId = 104, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 104, EmployeeType = EmployeeType.Manager, AnnualSalary=150000,ExpenseAmount=250.00M  } },
                                new Employee { FirstName = "Jane3", LastName = "Doe", Address = "123 Main St", EmployeeId = 105, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 105, EmployeeType = EmployeeType.Supervisor, AnnualSalary=120000 } },
                                new Employee { FirstName = "Jane4", LastName = "Doe", Address = "123 Main St", EmployeeId = 106, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 106, EmployeeType = EmployeeType.Supervisor, AnnualSalary=100000  } },
                                new Employee { FirstName = "Jane5", LastName = "Doe", Address = "123 Main St", EmployeeId = 107, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 107, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                            };

            empInfo.EmployeeId = fakeData.Max(x => x.EmployeeId) + 1;
            fakeData.Add(empInfo);
            var newEmpId = fakeData.Max(x => x.EmployeeId);
            var result = fakeData.Where(x => x.EmployeeId == newEmpId).SingleOrDefault();
            return result;
        }

        public Employee GetEmployeeById(int empId)
        {
            var fakeData = new List<Employee>() {
                                new Employee { FirstName = "Jane", LastName = "Doe", Address = "123 Main St", EmployeeId = 101, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 101, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                                new Employee { FirstName = "Jane", LastName = "Doe", Address = "123 Main St", EmployeeId = 102, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 102, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                                new Employee { FirstName = "Jane1", LastName = "Doe", Address = "123 Main St", EmployeeId = 103, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 103, EmployeeType = EmployeeType.Manager, AnnualSalary=100000,ExpenseAmount=200.00M } },
                                new Employee { FirstName = "Jane2", LastName = "Doe", Address = "123 Main St", EmployeeId = 104, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 104, EmployeeType = EmployeeType.Manager, AnnualSalary=150000,ExpenseAmount=250.00M  } },
                                new Employee { FirstName = "Jane3", LastName = "Doe", Address = "123 Main St", EmployeeId = 105, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 105, EmployeeType = EmployeeType.Supervisor, AnnualSalary=120000 } },
                                new Employee { FirstName = "Jane4", LastName = "Doe", Address = "123 Main St", EmployeeId = 106, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 106, EmployeeType = EmployeeType.Supervisor, AnnualSalary=100000  } },
                                new Employee { FirstName = "Jane5", LastName = "Doe", Address = "123 Main St", EmployeeId = 107, EmployeeFinancialInfo = new EmployeeFinancials { EmployeeId = 107, EmployeeType = EmployeeType.Employee, PayPerHour = 50.00M } },
                            };

            var result = fakeData.Where(x => x.EmployeeId == empId).SingleOrDefault();
            return result;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}