using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Shotgun
{
    public class Player
    {
        // Define player properties
        public string Name { get; set; }
        public int Ammo { get; set; }

        // Construct Player object
        public Player(string name)
        {
            Name = name;
            Ammo = 0;
        }

        // Read and save namn from input
        // Set name to 'Okänd' if no input
        public static string PlayerName()
        {
            Console.Write($"Fyll i ditt namn: ");
            string? playerName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(playerName)) playerName = "Okänd";
            return playerName;
        }

        // Fetch string message and updated ammo, due to resolution
        // Method returns tuple of data elements
        public static (string message, int playerAmmo, int cpuAmmo) MoveResolution(int playerAmmo, int cpuAmmo, string playerMove, string cpuMove)
        {
            string message = "";
            // Adjust cpu ammo based on move
            if (cpuMove == "SHOTGUN" && playerMove != "SHOTGUN") message = "Du förlorade!";
            if (cpuMove == "att SKJUTA") cpuAmmo--;
            else if (cpuMove == "att LADDA") cpuAmmo++;
            else if (cpuMove == "SHOTGUN") cpuAmmo += -3;

            // Adjust player ammo based on move
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
            return (message, playerAmmo, cpuAmmo);
        }

    }
}