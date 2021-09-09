using System;
using strategy.Domain.Behaviors;

namespace strategy.Domain
{
    public abstract class Duck
    {
        public FlyBehavior FlyBehavior { get; set; }
        public QuackBehavior QuackBehavior { get; set; }

        public Duck(FlyBehavior flyBehavior, QuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("Swiming!!!");
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

    }
}