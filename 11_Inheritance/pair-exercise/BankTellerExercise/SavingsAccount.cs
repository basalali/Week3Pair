using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class SavingsAccount : BankAccount
    {

        public override decimal Withdraw(decimal amountToWithdraw)
        {
         if (Balance < 150.00M)
            {
                 base.Withdraw(amountToWithdraw + 2.00M);/* - 2.00M;*/
                  
            }
         else if (amountToWithdraw <= Balance)
            {
                base.Withdraw(amountToWithdraw);
            }
            return base.Balance;
        }

    }
}
