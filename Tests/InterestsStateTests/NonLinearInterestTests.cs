using Test;
using Xunit;

namespace Tests.InterestsStateTests
{
    public class NonLinearInterestTests : TestData
    {
        [Fact]
        private void CalculateNonLinearInterest()
        {
            _testAccount.SwitchToNonLinearInterest();
            _testBank.TakeLoan(_testAccount, 800);
            Assert.InRange(_testAccount.Interest, 228, 229);
        }
    }
}
