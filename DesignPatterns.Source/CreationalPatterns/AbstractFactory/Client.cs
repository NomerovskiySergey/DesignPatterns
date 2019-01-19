using System;
using DesignPatterns.Source.BehaviourPatterns;
using DesignPatterns.Source.CreationalPatterns.AbstractFactory.Factory;

namespace DesignPatterns.Source.CreationalPatterns.AbstractFactory
{
    public class Client: IClient
    {
        public void Run()
        {
            Console.WriteLine("Создали Эльфа");
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Move();

            Console.WriteLine("Создали Солдата");
            Hero soldier = new Hero(new SoldierFactory());
            soldier.Hit();
            soldier.Move();
        }
    }
}
