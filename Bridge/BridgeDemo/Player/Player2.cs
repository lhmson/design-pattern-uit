using BridgeDemo.PlayerControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemo.Player
{
    class Player2 : Player
    {
        public Player2()
        {
            controlScheme = new PlayerControlSchemeWASD();
        }
        public override void PrintPlayerInfo()
        {
            Console.WriteLine("Player is player2, displayed on the left half of the screen.");
            PrintUserControlSchemeInfo();
        }
    }
}
