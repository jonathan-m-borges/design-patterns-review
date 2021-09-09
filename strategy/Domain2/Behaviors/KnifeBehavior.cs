using System;

namespace strategy.Domain2.Behaviors
{
    public class KnifeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Faca!!!");
        }
    }
}