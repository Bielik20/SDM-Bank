namespace BankingSystem.ClassLib
{
    public class ReturnMoney : IOperation
    {
        private decimal _moneyToReturn;

        public ReturnMoney(decimal moneyToReturn)
        {
            _moneyToReturn = moneyToReturn;
        }

        public void Execute(IAccount account)
        {
            account.Deposit.Balance -= _moneyToReturn;
            account.Balance += _moneyToReturn;
        }
    }
}

// decimal TakeLoan(decimal amount_of_loan);
