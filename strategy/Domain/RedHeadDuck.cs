using System;
using strategy.Domain.Behaviors;

namespace strategy.Domain
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck() : base(new FlyWithWings(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a RedHeadDuck");
        }
    }
}