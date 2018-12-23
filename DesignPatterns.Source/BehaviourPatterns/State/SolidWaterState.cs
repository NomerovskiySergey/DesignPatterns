using System;

namespace DesignPatterns.Source.BehaviourPatterns.State
{
    class SolidWaterState: IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем морозить лед");
        }
    }
}
