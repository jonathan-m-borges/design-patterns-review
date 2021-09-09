using System;

namespace strategy.Domain1.Behaviors
{
    public class FlyWithWings : FlyBehavior
    {
        void FlyBehavior.Fly()
        {
            Console.WriteLine("Flying with wings!!!!");
        }
    }
}