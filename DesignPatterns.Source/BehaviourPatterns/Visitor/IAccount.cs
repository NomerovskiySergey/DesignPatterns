namespace DesignPatterns.Source.BehaviourPatterns.Visitor
{
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
