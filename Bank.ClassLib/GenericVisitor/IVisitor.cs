namespace BankingSystem.ClassLib
{
    public interface IVisitor
    {
        void Visit<T>(T visitee) where T: IVisitee;
        // void Visit(IVisitee visitee);
        
    }

    public interface IVisitee
    {
        void Accept(IVisitor visitor);
    }

    public class ConcreteVisitor : IVisitor
    {

        public void Visit(ConcreteVisitee1 visitee)
        {
            System.Console.WriteLine("1");
        }

        public void Visit(ConcreteVisitee2 visitee)
        {
            System.Console.WriteLine("2");
        }

        void IVisitor.Visit<T>(T visitee)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ConcreteVisitee1 : IVisitee
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ConcreteVisitee2 : IVisitee
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
