using System;
using strategy.Domain2.Behaviors;

namespace strategy.Domain2
{
    public class Knight : Character
    {
        public Knight() : base(new KnifeBehavior())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Knight!!!");
        }
    }


}