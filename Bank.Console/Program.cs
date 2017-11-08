namespace Bank.Console
{
    using System;
    using Bank.ClassLib;

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

            System.Console.WriteLine(account.Interest);
        }
    }
}
