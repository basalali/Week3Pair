using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CheckingAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw <= -100 )
            {
                Balance = Balance;
            }

            else if (Balance < 0.00M)
            {
                Balance = Balance - 10.00M;
            }
            else
            {
                Balance = Balance - amountToWithdraw;
            }

            return Balance;

        }


    }
}

