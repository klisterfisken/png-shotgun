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

        public static (string message, int playerAmmo, int cpuAmmo) MoveResolution(int playerAmmo, int cpuAmmo, string playerMove, string cpuMove)
        {
            string message = "";
            if (cpuMove == "att SKJUTA") cpuAmmo--;
            else if (cpuMove == "att LADDA") cpuAmmo++;
            else if (cpuMove == "SHOTGUN") cpuAmmo += -3;
            if (playerMove == "att SKJUTA")
            {
                playerAmmo--;
                if (cpuMove == "att LADDA") message = "Du har vunnit!";
            }
            else if (playerMove == "att LADDA")
            {
                playerAmmo++;
                if (cpuMove == "att SKJUTA") message = "Du förlorade!";
            }
            else if (playerMove == "SHOTGUN")
            {
                playerAmmo += -3;
                if (cpuMove != "SHOTGUN") message = "Du har vunnit!";
            }
            else if (cpuMove == "SHOTGUN") message = "Du förlorade!";
            return (message, playerAmmo, cpuAmmo);
        }

    }
}