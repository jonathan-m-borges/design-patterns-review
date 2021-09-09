using System;

namespace strategy.Domain2.Behaviors
{
    public class BowAndArrowBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Arco e flecha!!!");
        }
    }
}