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
    }
}
