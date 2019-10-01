using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
   public class BankAccount
    {
        public BankAccount()
        {
            Balance = 0M;
        }

        public string AccountNumber
        {
            get { return AccountNumber; }
            set { }
        }
        public decimal Balance { get; protected set; } = 0;
        // balance begins at 0


        //do we need Balance to be literally "private"? 
        //that's how it is listed in the README, but "protected" seems more appropriate
        //**** or we can use base. when we call this in CheckingAccount

        public decimal Deposit(decimal amountToDeposit)
        {
            Balance = amountToDeposit + Balance;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance = Balance - amountToWithdraw;
            return Balance;
        }


        public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            destinationAccount.Balance = destinationAccount.Balance + transferAmount;
            Balance = Balance - transferAmount;
        }



    }
}
