using System;
using strategy.Domain1;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("==========");
            }
        }
    }
}
