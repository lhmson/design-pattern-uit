using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class FireWeapon : WeaponDecorator
    {
		public FireWeapon(WeaponDecorator upgradeWeapon) : base(upgradeWeapon)
		{
		}

        public FireWeapon(IWeapon upgradeWeapon) : base(upgradeWeapon)
        {
        }

        public override void Attack()
		{
			base.Attack();
			this.FireAttack();
		}

		private void FireAttack()
		{
			Console.WriteLine("Some fire shot");
		}

		public override string GetInfo()
		{
			return this.upgradeWeapon.GetInfo() + " upgrade to fire attack";
		}
	}
}
