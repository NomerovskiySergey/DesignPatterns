namespace DesignPatterns.Source.BehaviourPatterns.Memento
{
    public class Client: IClient
    {
        public void Run()
        {
            Hero hero = new Hero();
            hero.Shoot(); 

            GameHistory game = new GameHistory();
            game.History.Push(hero.SaveState());

            hero.Shoot();
            hero.RestoreState(game.History.Pop());
            hero.Shoot();
        }
    }
}
