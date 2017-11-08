using BankingSystem.ClassLib;
using Xunit;

namespace Test
{
    public class AccountTests
    {
        private Bank _testBank = new Bank();
        private Account _testAccount = new Account("44102000038758212314035006", 2000);

        [Fact]
        private void StoringMoneyInDeposit()
        {
            _testBank.StoreMoney(_testAccount, 200);
            Assert.Equal(1800, _testAccount.Balance);
            Assert.Equal(200, _testAccount.Deposit.Balance);
        }

        [Fact]
        private void ReturnMoney()
        {
            _testBank.StoreMoney(_testAccount, 500);
            _testBank.ReturnMoney(_testAccount, 100);
            Assert.Equal(400, _testAccount.Deposit.Balance);
            Assert.Equal(1600, _testAccount.Balance);
        }

        [Fact]
        private void TakeLoan()
        {
            _testBank.TakeLoan(_testAccount, 500);
            Assert.Equal(500, _testAccount.Loan);
            Assert.Equal(2500, _testAccount.Balance);
        }

        [Fact]
        private void PayInstallment()
        {
            _testBank.TakeLoan(_testAccount, 800);
            _testBank.PayInstallment(_testAccount, 200);
            Assert.Equal(600, _testAccount.Loan);
            Assert.Equal(2600, _testAccount.Balance);
        }

        [Fact]
        private void CalculateLinearInterest()
        {
            _testBank.TakeLoan(_testAccount, 500);
            Assert.Equal(50, _testAccount.Interest);
        }

        [Fact]
        private void CalculateNonLinearInterest()
        {
            _testAccount.SwitchToNonLinearInterest();
            _testBank.TakeLoan(_testAccount, 800);
            Assert.InRange(_testAccount.Interest, 228, 229);
        }
    }
}