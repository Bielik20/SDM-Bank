using System;

namespace BankingSystem.ClassLib
{
    public class RandInterest : IInterestState
    {
        public decimal Interest(IAccount account)
        {
            var rand = new Random();
            var coefficient = rand.Next(0, 100) / 100.0;
            System.Console.WriteLine("Feeling Lucky? = " + coefficient);
            return account.Loan * (decimal)coefficient;
        }
    }
}
