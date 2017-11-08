namespace BankingSystem.ClassLib
{
    public class LinearInterest : IInterestState
    {
        public decimal Interest(Account account)
        {
            return account.Loan * (decimal)0.1;
        }
    }
}
