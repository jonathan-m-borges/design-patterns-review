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
            Weapons();
        }

        static void Weapons()
        {
            var players = new Character[]
            {
                new King(),
                new Queen(),
                new Knight(),
                new Troll(),
            };

            foreach (var play in players)
            {
                Console.WriteLine("==========");
                play.Display();
                play.Fight();
            }
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
