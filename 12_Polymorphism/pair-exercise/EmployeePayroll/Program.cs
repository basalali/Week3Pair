using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayroll.CLasses;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryWorker Mickey = new SalaryWorker(100000, "Mickey", "Mouse");

            List<IWorker> workers = new List<IWorker> { Mickey, new HourlyWorker(15, "Donald", "Duck"), new VolunteerWorker("George (Goofy)","Geef" ), new SalaryWorker(200000, "Minnie", "Mouse") };

            double totalHours = 0;
            double totalPay = 0;

            Console.WriteLine("Employee Name".PadRight(30) + "Hours Worked".PadRight(20) + "Pay");
            Console.WriteLine("~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*~=*");
            

            foreach (IWorker worker in workers)
            {
                Random randomNum = new Random();
                int hoursWorked = randomNum.Next(0, 100);
                //making hoursWorked a new random number each iteration of the loop

                double pay = 0;
                //pay starts at 0

                pay = worker.CalculateWeeklyPay(hoursWorked);

                totalHours = totalHours + hoursWorked;
                totalPay = totalPay + pay;
                //this adds to the total hours and total pay for each iteration of the loop

                string stringHoursWorked = hoursWorked.ToString();
                //making a new string for hoursWorked, so that we can make our table pretty with PadRight()

                Console.WriteLine(worker.LastName + ", " + worker.FirstName.PadRight(30) + stringHoursWorked.PadRight(20) + " $" + pay);

                //our table could be more beautiful, but it functions as needed at this time :)
            }
            Console.WriteLine();
            Console.WriteLine("Total Hours: " + totalHours);
            Console.WriteLine("Total Pay: " + totalPay);

            Console.ReadLine();
        }
    }
}
