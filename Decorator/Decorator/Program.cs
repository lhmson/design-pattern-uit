using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = new WaterWeapon(new FireWeapon(new SimpleWeapon()));
            weapon.Attack();
            Console.WriteLine(weapon.GetInfo());
        }
    }
}
