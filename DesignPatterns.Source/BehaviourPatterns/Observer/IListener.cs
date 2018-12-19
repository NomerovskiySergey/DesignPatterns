using System;

namespace DesignPatterns.Source.BehaviourPatterns.Observer
{
    public interface IListener
    {
        void Update(StockInfo info);
        void Unsubscribe();
        void Subscribe();
    }
}
