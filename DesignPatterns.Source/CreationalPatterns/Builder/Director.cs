using DesignPatterns.Source.CreationalPatterns.Builder.Interface;

namespace DesignPatterns.Source.CreationalPatterns.Builder
{
    class Director
    {
        private ICarBuilder _builder;

        public Director(ICarBuilder bulder)
        {
            _builder = bulder;
        }
        public void BuildSportCar()
        {
            _builder.SetTripComputer();
            _builder.SetSeats();
            _builder.SetEngine();
        }

        public void BuildFamilyCar()
        {
            _builder.SetTripComputer();
            _builder.SetSeats();
            _builder.SetEngine();
        }

        public ICar ReturnCar()
        {
            return _builder.Car;
        }
    }
}
