using System;
namespace BankEncapsulationConsole
{
    public class BankAccount
    {
        //Field = class local variable
        private double balance = 0;

        //Example of a Property
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }

        }

        //Encapsulation
        public void Deposit(double ammount)
        {
            balance = ammount;
        }

        public double GetBalance()
        {
            return balance;
        }







        public BankAccount()
        {
        }
    }
}
