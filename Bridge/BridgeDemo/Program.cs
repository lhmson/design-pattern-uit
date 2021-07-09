using System;
using BridgeDemo.Player;
using BridgeDemo.PlayerControl;

namespace BridgeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();

            player1.PrintPlayerInfo();
            player2.PrintPlayerInfo();
        }
    }
}
