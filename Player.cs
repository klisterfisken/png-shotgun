using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Shotgun
{
    public class Player
    {
        public string Name { get; set; }
        public int Ammo { get; set; }

        public Player(string name)
        {
            Name = name;
            Ammo = 0;
        }

        public static string PlayerName()
        {
            Console.Write($"Fyll i ditt namn: ");
            string playerName = Console.ReadLine()!;
            return playerName;
        }

    }
}