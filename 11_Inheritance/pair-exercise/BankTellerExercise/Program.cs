﻿using System;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checkingAccount = new CheckingAccount();
            BankAccount savingsAccount = new SavingsAccount();

            decimal amountToDeposit = 100.00M;
            decimal newBalance = checkingAccount.Deposit(amountToDeposit);

            decimal amountToTransfer = 50.00M;
            checkingAccount.Transfer(savingsAccount, amountToTransfer);

            Console.WriteLine(checkingAccount.Balance);
            Console.WriteLine(savingsAccount.Balance);

            Console.ReadLine();

            //BankAccount newBA = new BankAccount();
            //BankAccount destinationAccount = new BankAccount();

            //newBA.Deposit(100);

            //newBA.Withdraw(50);
            //newBA.Transfer(destinationAccount, 20);

            //Console.WriteLine(newBA.Balance);
            //Console.WriteLine(destinationAccount.Balance);


            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
        }
    }
}
