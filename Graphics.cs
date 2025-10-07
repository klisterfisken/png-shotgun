using System;

namespace Shotgun
{
    class Graphics
    {
        public static void Header()
        {
            Console.WriteLine(@$"  __  __  __   ___  ______  ___  __ __ __  __");
            Console.WriteLine(@$" (( \ ||  ||  // \\ | || | // \\ || || ||\ ||");
            Console.WriteLine(@$"  \\  ||==|| ((   ))  ||  (( ___ || || ||\\||");
            Console.WriteLine(@$" \_)) ||  ||  \\_//   ||   \\_|| \\_// || \||");
            Console.WriteLine("______________________________________________");
        }

        // Skapa en meny för de olika dragen
        public static string MoveMenu(int playerAmmo)
        {
            string[] moveMenu = new string[]
            {
                "[1] Skjuta",
                "[2] Ladda",
                "[3] Blocka",
                "[4] Shotgun"
            };
            for (int i = 0; i < moveMenu.Length; i++)
            {
                if (playerAmmo == 0 && i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (playerAmmo < 3 && i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(moveMenu[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            string moveChoice = "";
            Console.Write("\nVälj ditt drag: ");
            moveChoice = Console.ReadLine()!;
            if (moveChoice == "1") moveChoice = "att SKJUTA";
            else if (moveChoice == "2") moveChoice = "att LADDA";
            else if (moveChoice == "3") moveChoice = "att BLOCKA";
            else if (moveChoice == "4") moveChoice = "SHOTGUN";
            else moveChoice = "";
            return moveChoice;
        }
    }
}