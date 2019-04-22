using System;

namespace DesignPatterns.Source.StructuralPatterns.Composite
{
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }
}
