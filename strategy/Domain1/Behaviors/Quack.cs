using System;

namespace strategy.Domain1.Behaviors
{
    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack!!!!");
        }
    }
}