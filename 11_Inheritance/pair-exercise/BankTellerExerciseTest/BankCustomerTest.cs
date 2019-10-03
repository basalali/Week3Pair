using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace BankTellerExerciseTest
namespace BankTellerExercise.Tests
{
    [TestClass]
    public class BankCustomerTest
    {
        [TestMethod]
        public void AddAccount()
        {
            //Arrange
            BankCustomer John = new BankCustomer(); //one bank customer
            BankAccount newAccount = new BankAccount(); //one account that we will be adding for him
            BankAccount vacationFund = new BankAccount(); //an additional account we will be adding for him

            //AddAccount is a void method, and we can't seem to compare the List that it creates directly
            //HOWEVER the property Accounts creates an array from that list. If the List wasn't working, the Array wouldn't either. 
            //So we are going to approach testing this method by examining the array, not the list..

            //Assert.AreEqual(0, bankCustomer.Accounts.Length);//the array starts with no contents, because we haven't added an account yet!!

            //Act
            John.AddAccount(newAccount);

           
            BankAccount[] result = { newAccount }; //expected answer

            CollectionAssert.AreEqual(John.Accounts, result);

            //Act
            John.AddAccount(vacationFund); // added to John's array of accounts
            BankAccount[] expectedResult = { newAccount, vacationFund }; //made a fake array of account to compare that to
            CollectionAssert.AreEqual(John.Accounts, expectedResult); //Assert! compared the two arrays


               }

        }
}
