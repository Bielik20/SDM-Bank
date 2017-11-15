using System;

namespace BankingSystem.ClassLib
{
    public class DebitAccount: IAccount
    {
        private IAccount _account;
        
        public decimal Balance 
        {
            get { return _account.Balance; }
            set { _account.Balance = value; }
        }
        public decimal Loan
        {
            get { return _account.Loan; }
            set { _account.Loan = value; }
        }
        public Deposit Deposit 
        {
            get { return _account.Deposit; }
            set { _account.Deposit = value; }
        }
        public decimal Interest
        {
            get { return _account.Interest; }
        }


        public DebitAccount(IAccount account)
        {
            _account = account;
        }

        public void DoOperation(IOperation operation)
        {
            operation.Execute(this);
        }

        public void SwitchToLinearInterests()
        {
            _account.SwitchToLinearInterests();
        }

        public void SwitchToNonLinearInterest()
        {
            _account.SwitchToNonLinearInterest();
        }

        public void SwitchToRandInterest()
        {
            _account.SwitchToRandInterest();
        }

        public void Display()
        {
            _account.Display();
        }
    }
}
