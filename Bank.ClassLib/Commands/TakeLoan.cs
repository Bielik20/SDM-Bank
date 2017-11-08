namespace Bank.ClassLib
{
    public class TakeLoan : IOperation
    {
        private decimal _amountOfLoan;

        public TakeLoan(decimal amountOfLoan)
        {
            _amountOfLoan = amountOfLoan;
        }

        public void Execute(Account account)
        {
            account.Loan += _amountOfLoan;
            account.Balance += _amountOfLoan;
        }
    }
}
