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

        public static string MoveResolution(int playerAmmo, int cpuAmmo, string playerMove, string cpuMove)
        {
            string message = "";
            if (playerMove == "SKJUTA")
            {
                playerAmmo--;
                if (cpuMove == "LADDA") message = "Du har vunnit!";
            }
            else if (playerMove == "LADDA")
            {
                playerAmmo++;
                if (cpuMove == "SKJUTA") message = "Du förlorade!";
            }
            else if (playerMove == "SHOTGUN")
            {
                playerAmmo = playerAmmo - 3;
                if (cpuMove != "SHOTGUN") message = "Du har vunnit!";
            }
            else if (cpuMove == "SHOTGUN") message = "Du förlorade!";
            return message;
        }

    }
}