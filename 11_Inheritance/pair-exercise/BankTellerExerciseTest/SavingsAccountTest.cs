using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExercise.Tests
{
    [TestClass]
    public class SavingsAccountTest
    {
        [TestMethod]
        public void Withdraw()
        {
            SavingsAccount savingsAccount = new SavingsAccount();

            savingsAccount.Deposit(100);

            decimal result = savingsAccount.Withdraw(50);
            Assert.AreEqual(48, result);

            //result = savingsAccount.Withdraw(48);

            result = savingsAccount.Deposit(1000-result);
            result = savingsAccount.Withdraw(1001);
            Assert.AreEqual(1000, result);

            result = savingsAccount.Withdraw(500);
            Assert.AreEqual(500, result);







        }

    }
}
