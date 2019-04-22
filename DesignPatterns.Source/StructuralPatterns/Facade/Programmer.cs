namespace DesignPatterns.Source.StructuralPatterns.Facade
{
    class Programmer
    {
        public void CreateApplication(IIDEFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
