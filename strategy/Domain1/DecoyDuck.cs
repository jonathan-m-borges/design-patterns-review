using System;
using strategy.Domain1.Behaviors;

namespace strategy.Domain1
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