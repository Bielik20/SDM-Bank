using BankingSystem.ClassLib;
using System;
using System.Collections.Generic;
using System.Text;
using Test;
using Xunit;

namespace Tests.OperationsTests
{
    public class ReturnMoneyTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(TestDataClass))]
        private void ReturnMoney(IAccount testAccount, Bank testBank)
        {
            decimal balanceBefore = testAccount.Balance;
            decimal depositBefore = testAccount.Deposit.Balance;

            testBank.StoreMoney(testAccount, 500);
            testBank.ReturnMoney(testAccount, 100);
            Assert.Equal(depositBefore + 400, testAccount.Deposit.Balance);
            Assert.Equal(balanceBefore - 400, testAccount.Balance);
        }
    }
}
