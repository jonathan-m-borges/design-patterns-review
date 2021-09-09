using System;
using strategy.Domain2.Behaviors;

namespace strategy.Domain2
{
    public class King : Character
    {
        public King() : base(new SwordBehavior())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a King!!!");
        }
    }


}