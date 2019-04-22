namespace DesignPatterns.Source.StructuralPatterns.Bridge
{
    public class Client : IClient
    {
        public void Run()
        {
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();

            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();
        }
    }
}
