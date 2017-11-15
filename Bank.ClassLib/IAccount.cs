using System;

namespace BankingSystem.ClassLib
{
    public interface IAccount
    {
        decimal Balance { get; set; }
        decimal Loan { get; set; }
        Deposit Deposit { get; set; }

        decimal Interest { get; }

        void DoOperation(IOperation operation);

        void SwitchToLinearInterests();

        void SwitchToNonLinearInterest();

        void SwitchToRandInterest();
    }
}
