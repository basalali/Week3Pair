using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExercise.Tests
{
    [TestClass]
    public class BankAccounTest
    {
        [TestMethod]
        public void DepositTest()
        {
            BankAccount bankAccount = new BankAccount();

            decimal result = bankAccount.Deposit(1000);

            Assert.AreEqual(1000, result);

            result = bankAccount.Deposit(0);

            Assert.AreEqual(1000, result);
            
        }

        [TestMethod]
        public void WithdrawTest()
        {
            BankAccount bankAccount = new BankAccount();

            decimal result = bankAccount.Deposit(1000);
            result = bankAccount.Withdraw(500);

            Assert.AreEqual(500, result);

            result = bankAccount.Withdraw(250);

            Assert.AreEqual(250, result);

        }

        [TestMethod]
        public void TransferTest()
        {
            BankAccount  homeAccount = new BankAccount();
            BankAccount destinationAccount = new BankAccount();

           homeAccount.Deposit(1000);
           homeAccount.Transfer(destinationAccount, 500);

            decimal result = destinationAccount.Balance;

            Assert.AreEqual(500, result);

           

        }


    }
}
