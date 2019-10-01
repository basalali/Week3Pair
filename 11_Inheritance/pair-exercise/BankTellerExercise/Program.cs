using System;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount checkingAccount = new CheckingAccount();
            //BankAccount savingsAccount = new SavingsAccount();

            //decimal amountToDeposit = 100.00M;
            //decimal newBalance = checkingAccount.Deposit(amountToDeposit);

            //decimal amountToTransfer = 50.00M;
            //checkingAccount.Transfer(savingsAccount, amountToTransfer);

            //BankCustomer jayGatsby = new BankCustomer();
            //jayGatsby.AddAccount(checkingAccount);
            //jayGatsby.AddAccount(savingsAccount);

            //BankAccount checkingAccount = new CheckingAccount();
            //BankAccount savingsAccount = new SavingsAccount();

            //BankCustomer jayGatsby = new BankCustomer();
            //jayGatsby.AddAccount(checkingAccount);
            //jayGatsby.AddAccount(savingsAccount);

            //Console.WriteLine($"Jay Gatsby has {jayGatsby.Accounts.Length} accounts."); // Jay Gatsby has 2 accounts.

            //Console.WriteLine(checkingAccount.Balance);
            //Console.WriteLine(savingsAccount.Balance);

           

            //BankAccount newBA = new BankAccount();
            //BankAccount destinationAccount = new BankAccount();

            BankAccount checkingAccount = new CheckingAccount();
            BankAccount savingsAccount = new SavingsAccount();

            checkingAccount.Deposit(100);

            checkingAccount.Withdraw(101);

            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(10000);
            //newBA.Transfer(destinationAccount, 20);

            Console.WriteLine(checkingAccount.Balance);
            Console.WriteLine(savingsAccount.Balance);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
