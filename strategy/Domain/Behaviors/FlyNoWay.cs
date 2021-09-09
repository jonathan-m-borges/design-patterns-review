using System;

namespace strategy.Domain.Behaviors
{
    public class FlyNoWay : FlyBehavior
    {
        void FlyBehavior.Fly()
        {
            Console.WriteLine("No flying!!!!");
        }
    }
}