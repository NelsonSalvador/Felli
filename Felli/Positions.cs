using System;
namespace Felli
{
    public class Positions
    {
        private int[] b;
        private int[] w;
        public int[] boardpos = new int[] { 0, 0, 0, 0, 3, 4, 5, 12, 13, 14, 
                                0, 18, 0, 22, 23, 24, 31, 32, 33, 0, 0, 0, 0};
        public Positions ()
        {
            //position of black pieces in the board
            b = new int[] {3, 4, 5, 12};
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
                                move = CheckMove.CheckmoveStraight(bw, wb,
                                i, movement, boardpos);
                                if (move == 0)
                                {
                                    Output.InvalidMove();
                                    break;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    break;
                                    
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    break;
                                    
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
                                break;
                            }
                        }
                        i += 1;
                    }
                    break;
                case 'w':
                    movement = -3;
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i - 3] != 0)
                            {
                                move = CheckMove.CheckmoveStraight(bw, wb,
                                i, movement, boardpos);
                                if (move == 0)
                                {
                                    Output.InvalidMove();
                                    break;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    break;
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    break;
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
                                break;
                            }
                        }
                        i += 1;
                    }
                    break;
                case 'a':
                    movement = -1;
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i - 1] != 0)
                            {
                                move = CheckMove.CheckmoveStraight(bw, wb,
                                i, movement, boardpos);
                                if (move == 0)
                                {
                                    Output.InvalidMove();
                                    break;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    break;
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    break;
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
                                break;
                            }
                        }
                        i += 1;
                    }
                    break;
                case 'd':
                    movement = +1;
                    foreach(int j in boardpos)
                    {
                        if (j == bw[piece - 1])
                        {
                            if (boardpos[i + 1] != 0)
                            {
                                move = CheckMove.CheckmoveStraight(bw, wb,
                                i, movement, boardpos);
                                if (move == 0)
                                {
                                    Output.InvalidMove();
                                    break;
                                }
                                else if(move == 1)
                                {
                                    bw[piece - 1] = boardpos[i + movement];
                                    break;
                                }
                                else if(move == 2)
                                {
                                    bw[piece - 1] = boardpos[i + (2*movement)];
                                    break;
                                } 
                            }
                            else
                            {
                                Output.InvalidMove();
                                break;
                            }
                        }
                        i += 1;
                    }
                    break;
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
                                    move = CheckMove.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        break;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        break;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
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
                                    move = CheckMove.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                        boardpos[i + movement];
                                        break;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        break;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
                                }
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
                            movement = 3;
                            check = -1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 3] != 0)
                                {
                                    move = CheckMove.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        break;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        break;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
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
                                    move = CheckMove.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                        boardpos[i + movement];
                                        break;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        break;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
                                }
                            }
                            i += 1;
                        }
                    }
                    break;
                case 'e':
                    foreach(int j in boardpos)
                    {
                        if( j == 14 || j == 31)
                        {
                            movement = -3;
                            check = 1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 3] != 0)
                                {
                                    move = CheckMove.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        break;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        break;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
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
                                    move = CheckMove.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                        boardpos[i + movement];
                                        break;

                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        break;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
                                }
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
                            movement = 3;
                            check = 1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 3] != 0)
                                {
                                    
                                    move = CheckMove.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] = boardpos[i + movement];
                                        break;
                                        
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = boardpos[i + 
                                        (2*movement + check)];
                                        break;
                                        
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            movement = 4;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i + 4] != 0)
                                {
                                    move = CheckMove.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        Output.InvalidMove();
                                        break;
                                    }
                                    else if(move == 1)
                                    {
                                        bw[piece - 1] =
                                         boardpos[i + movement];
                                        break;
                                    }
                                    else if(move == 2)
                                    {
                                        bw[piece - 1] = 
                                        boardpos[i + (2*movement)];
                                        break;
                                    }
                                }
                                else
                                {
                                    Output.InvalidMove();
                                    break;
                                }
                            }
                        }
                        i += 1;
                    }
                    break;
            } 
        }
    }
}