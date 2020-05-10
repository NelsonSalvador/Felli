using System;

namespace Felli
{
    public class game
    {
        public struct TurnInformation
        {
            public string piece;
            public string direction;
        }
        public static int positions(int i)
        {
            Positions a = new Positions();

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
        public static void gameloop()
        {
            int turncounter;
            int turno = 0;
            bool gameover = false;
            bool gamestarted = false;
            do
            {
                Output.instructions();
                Output.printBoard();
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
                        Output.invalidOutput();
                    }
                }
                else
                {
                    turncounter = turn(turno);
                    TurnInformation z;
                    z.piece = Console.ReadLine();
                    z.direction = Console.ReadLine();
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