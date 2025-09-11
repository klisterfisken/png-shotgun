using System;

namespace Shotgun
{
    class Program
    {
        static void Main()
        {
            bool player1CPU;
            Graphics.Header();
            Console.Write("\nDags att spela shotgun!" +
                          "\nSka spelare ett styras av en dator? j/n? ");
            if (Console.ReadLine() == "n") player1CPU = false;
            Console.Write("\nFyll i namnet på spelare ett: ");
            string player1Name = Console.ReadLine();
            Console.ReadKey();
        }
    }
}