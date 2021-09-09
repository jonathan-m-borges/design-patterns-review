using System;

namespace strategy.Domain2.Behaviors
{
    public class AxeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Machado!!!");
        }
    }
}