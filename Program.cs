using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            Graphics.Header();
            Console.Write("\nDags att spela shotgun!")
            Console.ReadKey();
        }
        static (string, bool) PlayerSetup(int playerNumber)
        {
            bool playerCPU;
            Console.Write($"\nSka spelare {playerNumber} styras av en dator? j/n? ");
            string? answer = Console.ReadLine();
            if (answer.ToUpper() == "N") playerCPU = false;
            Console.Write($"\nFyll i namnet på spelare {playerNumber}: ");
            string playerName = Console.ReadLine();
        }
    }
}