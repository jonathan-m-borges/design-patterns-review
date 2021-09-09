using System;

namespace strategy.Domain1.Behaviors
{
    public class MutedQuack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("schsch!!!!");
        }
    }
}