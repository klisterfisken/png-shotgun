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
            string playerName = Player.PlayerName();
            string cpuName = Cpu.CpuName();
            Player player = new Player(playerName);
            Player cpu = new Player(cpuName);
            Console.WriteLine($"\n{player.Name}, ammo: {player.Ammo}");
            Console.WriteLine($"{cpu.Name}, ammo: {cpu.Ammo}");
            Console.ReadKey();

        }
    }
}