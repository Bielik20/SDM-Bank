
using Xunit;
using Test;
using BankingSystem.ClassLib;

namespace Tests
{
    public class ReportVisitorTest
    {
        [Fact]
        private void ReportVisitor()
        {
            var bank = new Bank();
            var visitor = new ReportVisitor();

            foreach(IReportVisitee account in bank.Accounts) 
            {
                account.Accept(visitor);
            }

            Assert.Equal(2, visitor.DebitAccountCount);
            Assert.Equal(4, visitor.AccountCount);
        }
    }
}
