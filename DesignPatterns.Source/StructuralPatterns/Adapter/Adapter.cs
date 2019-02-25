namespace DesignPatterns.Source.StructuralPatterns.Adapter
{
    class Adapter: ITransport
    {
        private IAnimal _animal;

        public Adapter(IAnimal animal)
        {
            _animal = animal;
        }
        public void Drive()
        {
           _animal.Move();
        }
    }
}
