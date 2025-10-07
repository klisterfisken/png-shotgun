using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            bool power = true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Graphics.Header();
            Music.Play();
            Console.WriteLine("\nDags att spela shotgun!");
            Console.Write("[FORTSÄTT]");
            Console.ReadKey();
            string playerName = Player.PlayerName().ToUpper();
            string cpuName = Cpu.CpuName();
            Player player = new Player(playerName);
            Player cpu = new Player(cpuName);
            while (power)
            {
                Console.Clear();
                Graphics.Header();
                Console.WriteLine($"\n{player.Name}, ammo: {player.Ammo}");
                Console.WriteLine($"{cpu.Name}, ammo: {cpu.Ammo}\n");
                string cpuMove = Cpu.CpuMove(cpu.Ammo, player.Ammo);
                Console.WriteLine($"{cpu.Name} har valt sitt drag.\nVilket drag väljer du?\n");
                string moveChoice = Graphics.MoveMenu(player.Ammo);
                Console.WriteLine($"Du har valt att {moveChoice}");
                Console.Write($"{cpu.Name} valde att");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(300);
                    Console.Write(".");
                }
                Thread.Sleep(1100);
                Console.WriteLine($" {cpuMove}!");

                // Skicka till extern metod med parametrarna player + cpu
                // Skicka tillbaka flera komponenter med en tuple

                var resolution = Player.MoveResolution(player.Ammo, cpu.Ammo, moveChoice, cpuMove);
                player.Ammo = resolution.playerAmmo;
                cpu.Ammo = resolution.cpuAmmo;

                if (resolution.message != "")
                {
                    Console.WriteLine($"{resolution} Vill du spela igen? J/N");
                    string? playAgain = Console.ReadLine();
                    if (playAgain == "n" || playAgain == "N") power = false;
                }
                Console.ReadKey();
            }

        }


    }
}