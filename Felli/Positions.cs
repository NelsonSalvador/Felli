using System;
namespace Felli
{
    public class Positions
    {
        private int[] b;
        private int[] w;
        private int[] boardpos = new int[] { 0, 0, 0, 0, 3, 4, 5, 12, 13, 14, 
                                0, 18, 0, 22, 23, 24, 31, 32, 33, 0, 0, 0, 0};
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
            int[] wb;
            int i = 0;
            int move;
            int movement;
            int check;
            if ((turno % 2) == 0)
            {
                bw = w;
                wb = b;
            }
            else
            {
                bw = b;
                wb = w;
            }

            switch (direction)
            {
                case 's':
                movement = 3;
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i + 3] != 0)
                            {
                                move = CheckmoveStraight(bw, wb, i, movement);
                                if (move == 0)
                                {
                                    return 0;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    return 1;
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    return 1;
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
                                return 0;
                            }
                        }
                        i += 1;
                    }
                    return 0;
                case 'w':
                    movement = -3;
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i - 3] != 0)
                            {
                                move = CheckmoveStraight(bw, wb, i, movement);
                                if (move == 0)
                                {
                                    return 0;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    return 1;
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    return 1;
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
                                return 0;
                            }
                        }
                        i += 1;
                    }
                    return 0;
                case 'a':
                    movement = -1;
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i - 1] != 0)
                            {
                                move = CheckmoveStraight(bw, wb, i, movement);
                                if (move == 0)
                                {
                                    return 0;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    return 1;
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    return 1;
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
                                return 0;
                            }
                        }
                        i += 1;
                    }
                    return 0;
                case 'd':
                    movement = +1;
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i + 1] != 0)
                            {
                                move = CheckmoveStraight(bw, wb, i, movement);
                                if (move == 0)
                                {
                                    return 0;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    return 1;
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    return 1;
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
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
                            movement = -3;
                            check = 1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 3] != 0)
                                {
                                    move = 
                                    CheckmoveDiagonal(bw, wb, i, 
                                    movement, check);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                        else{
                            movement = -4;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 4] != 0)
                                {
                                    move = 
                                    CheckmoveStraight(bw, wb, i, movement);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                         boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
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
                            movement = 3;
                            check = -1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 3] != 0)
                                {
                                    move = 
                                    CheckmoveDiagonal(bw, wb, i, 
                                    movement, check);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                        else{
                            movement = 2;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 2] != 0)
                                {
                                    move = 
                                    CheckmoveStraight(bw, wb, i, movement);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                         boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
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
                            movement = -3;
                            check = 1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 3] != 0)
                                {
                                    move = 
                                    CheckmoveDiagonal(bw, wb, i, 
                                    movement, check);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                        else
                        {
                            movement = -2;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 2] != 0)
                                {
                                    move = 
                                    CheckmoveStraight(bw, wb, i, movement);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                         boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
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
                            movement = 3;
                            check = 1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 3] != 0)
                                {
                                    move = 
                                    CheckmoveDiagonal(bw, wb, i, movement, check);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    return 0;
                                }
                            }
                            i += 1;
                        }
                        else
                        {
                            movement = 4;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 4] != 0)
                                {
                                    move = 
                                    CheckmoveStraight(bw, wb, i, movement);
                                    if (move == 0)
                                    {
                                        return 0;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                         boardpos[i + movement];
                                        return 1;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        return 1;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
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

        public int CheckmoveStraight(int[] myArrayOne, int[] myArrayTwo, int i, 
        int move)
        {   
            int myIndex = -1;
            myIndex = Array.IndexOf(myArrayOne, boardpos[i + move]);
            if(myIndex == -1)
            {
                myIndex = Array.IndexOf(myArrayTwo, boardpos[i + move]);
                if(myIndex == -1)
                {
                    return 1;
                }
                else
                {
                    myIndex = -1;
                    myIndex = Array.IndexOf(myArrayOne, boardpos[i + (2*move)]);
                    if(myIndex == -1)
                    {
                        myIndex = Array.IndexOf(myArrayTwo, 
                        boardpos[i + (2*move)]);
                        if (myIndex == -1)
                        {
                            return 2;
                        }
                        else
                        {
                            Output.OnTopOfOtherPieces();
                            return 0;
                        }
                    }
                    else
                    {
                        Output.OnTopOfOtherPieces();
                        return 0;
                    }  
                }
            }
            else
            {
                Output.OnTopOfOtherPieces();
                return 0;
            }
        }

        public int CheckmoveDiagonal(int[] myArrayOne, int[] myArrayTwo, 
        int i, int move, int check)
        {
            int myIndex = -1;
            myIndex = Array.IndexOf(myArrayOne, boardpos[i + move]);
            if(myIndex == -1)
            {
                myIndex = Array.IndexOf(myArrayTwo, boardpos[i + move]);
                if(myIndex == -1)
                {
                    return 1;
                }
                else
                {
                    myIndex = -1;
                    myIndex = 
                    Array.IndexOf(myArrayOne, boardpos[i + (2*move+check)]);
                    if(myIndex == -1)
                    {
                        myIndex = Array.IndexOf(myArrayTwo, 
                        boardpos[i + (2*move+check)]);
                        if (myIndex == -1)
                        {
                            return 2;
                        }
                        else
                        {
                            Output.OnTopOfOtherPieces();
                            return 0;
                        }
                    }
                    else
                    {
                        Output.OnTopOfOtherPieces();
                        return 0;
                    }  
                }
            }
            else
            {
                Output.OnTopOfOtherPieces();
                return 0;
            }
        }
    }
}