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

        public decimal Balance { get; private set; } = 0;
        // balance begins at 0

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
