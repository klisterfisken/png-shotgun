using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            bool power = true;
            Console.Clear();
            Graphics.Header();
            Music.Play();
            Console.WriteLine("\nDags att spela shotgun!");
            Console.Write("[ FORTSÄTT ]");
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
                int moveChoice = Graphics.MoveMenu(player.Ammo);
                Console.WriteLine($"Du har valt alternativ {moveChoice}");
                Console.ReadKey();
                break;
            }

        }

    }
}