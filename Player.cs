using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Shotgun
{
    public class Player
    {
        public string PlayerName { get; set; }
        //public bool CPU { get; set; } - Välj om spelaren ska styras av en dator eller ej
        public int Bullets { get; set; }

        public Player(string playerName, bool cpu)
        {
            PlayerName = playerName;
            //CPU = cpu;
            Bullets = 0;
        }

    }
}