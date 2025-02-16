using System;

namespace Felli
{
    /// <summary>
    /// Class Output tem todo o que é escrito na consola, e todas as outras
    /// classes irão instanciar um output para puderem utilizar input
    /// </summary>
    public class Output
    {
        //A primeira pergunta que é feita ao jogador
        public void startOutput()
        {
            Console.Write("Chose the starting color ");
            Console.Write("(Black: b) (White: W): \n");
        }
        //Sempre que o jogador tentar mover uma peça para um sítio onde não deve
        //o código deverá chamar este método
        public void InvalidMove()
        {
            Console.WriteLine("Invalid Move!");
        }
        public void WhitesWIn()
        {
            Console.WriteLine("White pieces win!");
        }
        public void BlacksWIn()
        {
            Console.WriteLine("Black pieces win!");
        }
            
        //Se o jogador tentar dar um input que não corresponda ao pedido 
        //o código deverá chamar este método
        public void invalidInput() =>
            Console.WriteLine("Invalid Input");

        //Este método diz qual dos jogadores deve jogar
        public void turnOutput(int turn)
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
        //Este método imprime as instruções e limpa a consola cada vez que é
        //chamado
        public void instructions()
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
            Console.Write("will be used to tell that piece where to move \n");
        }

        public void printBoard(Positions a)
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

                    peace = Game.positions(i, a);
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

                    peace = Game.positions(i, a);
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
                        peace = Game.positions(i, a);
                        if(j == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write("  ");
                            peace = Game.positions(i, a);
                            Console.Write(" {0} ", peace);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write("  ");
                        }
                            
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write("       ");
                        }
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine(" ");
        }
    }
}