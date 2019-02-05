using System;
using Unity;

namespace DesignPatterns.Bootstrap
{
    public class UnitySetup
    {
        private static Lazy<IUnityContainer> _container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            ConfigurateContainer(container);

            return container;
        });

        private static void ConfigurateContainer(IUnityContainer container)
        {
            UnityDependencyResolver.Register(container);
        }

        public static IUnityContainer GetContainer()
        {
            return _container.Value;
        }
    }
}
