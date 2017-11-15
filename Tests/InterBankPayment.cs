
using Xunit;
using Test;
using BankingSystem.ClassLib;

namespace Tests
{
    public class InterBankPaymentTests
    {
        [Fact]
        private void InterBankPayment()
        {
            var sourceBank = new Bank(500);
            var targetBank = new Bank(1000);
            var interBankPayment = new InterBankPayment(100, targetBank);
            sourceBank.DoOperation(interBankPayment);
            Assert.Equal(400, sourceBank.Balance);
            Assert.Equal(1100, targetBank.Balance);
        }
    }
}
