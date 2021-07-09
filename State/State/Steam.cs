using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Steam : State
    {
        private DihydrogenOxide context;

        internal DihydrogenOxide Context { set => context = value; }

        public void CoolDown()
        {
            Console.WriteLine("The steam condense into water.");
            Water water = new Water();
            water.Context = context;
            context.State = water;
        }

        public void HeatUp()
        {
            Console.WriteLine("The steam heats up, but doesn't change.");
        }
    }
}
