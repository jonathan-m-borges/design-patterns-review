using System;

namespace strategy.Domain2.Behaviors
{
    public class SwordBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Espada!!!");
        }
    }
}