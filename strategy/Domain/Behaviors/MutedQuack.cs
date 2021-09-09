using System;

namespace strategy.Domain.Behaviors
{
    public class MutedQuack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("schsch!!!!");
        }
    }
}