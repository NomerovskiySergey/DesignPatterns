namespace DesignPatterns.Source.BehaviourPatterns.Observer
{
    public interface IObservable
    {
        void RegisterListener(IListener listener);
        void RemoveListener(IListener listener);
        void NotifyListener();
    }
}
