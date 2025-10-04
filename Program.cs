using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            Graphics.Header();
            Console.WriteLine("\nDags att spela shotgun!");
            string playerName = Player.PlayerName();
            string cpuName = Cpu.CpuName();
            Console.WriteLine($"\nI ena hörnan bla bla bla");
            Console.Beep();
            Console.ReadKey();

            Music.Play();
        }
    }
}