using Test;
using Xunit;

namespace Tests.InterestsStateTests
{
    public class LinearInterestTests : TestData
    {
        [Fact]
        private void CalculateLinearInterest()
        {
            _testBank.TakeLoan(_testAccount, 500);
            Assert.Equal(50, _testAccount.Interest);
        }
    }
}
