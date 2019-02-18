using System;
using Unity;

namespace DesignPatterns.Bootstrap
{
    public class Factory
    {
        private static readonly Lazy<Factory> _lazy =
            new Lazy<Factory>(() => new Factory());

        private IUnityContainer _container;

        private Factory()
        {
            _container = UnitySetup.GetContainer();
        }

        public static Factory GetInstance()
        {
            return _lazy.Value;
        }

        public T GetService<T>(string key) where T: class
        {
            return _container.Resolve<T>(key);
        }
    }
}
