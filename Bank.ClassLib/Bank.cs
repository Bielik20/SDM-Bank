using System;
using System.Collections.Generic;

namespace BankingSystem.ClassLib
{
    public class Bank
    {
        public List<Account> Accounts { get; private set; }
        public int Balance { get; private set; }

        public Bank()
        {
            BootstrapAccounts();
        }

        private void BootstrapAccounts()
        {
            Accounts = new List<Account>()
            {
                new Account("44102000038758212314035006", 2000),
                new Account("24249000054689148053160684", 1500),
                new Account("44102000038758212314035006", 2000),
                new Account("53249000050041310232555754", 3500)
            };
        }

        public void PayInstallment(Account account, decimal installment)
        {
            var operation = new PayInstallment(installment);
            account.DoOperation(operation);
        }

        public void ReturnMoney(Account account, decimal moneyToReturn) 
        {
            var operation = new ReturnMoney(moneyToReturn);
            account.DoOperation(operation);
        }

        public void StoreMoney(Account account, decimal moneyToStore)
        {
            var operation = new StoreMoney(moneyToStore);
            account.DoOperation(operation);
        }

        public void TakeLoan(Account account, decimal amountOfLoan)
        {
            var operation = new TakeLoan(amountOfLoan);
            account.DoOperation(operation);
        }
    }
}
