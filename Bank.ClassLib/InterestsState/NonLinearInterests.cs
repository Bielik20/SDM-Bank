namespace Bank.ClassLib
{
    public class NonLinearInterests : IInterestState
    {
        public decimal Interest(Account account)
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
