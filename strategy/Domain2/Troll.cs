using System;
using strategy.Domain2.Behaviors;

namespace strategy.Domain2
{
    public class Troll : Character
    {
        public Troll() : base(new AxeBehavior())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Troll!!!");
        }
    }


}