using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeChallenge1
{
    public class EmployeeFinancials
    {
        public int EmployeeId { get; set; }

        public EmployeeType EmployeeType { get; set; }
        public decimal PayPerHour { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal ExpenseAmount { get; set; }

    }
}