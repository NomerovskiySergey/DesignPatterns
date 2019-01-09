using System.Collections.Generic;

namespace DesignPatterns.Source.BehaviourPatterns.Memento
{
    class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}
