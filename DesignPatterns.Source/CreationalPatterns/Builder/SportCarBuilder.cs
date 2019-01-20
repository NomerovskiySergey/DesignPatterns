using System;
using DesignPatterns.Source.CreationalPatterns.Builder.CarPart;
using DesignPatterns.Source.CreationalPatterns.Builder.Interface;

namespace DesignPatterns.Source.CreationalPatterns.Builder
{
    class SportCarBuilder: ICarBuilder
    {
        public ICar Car { get; set; }


        public SportCarBuilder()
        {
            Car = new Car();
        }
        public void SetSeats()
        {
            Car.Seat = new Seat() {Count = 2};
        }

        public void SetEngine()
        {
           Car.Engine = new SportEngine();
        }

        public void SetTripComputer()
        {
            Car.TripComputer = new SportTripComputer();
        }
    }
}
