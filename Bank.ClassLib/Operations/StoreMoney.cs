namespace BankingSystem.ClassLib
{
    public class StoreMoney : IOperation
    {
        private decimal _moneyToStore;

        public StoreMoney(decimal moneyToStore)
        {
            _moneyToStore = moneyToStore;
        }

        public void Execute(IAccount account)
        {
            account.Deposit.Balance += _moneyToStore;
            account.Balance -= _moneyToStore;
        }
    }
}

// decimal ReturnMoney();
// decimal TakeLoan(decimal amount_of_loan);
