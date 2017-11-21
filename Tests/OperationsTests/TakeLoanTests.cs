using BankingSystem.ClassLib;
using Test;
using Xunit;

namespace Tests.OperationsTests
{
    public class TakeLoanTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(TestDataClass))]
        private void TakeLoan(IAccount testAccount, Bank testBank)
        {
            decimal balanceBefore = testAccount.Balance;
            decimal loanBefore = testAccount.Loan;

            testBank.TakeLoan(testAccount, 500);
            Assert.Equal(loanBefore + 500, testAccount.Loan);
            Assert.Equal(balanceBefore + 500, testAccount.Balance);
        }
    }
}
