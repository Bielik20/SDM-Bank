using Xunit;
using Test;

namespace Tests.OperationsTests
{
    public class PayInstallmentTests : TestData
    {
        [Fact]
        private void PayInstallment()
        {
            _testBank.TakeLoan(_testAccount, 800);
            _testBank.PayInstallment(_testAccount, 200);
            Assert.Equal(600, _testAccount.Loan);
            Assert.Equal(2600, _testAccount.Balance);
        }
    }
}
