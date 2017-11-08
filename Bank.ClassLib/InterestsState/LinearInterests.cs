namespace Bank.ClassLib
{
    public class LinearInterests : IInterestState
    {
        public decimal Interest(Account account)
        {
            return account.Loan * (decimal)0.1;
        }
    }
}
