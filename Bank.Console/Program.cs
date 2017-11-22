namespace BankingSystem.Console
{
    using System;
    using System.Collections.Generic;
    using BankingSystem.ClassLib;

    class Program
    {
        static void Main(string[] args)
        {
            // OperationsInterest();

            // InterBankPayment();

            // Visitor();

            // GenericVisitor();

            Console.ReadKey();
        }

        private static void GenericVisitor()
        {
            var list = new List<IVisitee>
            {
                new ConcreteVisitee1(),
                new ConcreteVisitee2(),
                new ConcreteVisitee1(),                
            };
            var visitor = new ConcreteVisitor();

            foreach(var visitee in list) 
            {
                visitee.Accept(visitor);
            }
        }

        private static void Visitor()
        {
            var bank = new Bank();
            var visitor = new ReportVisitor();

            foreach(IReportVisitee account in bank.Accounts) 
            {
                account.Accept(visitor);
            }
            visitor.PrintReport();
        }

        private static void OperationsInterest()
        {
            var bank = new Bank();

            var account = bank.Accounts[0];
            account.Display();

            bank.StoreMoney(account, 200);
            account.Display();

            bank.ReturnMoney(account, 100);
            account.Display();

            bank.TakeLoan(account, 500);
            account.Display();

            bank.PayInstallment(account, 300);
            account.Display();

            Console.WriteLine($"Linear interest. Loan cost = {account.Interest}");
            account.SwitchToNonLinearInterest();
            Console.WriteLine($"Nonlinear interest. Loan cost = {account.Interest}");
            account.SwitchToRandInterest();
            Console.WriteLine($"Random interest. Loan cost = {account.Interest}");
        }

        private static void InterBankPayment()
        {
            var sourceBank = new Bank(500);
            var targetBank = new Bank(1000);
            var interBankPayment = new InterBankPayment(100, targetBank);
            sourceBank.DoOperation(interBankPayment);
            System.Console.WriteLine(sourceBank.Balance);
            System.Console.WriteLine(targetBank.Balance);
        }
    }
}
