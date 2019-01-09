namespace DesignPatterns.Source.BehaviourPatterns.Visitor
{
    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAc(Company acc);
    }
}
