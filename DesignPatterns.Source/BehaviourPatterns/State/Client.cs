using System;

namespace DesignPatterns.Source.BehaviourPatterns.State
{
    public class Client: IClient
    {
        public void Run()
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();
        }
    }
}
