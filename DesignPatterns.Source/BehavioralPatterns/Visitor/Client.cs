namespace DesignPatterns.Source.BehaviourPatterns.Visitor
{
    public class Client : IClient
    {
        public void Run()
        {
            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });

            structure.Accept(new HtmlVisitor());
        }
    }
}
