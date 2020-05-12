using System;
namespace Felli
{
    public class Positions
    {
        private int[] b;
        private int[] w;
        private int[] boardpos = new int[] {3, 4, 5, 12, 13, 14, 18, 22, 23, 24, 31, 32, 33};
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

        public void SetPeace(int piece, char direction, int turno)
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
                            bw[piece - 1] = boardpos[i + 3];
                            break;
                        }
                        i += 1;
                    }
                    break;
                case 'w':
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            bw[piece - 1] = boardpos[i - 3];
                            break;
                        }
                        i += 1;
                    }
                    break;
                case 'a':
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            bw[piece - 1] = boardpos[i - 1];
                            break;
                        }
                        i += 1;
                    }
                    break;
                case 'd':
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            bw[piece - 1] = boardpos[i + 1];
                            break;
                        }
                        i += 1;
                    }
                    break;
                case 'q':
                    foreach(int j in boardpos)
                    {
                        if( j == 12 || j == 33)
                        {
                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i - 3];
                                break;
                            }
                            i += 1;
                        }
                        else{

                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i - 4];
                                break;
                            }
                            i += 1;
                        }
                    }
                    break;
                case 'z':
                    foreach(int j in boardpos)
                    {
                        if( j == 5 || j == 22)
                        {
                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i + 3];
                                break;
                            }
                            i += 1;
                        }
                        else{
                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i + 2];
                                break;
                            }
                            i += 1;
                        }
                    }
                    break;
                case 'e':
                    foreach(int j in boardpos)
                    {
                        Console.WriteLine (i);
                        if( j == 14 || j == 31)
                        {
                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i - 3];
                                break;
                            }
                            i += 1;
                        }
                        else
                        {
                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i - 2];
                                break;
                            }
                            i += 1;
                        }
                    }
                    break;
                case 'x':
                
                    foreach(int j in boardpos)
                    {
                        if( j == 3 || j == 24)
                        {
                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i + 3];
                                break;
                            }
                            i += 1;
                        }
                        else
                        {
                            if (j == bw[piece - 1])
                            {
                                bw[piece - 1] = boardpos[i + 4];
                                break;
                            }
                            i += 1;
                        }
                    }
                    break;
            }
        }
    }
}