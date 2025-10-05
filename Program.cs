using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            Graphics.Header();
            Console.WriteLine("\nDags att spela shotgun!");
            Music.Play();
            string playerName = Player.PlayerName();
            string cpuName = Cpu.CpuName();
            Player player = new Player(playerName);
            Player cpu = new Player(cpuName);
            Console.WriteLine($"\nI ena hörnan bla bla bla");
            Console.Beep();
            Console.ReadKey();

        }
    }
}