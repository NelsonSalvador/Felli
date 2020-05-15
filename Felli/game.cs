using System;
namespace Felli
{
    public class game
    {
        public struct TurnInformation
        {
            public int piece;
            public char direction;
        }
        public static int positions(int i, Positions a)
        {
            int[] b = a.GetB();
            int[] w = a.GetW();
            int peace = 1;

            foreach(int j in b)
            {
                if (i == j)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    return peace;
                }
                peace += 1;
            }

            peace = 1;

            foreach(int j in w)
            {
                if (i == j)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    return peace;
                }
                peace ++;
            }
            return 0;
        }
        public static void gameloop(Positions a, CheckMove z)
        {
            int turncounter;
            int turno = 0;
            bool gameover = false;
            bool gamestarted = false;
            bool validmove = false;
            int validation = 0;
            int lengthB;
            int lengthW;
            int[] b = a.GetB();
            int[] w = a.GetW();
            string second_input;
            
            do
            {
                Output.instructions();
                Output.printBoard(a);
                if (gamestarted == false)
                {
                    Output.startOutput();
                    string firstplayer = Console.ReadLine();
                    if (firstplayer == "b")
                    {
                        turno = 1;
                        gamestarted = true;
                    }
                    else if (firstplayer == "w")
                    {
                        turno = 2;
                        gamestarted = true;
                    }
                    else
                    {
                        Output.invalidInput();
                    }
                }
                else
                {
                    lengthB = b.Length;
                    lengthW = w.Length;
                    if (lengthB != 0 && lengthW != 0)
                    {
                        turncounter = turn(turno);
                        TurnInformation c;
                        while (validmove == false)
                        {
                            second_input = Console.ReadLine();
                            if (int.TryParse(second_input, out c.piece))
                            {
                                c.direction = Convert.ToChar(Console.ReadLine());
                                a.SetPeace(c.piece, c.direction, turno, z);
                                validation = z.Validation(-1);
                                if (validation == 1)
                                { 
                                    validmove = true;
                                }
                            }
                            else if(second_input == "exit")
                            {
                                gamend();
                            }
                            else
                            {
                                Output.invalidInput();
                            }
                        }
                        validmove = false;
                        turno++;   
                    }
                    else
                    {
                        gameover = true;
                    }
                }
            } while (gameover == false);
        }
        public static int turn(int turn)
        {
            Output.turnOutput(turn);
            turn++;
            return turn;
        }
        public static void gamend()
        {
            System.Environment.Exit(0);
        }
    }
}