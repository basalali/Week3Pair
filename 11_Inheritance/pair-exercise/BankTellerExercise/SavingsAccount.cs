using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class SavingsAccount : BankAccount
    {
        public decimal savingsBalance = 0;

        public override decimal Withdraw(decimal amountToWithdraw)
        {
         if (Balance < 150.00M)
            {
                savingsBalance = base.Withdraw(amountToWithdraw) - 2.00M;
                  
            }
         else if (amountToWithdraw > Balance)
            {
                savingsBalance = Balance;
            }
         else
            {
                savingsBalance = base.Withdraw(amountToWithdraw);
            }
            return savingsBalance;
        }

    }
}
