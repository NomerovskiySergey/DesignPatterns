using System;

namespace DesignPatterns.Source.BehaviourPatterns.State
{
    class GasWaterState: IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем водяной пар в воду");
            water.State = new LiquidWaterState();
        }
    }
}
