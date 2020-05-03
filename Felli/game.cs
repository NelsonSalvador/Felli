using System;

namespace Felli
{
    public class game
    {
        public static void positions(int i)
        {
            Positions a = new Positions();

            int[] b = a.GetB();
            int[] w = a.GetW();

            foreach(int j in b)
            {
                if (i == j)
                    Console.BackgroundColor = ConsoleColor.Black;
            }

            foreach(int j in w)
            {
                if (i == j)
                    Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}