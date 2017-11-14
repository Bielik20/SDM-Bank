using System;
using System.Collections.Generic;
using System.Text;
using Test;
using Xunit;

namespace Tests.OperationsTests
{
    public class ReturnMoneyTests : TestData
    {
        [Fact]
        private void ReturnMoney()
        {
            _testBank.StoreMoney(_testAccount, 500);
            _testBank.ReturnMoney(_testAccount, 100);
            Assert.Equal(400, _testAccount.Deposit.Balance);
            Assert.Equal(1600, _testAccount.Balance);
        }
    }
}
