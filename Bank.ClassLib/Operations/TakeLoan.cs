namespace BankingSystem.ClassLib
{
    public class TakeLoan : IOperation
    {
        private decimal _amountOfLoan;

        public TakeLoan(decimal amountOfLoan)
        {
            _amountOfLoan = amountOfLoan;
        }

        public void Execute(IAccount account)
        {
            account.Loan += _amountOfLoan;
            account.Balance += _amountOfLoan;
        }
    }
}
