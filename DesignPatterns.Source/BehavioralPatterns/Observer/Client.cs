namespace DesignPatterns.Source.BehaviourPatterns.Observer
{
    public class Client: IClient
    {
        public void Run()
        {
            Stock stock = new Stock(new StockInfo());
            Bank bank = new Bank("ЮнитБанк", stock);
            Broker broker = new Broker("Иван Иваныч", stock);

            stock.Market();

            broker.Unsubscribe();

            stock.Market();

            broker.Subscribe();

            stock.Market();
        }
    }
}
