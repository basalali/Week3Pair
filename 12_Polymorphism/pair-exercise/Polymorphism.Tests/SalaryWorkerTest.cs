using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePayroll.CLasses
{
    [TestClass]
    public class SalaryWorkTest
    {
        [TestMethod]
        public void CalculateWeeklyPayTest()
        {
            SalaryWorker salariedMoney = new SalaryWorker(65000, "Basal", "Ali");

            double actual = salariedMoney.CalculateWeeklyPay(60);
            Assert.AreEqual(1250, actual);
            // doesn't matter how many hour he/she works! their weekly pay is Annual Salary / 52 weeks!

            actual = salariedMoney.CalculateWeeklyPay(900);
            Assert.AreEqual(1250, actual);


        }
    }
}
