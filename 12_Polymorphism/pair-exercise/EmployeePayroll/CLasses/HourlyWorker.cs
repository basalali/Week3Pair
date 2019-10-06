using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class HourlyWorker : IWorker
    {
        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            HourlyRate = hourlyRate;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public double HourlyRate { get; }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            double pay = HourlyRate * hoursWorked;

            if (hoursWorked > 40)
            { 
            double overtime = hoursWorked - 40;
            pay = pay + (HourlyRate * overtime * .5);
            }
        
            return pay;
        }
    }
}
