using System;
using strategy.Domain1.Behaviors;

namespace strategy.Domain1
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