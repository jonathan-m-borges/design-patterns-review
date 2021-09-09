using System;

namespace strategy.Domain.Behaviors
{
    public class Squeak : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Squeak!!!!");
        }
    }
}