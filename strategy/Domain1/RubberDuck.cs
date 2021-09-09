using System;
using strategy.Domain1.Behaviors;

namespace strategy.Domain1
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