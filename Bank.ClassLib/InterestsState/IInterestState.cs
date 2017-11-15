namespace BankingSystem.ClassLib
{
    public interface IInterestState
    {
        decimal Interest(IAccount account);
    }
}
