using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SimpleWeapon : IWeapon
    {
        public void Attack()
        {
            
        }

       
        public string GetInfo()
        {
            return "Simple weapon picked";
        }
    }
}
