﻿using System;
using System.Collections.Generic;

namespace BankingSystem.ClassLib
{
    public class Bank
    {
        public List<IAccount> Accounts { get; private set; }
        public decimal Balance { get; set; }

        public Bank(decimal balance = 0)
        {
            Balance = balance;
            BootstrapAccounts();
        }

        private void BootstrapAccounts()
        {
            Accounts = new List<IAccount>()
            {
                new Account("44102000038758212314035006", 2000),
                new Account("24249000054689148053160684", 1500),
                new Account("44102000038758212314035006", 2000),
                new DebitAccount(new Account("53249000050041310232555755", 3500)),                
                new Account("53249000050041310232555754", 3500),
                new DebitAccount(new Account("53249000050041310232555756", 3500))
            };
        }

        public void DoOperation(IBankOperation operation)
        {
            operation.Execute(this);
        }

        public void PayInstallment(IAccount account, decimal installment)
        {
            var operation = new PayInstallment(installment);
            account.DoOperation(operation);
        }

        public void ReturnMoney(IAccount account, decimal moneyToReturn) 
        {
            var operation = new ReturnMoney(moneyToReturn);
            account.DoOperation(operation);
        }

        public void StoreMoney(IAccount account, decimal moneyToStore)
        {
            var operation = new StoreMoney(moneyToStore);
            account.DoOperation(operation);
        }

        public void TakeLoan(IAccount account, decimal amountOfLoan)
        {
            var operation = new TakeLoan(amountOfLoan);
            account.DoOperation(operation);
        }
    }
}
