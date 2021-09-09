using System;
using strategy.Domain.Behaviors;

namespace strategy.Domain
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a MallardDuck");
        }
    }
}