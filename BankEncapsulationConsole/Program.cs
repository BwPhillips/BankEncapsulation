using System;

namespace BankEncapsulationConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);
            Console.WriteLine($"Thank You! Your new balance is now {account.GetBalance()}");

                
        }
    }
}
