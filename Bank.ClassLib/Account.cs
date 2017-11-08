using System;

namespace Bank.ClassLib
{
    public class Account
    {
        public readonly string id;
        public decimal Balance { get; set; } = 0;
        public decimal Loan { get; set; } = 0;
        public Deposit Deposit { get; set; } = new Deposit();
        private IInterestState _interestState = new LinearInterests();

        public decimal Interest
        {
            get { return _interestState.Interest(this); }
        }


        public Account(string id, decimal balance = 0)
        {
            this.id = id;
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
