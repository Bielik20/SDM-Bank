using System;
using System.Collections.Generic;

namespace Bank.ClassLib
{
    public class Bank
    {
        public IEnumerable<Account> Accounts { get; private set; }
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
    }
}
