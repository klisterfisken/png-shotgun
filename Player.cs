using System;
using System.Dynamic;

namespace Shotgun
{
    public class Player
    {
        public string PlayerName { get; set; }
        public bool CPU { get; set; }
        public int Bullets { get; set; }

        public Player(string playerName, bool cpu)
        {
            PlayerName = playerName;
            CPU = cpu;
            Bullets = 0;
        }
    }
}