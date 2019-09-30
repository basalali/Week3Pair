using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class SavingsAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
         if (Balance < 150.00M)
            {
                Balance = Balance - amountToWithdraw - 2.00M;
                  
            }
         else if (amountToWithdraw > Balance)
            {
                Balance = Balance;
            }
         else
            {
                Balance = Balance - amountToWithdraw;
            }
            return Balance;
        }

    }
}
