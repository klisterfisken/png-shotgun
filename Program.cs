using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            Graphics.Header();
            Console.Write("\nDags att spela shotgun!");
            PlayerSetup player1 = new PlayerSetup(1);
            Console.ReadKey();
        }
        static bool PlayerCPU(int playerNumber)
        {
            bool playerCPU = true;
            Console.Write($"\nSka spelare {playerNumber} styras av en dator? j/n? ");
            string? answer = Console.ReadLine();
            if (answer.ToUpper() == "N") playerCPU = false;
            return playerCPU;
        }
        static string PlayerName(int playerNumber)
        {
            Console.Write($"\nFyll i namnet på spelare {playerNumber}: ");
            string? playerName = Console.ReadLine();
            return playerName;
        }
    }
}