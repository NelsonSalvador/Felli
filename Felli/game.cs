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
        public static void gameloop()
        {
            int turncounter;
            int turno = 0;
            bool gameover = false;
            bool gamestarted = false;
            do
            {
                if (gamestarted == false)
                {
                    string firstplayer = Console.ReadLine();
                    if (firstplayer == "b")
                    {
                        turn(1);
                        gamestarted = true;
                    }
                    else if (firstplayer == "w")
                    {
                        turn(0);
                        gamestarted = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Output");
                    }
                }
                else
                {
                    turno++;
                    turncounter = turn(turno);
                    TurnInformation z;
                    z.piece = Console.ReadLine();
                    z.direction = Console.ReadLine();
                }
            } while (gameover == false);
        }
        public static int turn(int turn)
        {
            if (turn %2 == 0)
            {
                Console.WriteLine("White pieces turn");
                turn++;
                return turn;
            }
            else
            {
                Console.Write(turn);
                turn++;
                Console.WriteLine("Black pieces turn");
                return turn;
            }
        }
    }
}