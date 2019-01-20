using System;
using DesignPatterns.Source.BehaviourPatterns;

namespace DesignPatterns.Source.CreationalPatterns.Builder
{
    public class Client: IClient
    {
        public void Run()
        {
            var sportCarBuilder = new SportCarBuilder();
            var familyCarBuilder = new FamilyCarBulder();

            var director = new Director(sportCarBuilder);

            director.BuildSportCar();
            Console.WriteLine(director.ReturnCar().Description());

            director = new Director(familyCarBuilder);

            director.BuildSportCar();
            Console.WriteLine(director.ReturnCar().Description());


        }
    }
}
