using System;

namespace Felli
{
    public class game
    {
        public static void positions(int i)
        {
            if (i == 3 || i == 4 || i == 5 || i == 12 || i == 13 || i == 14)
                Console.BackgroundColor = ConsoleColor.Black;
            else if (i == 22 || i == 23 || i == 24 || i == 31 || i == 32 || i == 33)
                Console.BackgroundColor = ConsoleColor.White;
        }
    }
}