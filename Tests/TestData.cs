using BankingSystem.ClassLib;

namespace Test
{
    public class TestData
    {
        protected Bank _testBank = new Bank();
        // protected Account _testAccount = new Account("44102000038758212314035006", 2000);
        protected IAccount _testAccount = new DebitAccount(new Account("44102000038758212314035006", 2000));
    }
}
