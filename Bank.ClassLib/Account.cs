using System;

namespace Bank.ClassLib
{
    public class Account
    {
        public readonly string Id;
        public decimal Balance { get; set; } = 0;
        public decimal Loan { get; set; } = 0;
        public Deposit Deposit { get; set; } = new Deposit();

        public Account(string id, decimal balance = 0)
        {
            Id = id;
            Balance = balance;
        }

        public void DoOperation(IOperation operation) 
        {
            operation.Execute(this);
        }

        public void Display() 
        {
            Console.WriteLine("########################");            
            Console.WriteLine("Balance = " + Balance);
            Console.WriteLine("Loan = " + Loan);
            Console.WriteLine("Deposit = " + Deposit.Balance);            
        }
    }
}
