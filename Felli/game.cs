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
        public static void gameloop(Positions a)
        {
            int turncounter;
            int turno = 0;
            bool gameover = false;
            bool gamestarted = false;
            bool validmove = false;
            int validation = 0;
            
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
                    turncounter = turn(turno);
                    TurnInformation z;
                    while (validmove == false)
                    {
                        z.piece = Convert.ToInt32(Console.ReadLine());
                        z.direction = Convert.ToChar(Console.ReadLine());
                        CheckMove.Inicialize();
                        a.SetPeace(z.piece, z.direction, turno);
                        validation = CheckMove.Validation(-1);
                        if (validation == 1)
                        { 
                            validmove = true;
                        }
                    }
                    validmove = false;
                    turno++;
                }
            } while (gameover == false);
        }
        public static int turn(int turn)
        {
            Output.turnOutput(turn);
            turn++;
            return turn;
        }
    }
}