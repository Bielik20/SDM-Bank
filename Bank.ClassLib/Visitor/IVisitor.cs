namespace BankingSystem.ClassLib
{
    public interface IReportVisitor
    {
        void Visit(Account visitee);
        void Visit(DebitAccount visitee);
    }

    public interface IReportVisitee
    {
        void Accept(IReportVisitor visitor);
    }
}
