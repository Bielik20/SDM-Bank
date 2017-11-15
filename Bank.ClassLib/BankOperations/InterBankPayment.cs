namespace BankingSystem.ClassLib
{
    public class InterBankPayment : IBankOperation
    {
        private decimal _amountToPay;
        private Bank _targetBank;

        public InterBankPayment(decimal amountToPay, Bank targetBank)
        {
            _amountToPay = amountToPay;
            _targetBank = targetBank;
        }

        public void Execute(Bank sourceBank)
        {
            sourceBank.Balance -= _amountToPay;
            _targetBank.Balance += _amountToPay;
        }
    }
}
