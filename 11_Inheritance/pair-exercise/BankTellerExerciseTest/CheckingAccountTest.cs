using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace BankTellerExerciseTest
namespace BankTellerExercise.Tests
{
    [TestClass]
    public class CheckingAccountTest
    {
        [TestMethod]
        public void Withdraw()
        {
            CheckingAccount checkingAccount = new CheckingAccount();

            checkingAccount.Deposit(1000);
            //Balance starts at 0 for a new CheckingAccount, so we deposited some $$$ into the account so we could run our tests

            decimal result = checkingAccount.Withdraw(1100); //testing an attempt to overdraft by more than $100
            Assert.AreEqual(1000, result);


            checkingAccount.Deposit(1000 - result); //resets balance of account to 1000 after each assert
            result = checkingAccount.Withdraw(1050);//tests an overdraft, but not one more than $100. An overdraft fee of $10 is assessed.
            Assert.AreEqual(-60, result);

            checkingAccount.Deposit(1000 - result); //resets balance of account to 1000 after each assert
            result = checkingAccount.Withdraw(100); //"normal" withdraw
            Assert.AreEqual(900, result);
        }
    }
}
