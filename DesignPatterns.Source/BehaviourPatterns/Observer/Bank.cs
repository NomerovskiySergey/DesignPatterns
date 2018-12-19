using System;

namespace DesignPatterns.Source.BehaviourPatterns.Observer
{
    public class Bank : IListener
    {
        string _name { get; set; }
        IObservable _stock;

        public Bank(string name, IObservable obs)
        {
            _name = name;
            _stock = obs;
            _stock.RegisterListener(this);
        }

        public void Update(StockInfo info)
        {
            if (info.EURO > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", _name, info.EURO);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", _name, info.EURO);
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
