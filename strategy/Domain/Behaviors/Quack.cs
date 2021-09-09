using System;

namespace strategy.Domain.Behaviors
{
    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack!!!!");
        }
    }
}