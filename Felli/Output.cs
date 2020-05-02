using System;

namespace Felli
{
    public class Output
    {
        public static void instructions()
        {

        }

        public static void printBoard()
        {
            for (int i = 0; i < 38; i++)
            {
                //Desenha os quadrados do topo e do fundo
                if (i < 3 || (i >= 28 && i < 31))
                {
                    if (i == 28)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("       ");
                    Console.ResetColor();
                    Console.Write("        ");
                }
                //Peças
                else if ((i >= 3 && i < 6) || (i >= 31 && i < 34))
                {
                    if (i == 3 || i == 31)
                        Console.WriteLine("");

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("  ");

                    game.positions(i);
                    Console.Write("   ");

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("  ");

                    Console.ResetColor();
                    Console.Write("        ");
                }
                else if ((i >=6 && i < 9) || (i >= 34 && i < 37))
                {
                    if (i == 6 || i == 34)
                        Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("       ");
                    Console.ResetColor();
                    Console.Write("        ");
                }

                // Desenha os quadrados intermédios
                else if ((i >= 9 && i < 12) || (i >= 19 && i < 22))
                {
                    if (i == 9 || i == 19)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("       ");
                    }
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("       ");
                    Console.ResetColor();
                    Console.Write(" ");
                }
                else if ((i >= 12 && i < 15) || (i >= 22 && i < 25))
                {
                    if (i == 12 || i == 22)
                    {
                        Console.WriteLine("");
                        Console.Write("       ");
                    }

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("  ");

                    game.positions(i);
                    Console.Write("   ");

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("  ");
                    Console.ResetColor();
                    Console.Write(" ");
                }
                else if ((i >= 15 && i < 18) || (i >= 25 && i < 28))
                {
                    if (i == 15 || i == 25)
                    {
                        Console.WriteLine("");
                        Console.Write("       ");
                    }
                    
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write("       ");
                    Console.ResetColor();
                    Console.Write(" ");
                }
                //Desenha o quadrado do meio
                else if (i == 18)
                {
                    Console.WriteLine("");

                    for (int j = 0; j < 3; j ++)
                    {
                        Console.WriteLine("");
                        Console.Write("               ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        if(j == 1)
                            Console.Write("   M   ");
                        else
                            Console.Write("       ");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}