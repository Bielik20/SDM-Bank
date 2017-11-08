using System;

namespace Bank.ClassLib
{
    public class RandInterests : IInterestState
    {
        public decimal Interest(Account account)
        {
            var rand = new Random();
            var coefficient = rand.Next(0, 100) / 100.0;
            System.Console.WriteLine("Feeling Lucky? = " + coefficient);
            return account.Loan * (decimal)coefficient;
        }
    }
}
