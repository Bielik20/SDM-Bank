using BankingSystem.ClassLib;
using Test;
using Xunit;

namespace Tests.InterestsStateTests
{
    public class LinearInterestTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(TestDataClass))]
        private void CalculateLinearInterest(IAccount testAccount, Bank testBank)
        {
            testAccount.SwitchToLinearInterests();
            testBank.TakeLoan(testAccount, 500);
            decimal computedInterest = testAccount.Loan * (decimal)0.1;
            Assert.Equal(computedInterest, testAccount.Interest);
        }
    }
}
