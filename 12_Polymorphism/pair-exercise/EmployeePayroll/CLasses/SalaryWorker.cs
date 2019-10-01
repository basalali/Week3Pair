using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class SalaryWorker : IWorker
    {
        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            AnnualSalary = annualSalary;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public double AnnualSalary { get; }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            //salary worker makes the same each week regardless of hoursWorked 
            double pay = AnnualSalary / 52;
            return pay;
        }
    }
}
