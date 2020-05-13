using System;
namespace Felli
{
    public class Positions
    {
        private int[] b;
        private int[] w;
        private int[] boardpos = new int[] { 0, 0, 0, 0, 3, 4, 5, 12, 13, 14, 0, 18, 0, 22, 23, 24, 31, 32, 33, 0, 0, 0, 0};
        public Positions ()
        {
            //position of black pieces in the board
            b = new int[] {3, 4, 5, 12, 13, 14};
            //position of white pieces in the board
            w = new int[] {22, 23, 24, 31, 32, 33};
        }

        public int[] GetB()
        {
            return b;
        }

        public int[] GetW()
        {
            return w;
        }

        public int SetPeace(int piece, char direction, int turno)
        {
            int[] bw;
            int i = 0;
            if ((turno % 2) == 0)
            {
                bw = w;
            }
            else
            {
                bw = b;
            }

            switch (direction)
            {
                case 's':
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i + 3] != 0){
                                bw[piece - 1] = boardpos[i + 3];
                                return 1;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move!");
                                return 0;
                            }

                        }
                        i += 1;
                    }
                    return 0;
                case 'w':
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i - 3] != 0)
                            {
                                bw[piece - 1] = boardpos[i - 3];
                                return 1;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move!");
                                return 0;
                            }
                        }
                        i += 1;
                    }
                    return 0;
                case 'a':
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i - 1] != 0)
                            {
                                bw[piece - 1] = boardpos[i - 1];
                                return 1;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move!");
                                return 0;
                            }
                        }
                        i += 1;
                    }
                    return 0;
                case 'd':
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i + 1] != 0)
                            {
                                bw[piece - 1] = boardpos[i + 1];
                                return 1;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move!");
                                return 0;
                            }
                        }
                        i += 1;
                    }
                    return 0;
                case 'q':
                    foreach(int j in boardpos)
                    {
                        if( j == 12 || j == 33)
                        {
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 3] != 0)
                                {
                                    bw[piece - 1] = boardpos[i - 3];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                    
                        else{

                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 4] != 0)
                                {
                                    bw[piece - 1] = boardpos[i - 4];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                    }
                    return 0;
                case 'z':
                    foreach(int j in boardpos)
                    {
                        if( j == 5 || j == 22)
                        {
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 3] != 0)
                                {
                                    bw[piece - 1] = boardpos[i + 3];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                        else{
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 2] != 0)
                                {
                                    bw[piece - 1] = boardpos[i + 2];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                    }
                    return 0;
                case 'e':
                    foreach(int j in boardpos)
                    {
                        Console.WriteLine (i);
                        if( j == 14 || j == 31)
                        {
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 3] != 0)
                                {
                                    bw[piece - 1] = boardpos[i - 3];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                        else
                        {
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 2] != 0)
                                {
                                    bw[piece - 1] = boardpos[i - 2];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                    }
                    return 0;
                case 'x':
                
                    foreach(int j in boardpos)
                    {
                        if( j == 3 || j == 24)
                        {
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 3] != 0)
                                {
                                    bw[piece - 1] = boardpos[i + 3];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                        else
                        {
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 4] != 0)
                                {
                                    bw[piece - 1] = boardpos[i + 4];
                                    return 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Move!");
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                    }
                    return 0;
            } 
            return 0;
        }
    }
}