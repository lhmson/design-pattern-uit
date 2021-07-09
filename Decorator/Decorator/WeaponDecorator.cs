using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class WeaponDecorator : IWeapon
    {
		protected IWeapon upgradeWeapon;

		public WeaponDecorator(IWeapon upgradeWeapon)
		{
			this.upgradeWeapon = upgradeWeapon;
		}

		public virtual void Attack()
		{
			this.upgradeWeapon.Attack();
		}

		public virtual string GetInfo()
		{
			return "Weapon bonus";
		}

	}
}
