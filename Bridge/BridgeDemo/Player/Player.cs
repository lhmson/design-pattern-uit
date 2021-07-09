using System;
using System.Collections.Generic;
using System.Text;
using BridgeDemo.PlayerControl;

namespace BridgeDemo.Player
{
    abstract class Player
    {
        protected PlayerControlScheme controlScheme;
        public abstract void PrintPlayerInfo();
        public virtual void PrintUserControlSchemeInfo()
        {
            controlScheme.PrintPlayerControlScheme();
        }
    }
}
