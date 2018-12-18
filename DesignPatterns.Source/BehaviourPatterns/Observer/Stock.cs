using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Source.BehaviourPatterns.Observer
{
    public class Stock: IObservable
    {
        private StockInfo _info;
        private List<IListener> _listeners;

        public Stock(StockInfo info)
        {
            _info = info;
            _listeners = new List<IListener>();
        }

        public void RegisterListener(IListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            _listeners.Remove(listener);
        }

        public void NotifyListener()
        {
            foreach (var listener in _listeners)
            {
                listener.Update(_info);
            }
        }

        public void Market()
        {
            Random rand = new Random();
            _info.EURO = rand.Next(20, 40);
            _info.USD = rand.Next(30, 50);

            NotifyListener();
        }
    }
}
