using strategy.Domain2.Behaviors;

namespace strategy.Domain2
{
    public abstract class Character
    {
        public WeaponBehavior Weapon { get; set; }

        public Character(WeaponBehavior weapon)
        {
            Weapon = weapon;
        }

        public abstract void Display();

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }

}