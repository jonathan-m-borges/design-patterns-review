using strategy.Domain1.Behaviors;

namespace strategy.Domain1
{

    public class Whistle
    {
        public QuackBehavior QuackBehavior { get; set; }

        public Whistle()
        {
            QuackBehavior = new Quack();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

    }
}