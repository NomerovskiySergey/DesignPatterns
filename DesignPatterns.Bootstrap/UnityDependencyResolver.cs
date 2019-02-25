using DesignPatterns.Source;
using DesignPatterns.Source.BehaviourPatterns;
using Chain = DesignPatterns.Source.BehaviourPatterns.ChainOfResponsibility;
using Strategy = DesignPatterns.Source.BehaviourPatterns.Strategy;
using Observer = DesignPatterns.Source.BehaviourPatterns.Observer;
using Command = DesignPatterns.Source.BehaviourPatterns.Command;
using TemplateMethod = DesignPatterns.Source.BehaviourPatterns.TemplateMethod;
using State = DesignPatterns.Source.BehaviourPatterns.State;
using Interpreter = DesignPatterns.Source.BehaviourPatterns.Interpreter;
using Mediator = DesignPatterns.Source.BehaviourPatterns.Mediator;
using Memento = DesignPatterns.Source.BehaviourPatterns.Memento;
using Visitor = DesignPatterns.Source.BehaviourPatterns.Visitor;
using FactoryMethod = DesignPatterns.Source.CreationalPatterns.FactoryMethod;
using AbstractFactory = DesignPatterns.Source.CreationalPatterns.AbstractFactory;
using Builder = DesignPatterns.Source.CreationalPatterns.Builder;
using Prototype = DesignPatterns.Source.CreationalPatterns.Prototype;
using Singleton = DesignPatterns.Source.CreationalPatterns.Singleton;
using Adapter = DesignPatterns.Source.StructuralPatterns.Adapter;

using Unity;

namespace DesignPatterns.Bootstrap
{
    public class UnityDependencyResolver
    {
        private static IUnityContainer _container;
        public static void Register(IUnityContainer container)
        {
            _container = container;

            RegisterBehaviourPatternsTypes();
            RegisterCreationalPatternsTypes();
            RegisterStructuralPatternsTypes();
        }

        private static void RegisterBehaviourPatternsTypes()
        {
            _container.RegisterType<IClient, Chain.Client>(Types.ChainOfResponsibility.ToString());
            _container.RegisterType<IClient, Command.Client>(Types.Command.ToString());
            _container.RegisterType<IClient, Strategy.Client>(Types.Strategy.ToString());
            _container.RegisterType<IClient, Interpreter.Client>(Types.Interpreter.ToString());
            _container.RegisterType<IClient, Observer.Client>(Types.Observer.ToString());
            _container.RegisterType<IClient, TemplateMethod.Client>(Types.TemplateMethod.ToString());
            _container.RegisterType<IClient, State.Client>(Types.State.ToString());
            _container.RegisterType<IClient, Mediator.Client>(Types.Mediator.ToString());
            _container.RegisterType<IClient, Memento.Client>(Types.Memento.ToString());
            _container.RegisterType<IClient, Visitor.Client>(Types.Visitor.ToString());
        }

        private static void RegisterCreationalPatternsTypes()
        {
            _container.RegisterType<IClient, FactoryMethod.Client>(Types.FactoryMethod.ToString());
            _container.RegisterType<IClient, AbstractFactory.Client>(Types.AbstractFactory.ToString());
            _container.RegisterType<IClient, Builder.Client>(Types.Builder.ToString());
            _container.RegisterType<IClient, Prototype.Client>(Types.Prototype.ToString());
            _container.RegisterType<IClient, Singleton.Client>(Types.Singleton.ToString());
        }

        private static void RegisterStructuralPatternsTypes()
        {
            _container.RegisterType<IClient, Adapter.Client>(Types.Adapter.ToString());
        }
    }
}
