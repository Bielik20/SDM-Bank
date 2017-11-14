using Test;
using Xunit;

namespace Tests.OperationsTests
{
    public class StoreMoneyTests : TestData
    {
        [Fact]
        private void StoreMoneyInDeposit()
        {
            _testBank.StoreMoney(_testAccount, 200);
            Assert.Equal(1800, _testAccount.Balance);
            Assert.Equal(200, _testAccount.Deposit.Balance);
        }
    }
}
