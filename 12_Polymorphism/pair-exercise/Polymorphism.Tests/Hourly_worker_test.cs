using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePayroll.CLasses
{
    [TestClass]
    public class Hourly_worker_test
    {
        //we just caught on to The_naming_convention_for_tests
        //So this is our first test class not in PascalCase...

        [TestMethod]
        public void Calculate_weekly_pay_test()
        {
            HourlyWorker newWorker = new HourlyWorker(15, "Mickey", "Mouse"); //Arrange

            double result = newWorker.CalculateWeeklyPay(40);//Act

            Assert.AreEqual(600, result);//Assert

            result = newWorker.CalculateWeeklyPay(13);
            Assert.AreEqual(195, result);
            //this test actually revealed an issue with our code!
            //We fixed it by adding a conditional to the overtime calculation.
            //Now the overtime calculation won't happen UNLESS the hours worked are more than 40

            result = newWorker.CalculateWeeklyPay(0);
            Assert.AreEqual(0, result);
        }
    }
}
