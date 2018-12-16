using System;
using System.Runtime.CompilerServices;

namespace DesignPatterns.Source.BehaviourPatterns.Strategy
{
    public class Car
    {
        private int _numOfPassanger;
        private string _model;
        public IMovable MovingType { get; set; }

        public Car(int numOfPassanger, string model, IMovable movingType)
        {
            _numOfPassanger = numOfPassanger;
            _model = model;
            MovingType = movingType;
        }

        public void GetCharacteristic()
        {
            string movingType = MovingType.Move();
            Console.WriteLine($"Model: {_model} \r\nCar seats: {_numOfPassanger} " +
                              $"\r\nMoving type:{movingType}");
        }
    }
}
