using System;

namespace strategy.Domain1.Behaviors
{
    public class Squeak : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Squeak!!!!");
        }
    }
}