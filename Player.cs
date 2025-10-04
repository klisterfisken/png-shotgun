using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Shotgun
{
    public class Player
    {
        public string Name { get; set; }
        public int Bullets { get; set; }

        public Player(string name, bool cpu)
        {
            Name = name;
            Bullets = 0;
        }

        public static string PlayerName()
        {
            Console.Write($"Fyll i ditt namn: ");
            string playerName = Console.ReadLine()!;
            return playerName;
        }

    }
}