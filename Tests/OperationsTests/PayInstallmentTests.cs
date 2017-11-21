using Xunit;
using Test;
using BankingSystem.ClassLib;

namespace Tests.OperationsTests
{
    public class PayInstallmentTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(TestDataClass))]
        private void PayInstallment(IAccount testAccount, Bank testBank)
        {
            decimal balanceBefore = testAccount.Balance;
            decimal loanBefore = testAccount.Loan;

            testBank.TakeLoan(testAccount, 800);
            testBank.PayInstallment(testAccount, 200);
            Assert.Equal(loanBefore + 600, testAccount.Loan);
            Assert.Equal(balanceBefore + 600, testAccount.Balance);
        }
    }
}
