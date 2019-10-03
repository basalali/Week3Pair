using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CheckingAccount : BankAccount
    {
        public decimal checkingBalance = 0;

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw <= -100 )
            {
               return Balance;
            }
            else if (Balance - amountToWithdraw < 0.00M)
            {
                /*decimal checkingBalance = */
                amountToWithdraw = amountToWithdraw + 10.00M;
                base.Withdraw(amountToWithdraw);
            }
            else
            {
                base.Withdraw(amountToWithdraw);
            }
            return Balance;
            //return checkingBalance;
        }


    }
}

