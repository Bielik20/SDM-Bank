namespace BankingSystem.ClassLib
{
    public class PayInstallment : IOperation
    {
        private decimal _installment;

        public PayInstallment(decimal installment)
        {
            _installment = installment;
        }

        public void Execute(IAccount account)
        {
            account.Loan -= _installment;
            account.Balance -= _installment;
        }
    }
}

// decimal StoreMoney(decimal moneyToStore);
// decimal ReturnMoney();
// decimal TakeLoan(decimal amount_of_loan);
