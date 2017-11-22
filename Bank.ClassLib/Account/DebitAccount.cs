using System;

namespace BankingSystem.ClassLib
{
    public class DebitAccount: IAccount, IReportVisitee
    {
        public decimal Balance 
        {
            get { return _account.Balance; }
            set 
            { 
                if (value >= -_limit)
                    _account.Balance = value; 
                else
                    throw new Exception("Not enough money. Over the limit.");
            }
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

        private IAccount _account;
        private decimal _limit;

        public DebitAccount(IAccount account, decimal limit = 0)
        {
            _account = account;
            _limit = limit;
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

        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
