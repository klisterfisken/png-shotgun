using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Graphics.Header();
            Music.Play();
            Console.WriteLine("\nDags att spela shotgun!");
            string playerName = Player.PlayerName().ToUpper();
            string cpuName = Cpu.CpuName();
            Player player = new Player(playerName);
            Player cpu = new Player(cpuName);
            Console.WriteLine($"\n{player.Name}, ammo: {player.Ammo}");
            Console.WriteLine($"{cpu.Name}, ammo: {cpu.Ammo}");
            Console.ReadKey();

        }

        // Skapa en meny för de olika dragen
        static string[] MoveMenu()
        {
            string[] moveMenu = new string[]
            {
                "[1] Skjuta",
                "[2] Ladda",
                "[3] Blocka",
                "[4] Shotgun"
            };
            return moveMenu;
        }
    }
}