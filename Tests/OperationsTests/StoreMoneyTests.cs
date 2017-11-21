using BankingSystem.ClassLib;
using Test;
using Xunit;

namespace Tests.OperationsTests
{
    public class StoreMoneyTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(TestDataClass))]
        private void StoreMoneyInDeposit(IAccount testAccount, Bank testBank)
        {
            decimal balanceBefore = testAccount.Balance;
            decimal depositBefore = testAccount.Deposit.Balance;

            testBank.StoreMoney(testAccount, 200);
            Assert.Equal(depositBefore + 200, testAccount.Deposit.Balance);
            Assert.Equal(balanceBefore - 200, testAccount.Balance);
        }
    }
}
