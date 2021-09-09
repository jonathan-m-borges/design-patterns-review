using System;
using strategy.Domain1.Behaviors;

namespace strategy.Domain1
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