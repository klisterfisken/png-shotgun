using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            // Start program: set color, play music
            bool power = true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Graphics.Header();
            Music.Play();
            Console.WriteLine("\nDags att spela shotgun!");

            // Fetch names and create player objects
            string playerName = Player.PlayerName().ToUpper();
            string cpuName = Cpu.CpuName();
            Player player = new Player(playerName);
            Player cpu = new Player(cpuName);

        // Start here when starting new match
        NewMatch:
            Console.Clear();
            Graphics.Header();
            Console.WriteLine($"\nHej {playerName}!\nDu kommer att duellera mot vår android {cpu.Name}.");
            Console.Write("[ OK ]");
            Console.ReadKey();

            // Repeat until player closes game
            while (power)
            {
            Restart:;
                Console.Clear();
                Graphics.Header();

                // Print each player and their current ammo
                Console.WriteLine($"\n{player.Name}, ammo: {player.Ammo}");
                Console.WriteLine($"{cpu.Name}, ammo: {cpu.Ammo}\n");

                // Have cpu, then player make a move
                string cpuMove = Cpu.CpuMove(cpu.Ammo, player.Ammo);
                Console.WriteLine($"{cpu.Name} har valt sitt drag.\nVilket drag väljer du?\n");
                string moveChoice = Graphics.MoveMenu(player.Ammo);

                // If invalid, print message and jump to loop start
                if (moveChoice == "")
                {
                    Console.Write($"Ogiltigt val. Välj ett annat drag.\n[ OK ]");
                    Console.ReadLine();
                    goto Restart;
                }
                if (player.Ammo == 0 && (moveChoice == "att SKJUTA" || moveChoice == "SHOTGUN"))
                {
                    Console.Write($"Du behöver ammo för {moveChoice}. Välj ett annat drag.\n[ OK ]");
                    Console.ReadLine();
                    goto Restart;
                }
                if (player.Ammo < 3 && moveChoice == "SHOTGUN")
                {
                    Console.Write($"Du behöver 3 ammo för {moveChoice}. Välj ett annat drag.\n[ OK ]");
                    Console.ReadLine();
                    goto Restart;
                }

                Console.WriteLine($"Du har valt {moveChoice}");
                Console.Write($"{cpu.Name} valde ");

                // Print thinking animation
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(300);
                    Console.Write(".");
                }
                Thread.Sleep(1100);
                Console.WriteLine($" {cpuMove}!");

                // Fetch tuple of data elements
                var resolution = Player.MoveResolution(player.Ammo, cpu.Ammo, moveChoice, cpuMove);
                player.Ammo = resolution.playerAmmo;
                cpu.Ammo = resolution.cpuAmmo;

                // If end of game message
                if (resolution.message != "")
                {
                    Console.Write($"\n{resolution.message} Vill du spela igen? J/N ");
                    string? playAgain = Console.ReadLine();
                    if (playAgain == "n" || playAgain == "N")
                    {
                        power = false;
                        goto Restart;
                    }
                    else
                    {
                        player = new Player(playerName);
                        cpu = new Player(Cpu.CpuName());
                        resolution.message = "";
                        Music.Play();
                        Console.Clear();
                        // Jump to before while loop
                        goto NewMatch;
                    }
                }
                Console.Write("[ OK ]");
                Console.ReadKey();
            }
        }
    }
}