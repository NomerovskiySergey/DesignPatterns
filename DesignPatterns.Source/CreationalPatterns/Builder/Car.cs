using DesignPatterns.Source.CreationalPatterns.Builder.CarPart;
using DesignPatterns.Source.CreationalPatterns.Builder.Interface;

namespace DesignPatterns.Source.CreationalPatterns.Builder
{
    class Car: ICar
    {
        public ITripComputer TripComputer { set; private get; }
        public Seat Seat { private get; set; }
        public IEngine Engine { get; set; }

        public string Description()
        {
            return $"Описание автомобиля:" +
                   $"\r\nБортовой компьютер: {TripComputer.Description}" +
                   $"\r\nКоличество мест: {Seat.Count}" +
                   $"\r\nДвигатель: {Engine.Description}";
        }
    }
}
