using BridgeDemo.PlayerControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemo.Player
{
    class Player1 : Player
    {
        public Player1()
        {
            controlScheme = new PlayerControlSchemeArrowKey();
        }
        public override void PrintPlayerInfo()
        {
            Console.WriteLine("Player is player1, displayed on the right half of the screen.");
            PrintUserControlSchemeInfo();
        }
    }
}
