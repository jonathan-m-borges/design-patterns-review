using System;
using strategy.Domain.Behaviors;

namespace strategy.Domain
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyWithWings(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a RubberDuck");
        }
    }
}