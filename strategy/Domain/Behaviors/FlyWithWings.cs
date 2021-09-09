using System;

namespace strategy.Domain.Behaviors
{
    public class FlyWithWings : FlyBehavior
    {
        void FlyBehavior.Fly()
        {
            Console.WriteLine("Flying with wings!!!!");
        }
    }
}