using System;
using strategy.Domain.Behaviors;

namespace strategy.Domain
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new FlyNoWay(), new Squeak())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a DecoyDuck");
        }
    }
}