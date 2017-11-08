namespace BankingSystem.Console
{
    using System;
    using BankingSystem.ClassLib;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            Console.ReadKey();
        }
    }
}
