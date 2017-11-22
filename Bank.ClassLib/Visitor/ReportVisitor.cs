using System;

namespace BankingSystem.ClassLib
{
    public class ReportVisitor : IReportVisitor
    {
        public int DebitAccountCount { get; private set; }
        public int AccountCount { get; private set; }

        public void Visit(DebitAccount visitee)
        {
            DebitAccountCount++;
        }

        public void Visit(Account visitee)
        {
            AccountCount++;
        }

        public void PrintReport() 
        {
            var total = DebitAccountCount + AccountCount * 1.0;
            System.Console.WriteLine($"There are {total} IAccounts in Total");
            System.Console.WriteLine($"There is {Math.Round(DebitAccountCount/total * 100)}% of Debit Accounts");
            System.Console.WriteLine($"There is {Math.Round(AccountCount/total * 100)}% of Accounts");                    
        }
    }
}
