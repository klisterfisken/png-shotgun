using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            Graphics.Header();
            Console.WriteLine("\nDags att spela shotgun!");
            bool player1cpu = PlayerCPU(1);
            string player1Name = PlayerName(1);
            bool player2cpu = PlayerCPU(2);
            string player2Name = PlayerName(2);
            Console.WriteLine($"\nSpelare 1 heter {player1Name} och styrs av en {(player1cpu ? "dator" : "person")}.");
            Console.WriteLine($"Spelare 2 heter {player2Name} och styrs av en {(player2cpu ? "dator" : "person")}.");
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
            Console.Write($"Fyll i namnet på spelare {playerNumber}: ");
            string? playerName = Console.ReadLine();
            return playerName;
        }
    }
}