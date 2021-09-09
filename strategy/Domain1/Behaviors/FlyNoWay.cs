using System;

namespace strategy.Domain1.Behaviors
{
    public class FlyNoWay : FlyBehavior
    {
        void FlyBehavior.Fly()
        {
            Console.WriteLine("No flying!!!!");
        }
    }
}