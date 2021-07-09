using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Water : State
    {
        private DihydrogenOxide context;

        internal DihydrogenOxide Context { set => context = value; }

        public void CoolDown()
        {
            Console.WriteLine("The water crystalize into ice.");
            Ice ice = new Ice();
            ice.Context = context;
            context.State = ice;
        }

        public void HeatUp()
        {
            Console.WriteLine("The water vaporized into steam.");
            Steam steam = new Steam();
            steam.Context = context;
            context.State = steam;
        }
    }
}
