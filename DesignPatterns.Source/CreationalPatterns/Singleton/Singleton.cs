using System;

namespace DesignPatterns.Source.CreationalPatterns.Singleton
{
    class Singleton
    {
        private static readonly Lazy<Singleton> _lazy =
            new Lazy<Singleton>(() => new Singleton());

        public string Name { get; private set; }

        private Singleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
            Name = Guid.NewGuid().ToString();
        }

        public static Singleton GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            return _lazy.Value;
        }
    }
}
