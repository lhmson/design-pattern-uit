using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Ice : State
    {
        private DihydrogenOxide context;

        internal DihydrogenOxide Context { set => context = value; }

        public void CoolDown()
        {
            Console.WriteLine("The ice get colder, but doesn't change.");
        }

        public void HeatUp()
        {
            Console.WriteLine("The ice melted into water.");
            Water water = new Water();
            water.Context = context;
            context.State = water;
        }
    }
}
