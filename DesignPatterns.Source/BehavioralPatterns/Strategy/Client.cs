namespace DesignPatterns.Source.BehaviourPatterns.Strategy
{
    public class Client : IClient
    {
        public void Run()
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.GetCharacteristic();
            auto.MovingType = new ElectonicMove();
            auto.GetCharacteristic();
        }
    }
}
