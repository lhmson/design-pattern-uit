using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class DihydrogenOxide
    {
        public DihydrogenOxide()
        {
            Water water = new Water();
            water.Context = this;
            state = water;
        }
        private State state;

        internal State State { get => state; set => state = value; }

        public void HeatUp()
        {
            State state = this.state;
            state.HeatUp();
        }
        public void CoolDown()
        {
            State state = this.state;
            state.CoolDown();
        }
    }
}
