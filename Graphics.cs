using System;

namespace Shotgun
{
    class Graphics
    {
        // Skriv ut en ASCII-header
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

            // Gråmarkera ogiltiga drag
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
            // Sätt tillbaka vit som textfärg
            Console.ForegroundColor = ConsoleColor.White;

            // Läs in svar från användaren
            string moveChoice = "";
            Console.Write("\nVälj ditt drag: ");
            moveChoice = Console.ReadLine()!;

            // Skriv ut drag beroende på val
            switch (moveChoice)
            {
                case "1":
                    moveChoice = "att SKJUTA";
                    break;
                case "2":
                    moveChoice = "att LADDA";
                    break;
                case "3":
                    moveChoice = "att BLOCKA";
                    break;
                case "4":
                    moveChoice = "SHOTGUN";
                    break;
                default:
                    moveChoice = "";
                    break;
            }
            return moveChoice;
        }
    }
}