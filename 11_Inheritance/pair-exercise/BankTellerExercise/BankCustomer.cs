using System;
using System.Collections.Generic;
using System.Text;


namespace BankTellerExercise
{
    public class BankCustomer : BankAccount
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public BankAccount[] Accounts
        {
            get
            {
                BankAccount[] accountsArray = accountsList.ToArray();
                return accountsArray;
            }
        }

        
        decimal totalBalance = 0;

        public bool IsVIP
        {
            get
            {
                foreach(BankAccount account in accountsList)
                {
                    totalBalance = totalBalance + account.Balance;
                    if (totalBalance >= 25000)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        List<BankAccount> accountsList = new List<BankAccount>();
        

        public void AddAccount(BankAccount newAccount)
        {

            //made a new list of Bank Accounts called accountsList
            //we are making a List so that it can be added to, unlike an array
            //when an array is needed, the derived property Accounts will convert this list into an array!

            accountsList.Add(newAccount);
        }


    }
}
