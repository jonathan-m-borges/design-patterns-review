using System;
using strategy.Domain1;
using strategy.Domain2;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Ducks();
        }


        static void Ducks()
        {
            var ducks = new Duck[] {
                new DecoyDuck(),
                new MallardDuck(),
                new RedHeadDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks)
            {
                Console.WriteLine("==========");
                duck.Display();
                duck.Swim();
                duck.PerformFly();
                duck.PerformQuack();
            }

            Console.WriteLine("==========");
            Console.WriteLine("Apito");
            new Whistle().PerformQuack();
        }

    }
}
