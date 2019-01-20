using DesignPatterns.Source.CreationalPatterns.Builder.CarPart;
using DesignPatterns.Source.CreationalPatterns.Builder.Interface;

namespace DesignPatterns.Source.CreationalPatterns.Builder
{
    class FamilyCarBulder : ICarBuilder
    {
        public ICar Car { get; set; }

        public FamilyCarBulder()
        {
            Car = new Car();
        }
        public void SetSeats()
        {
            Car.Seat = new Seat() { Count = 8 };
        }

        public void SetEngine()
        {
            Car.Engine = new StandartEngine();
        }

        public void SetTripComputer()
        {
            Car.TripComputer = new StandartTripComputer();
        }
    }
}
