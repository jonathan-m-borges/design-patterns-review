using System;
using strategy.Domain2.Behaviors;

namespace strategy.Domain2
{
    public class Queen : Character
    {
        public Queen() : base(new BowAndArrowBehavior())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Queen!!!");
        }
    }


}