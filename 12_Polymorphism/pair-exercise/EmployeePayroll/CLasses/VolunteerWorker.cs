using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class VolunteerWorker : IWorker
    {
        public VolunteerWorker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            double pay = hoursWorked * 0;
            return pay;
        }
    }
}
