using System;

namespace Felli
{
    public class Output
    {
        public static void startOutput() =>
            Console.WriteLine("Chosee the starting color (Black: b) (White: W): ");

        public static void invalidOutput() =>
            Console.WriteLine("Invalid Output");

        public static void turnOutput(int turn)
        {
            if ((turn % 2) == 0)
            {
                Console.WriteLine("White pieces turn");
            }
            else
            {
                Console.WriteLine("Black pieces turn");
            }
        }

        public static void instructions()
        {
            Console.Clear();
            Console.WriteLine("\n Welcome to Felli");
            Console.Write("The main goal is to capture all of your opponents ");
            Console.Write("pieces by hoping over them or by making sure ");
            Console.Write("they can't move \n");
            Console.Write("You can only move one piece per turn, and there ");
            Console.Write("must be an empty position on the board on which ");
            Console.Write("you can land \n");
            Console.Write("When refering to pieces please use b for black ");
            Console.Write("and w for white \n\n");
            Console.WriteLine("How to move your pieces: ");
            Console.Write("Your first input will be used to select which ");
            Console.Write("piece you wish to move, your second input ");
            Console.Write("will be used to tell that piece where to move ");
            Console.Write("Please pick a color to go first \n");
        }

        public static void printBoard()
        {
            int peace;
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

                    peace = game.positions(i);
                    Console.Write(" {0} ", peace);

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

                    peace = game.positions(i);
                    Console.Write(" {0} ", peace);

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
            Console.WriteLine(" ");
        }
    }
}