using System;

namespace DesignPatterns.Source.BehaviourPatterns.Observer
{
    public class Broker: IListener
    {
        string _name { get; set; }
        IObservable _stock;

        public Broker(string name, IObservable obs)
        {
            _name = name;
            _stock = obs;
            _stock.RegisterListener(this);
        }

        public void Update(StockInfo info)
        {
            if (info.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", _name, info.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", _name, info.USD);
        }

        public void Unsubscribe()
        {
            _stock.RemoveListener(this);
        }

        public void Subscribe()
        {
            _stock.RegisterListener(this);
        }
    }
}
