namespace BankingSystem.ClassLib
{
    public class NonLinearInterest : IInterestState
    {
        public decimal Interest(IAccount account)
        {
            if (account.Balance == 0 || account.Loan > account.Balance)
            {
                return account.Loan;
            }
            var coefficient = account.Loan / account.Balance;
            return account.Loan * coefficient;
        }
    }
}
