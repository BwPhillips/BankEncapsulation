using System;
using System.Collections.Generic;

namespace BankEncapsulationConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank You! Your new balance is now {account.GetBalance(), 0:c}");

            var accountInfo = new PersonalInformation();

            Console.WriteLine("What is your phone number starting with the area code?");

            accountInfo.NumberFormatted = Console.ReadLine();

            Console.WriteLine($"Your new phone number {accountInfo.NumberFormatted}.");


        }
    }
}
