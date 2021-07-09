using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemo.PlayerControl
{
    class PlayerControlSchemeWASD : PlayerControlScheme
    {
        public void PrintPlayerControlScheme()
        {
            Console.WriteLine("Player is using WASD.");
        }
    }
}
