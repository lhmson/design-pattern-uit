using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	class WaterWeapon : WeaponDecorator
	{
		public WaterWeapon(IWeapon upgradeWeapon) : base(upgradeWeapon)
		{
		}

		public override void Attack()
		{
			base.Attack();
			this.WaterAttack();
		}

		private void WaterAttack()
		{
			Console.WriteLine("Some water shot");
		}

		public override string GetInfo()
		{
			return this.upgradeWeapon.GetInfo() + " upgrade to water attack";
		}
	}
}
