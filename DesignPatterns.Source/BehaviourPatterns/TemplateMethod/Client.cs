namespace DesignPatterns.Source.BehaviourPatterns.TemplateMethod
{
    public class Client: IClient
    {
        public void Run()
        {
            Education edu = new School();
            edu.Learn();

            edu = new University();
            edu.Learn();
        }
    }
}
