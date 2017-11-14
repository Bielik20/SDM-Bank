using Test;
using Xunit;

namespace Tests.OperationsTests
{
    public class TakeLoanTests : TestData
    {
        [Fact]
        private void TakeLoan()
        {
            _testBank.TakeLoan(_testAccount, 500);
            Assert.Equal(500, _testAccount.Loan);
            Assert.Equal(2500, _testAccount.Balance);
        }
    }
}
