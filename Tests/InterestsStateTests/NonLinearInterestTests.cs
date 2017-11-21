using BankingSystem.ClassLib;
using Test;
using Xunit;

namespace Tests.InterestsStateTests
{
    public class NonLinearInterestTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(TestDataClass))]
        private void CalculateNonLinearInterest(IAccount testAccount, Bank testBank)
        {
            testAccount.SwitchToNonLinearInterest();
            testBank.TakeLoan(testAccount, 800);
            Assert.NotNull(testAccount.Interest);
        }
    }
}
