using System;
namespace DesignPatterns.Source.BehaviourPatterns.State
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
