using System;
using System.Linq;
namespace Felli
{
    public class Positions
    {
        Output output = new Output();
        private int[] b;
        private int[] w;
        //posições da board do jogo
        public int[] boardpos = new int[] { 0, 0, 0, 0, 3, 4, 5, 12, 13, 14, 
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="direction"></param>
        /// <param name="turno"></param>
        /// <param name="z"></param>
        public void SetPeace(int piece, char direction, int turno, CheckMove z)
        {
            int piece_remove;
            int[] bw;
            int[] wb;
            int i = 0;
            int move;
            int movement = 0;
            int check;
            int temp;

            bool straight = false;
            int[] val = null;
            

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
                default:
                    temp = z.Validation(0);
                    output.invalidInput();
                    break;
                case 's':
                    movement = 3;
                    straight = true;
                    val = new int[] {3, 5, 22, 24};
                    break;
                case 'w':
                    movement = -3;
                    straight = true;
                    val = new int[] {12, 14, 31, 33};
                    break;
                case 'a':
                    movement = -1;
                    straight = true;
                    val = new int[] {12, 31};
                    break;
                case 'd':
                    movement = +1;
                    straight = true;
                    val = new int[] {14, 33};
                    break;
                case 'q':
                    foreach(int j in boardpos)
                    {
                        if( j == 12 || j == 33)
                        {
                            movement = -3;
                            check = -1;
                            if (j == bw[piece - 1])
                            {
                                if (boardpos[i - 3] != 0)
                                {
                                    move = z.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();

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
                                        piece_remove = 
                                        Array.IndexOf(wb, boardpos[i+movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            movement = -4;
                            if (j == bw[piece - 1])
                            {
                                if (j == 13 || j == 22)
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }

                                if (boardpos[i - 4] != 0)
                                {
                                    move = z.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();

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
                                        if (j == 18)
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement+1)];
                                        }
                                        else 
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement)];
                                        }
                                        piece_remove = 
                                        Array.IndexOf(wb, boardpos[i+movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }
                            }
                        }
                        i++;
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
                                    move = z.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();

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
                                        piece_remove = 
                                        Array.IndexOf(wb, boardpos[i+movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }
                            }
                            i += 1;
                        }
                        else{
                            movement = 2;
                            if (j == bw[piece - 1])
                            {
                                if (j == 3 || j == 12 || j == 23 || j == 31)
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }

                                if (boardpos[i + 2] != 0)
                                {
                                    move = z.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();
                                      
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
                                        if (j == 18)
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement+1)];
                                        }
                                        else 
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement)];
                                        }
                                        piece_remove = Array.IndexOf(wb, 
                                        boardpos[i + movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
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
                                    move = z.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();

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
                                        piece_remove =
                                        Array.IndexOf(wb, boardpos[i+movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
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
                                if (j == 24 || j == 33 || j == 5 || j == 13)
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }
                                if (boardpos[i - 2] != 0)
                                {
                                    move = z.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();

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
                                        if (j == 18)
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement-1)];
                                        }
                                        else 
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement)];
                                        }
                                        piece_remove = 
                                        Array.IndexOf(wb, boardpos[i+movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            !=piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
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
                                    
                                    move = z.CheckmoveDiagonal(bw, wb,
                                    i, movement, check, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();

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
                                        piece_remove =
                                        Array.IndexOf(wb, boardpos[i+movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                        
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            movement = 4;
                            if (j == bw[piece - 1])
                            {
                                if (j == 14 || j == 23)
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }

                                if (boardpos[i + 4] != 0)
                                {
                                    move = z.CheckmoveStraight(bw, wb,
                                    i, movement, boardpos);
                                    if (move == 0)
                                    {
                                        temp = z.Validation(0);

                                        output.InvalidMove();

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

                                        if (j == 18)
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement-1)];
                                        }
                                        else 
                                        {
                                            bw[piece - 1] = 
                                            boardpos[i + (2*movement)];
                                        }
                                        
                                        piece_remove = 
                                        Array.IndexOf(wb, boardpos[i+movement]);
                                        if (wb == b)
                                        {
                                            b = b.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        else
                                        {
                                            w = w.Where((source, index) => index
                                            != piece_remove).ToArray();
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }
                            }
                        }
                        i += 1;
                    }
                    break;
            }

            if (straight == true)
            {
                foreach(int j in boardpos)
                {
                    if (j == bw[piece - 1])
                    {
                        if (boardpos[i + movement] != 0)
                        {
                            foreach(int ival in val)
                            {
                                if (j == ival)
                                {
                                    temp = z.Validation(0);
                                    output.InvalidMove();
                                    break;
                                }
                            }
                            move = z.CheckmoveStraight(bw, wb,
                            i, movement, boardpos);
                            if (move == 0)
                            {
                                temp = z.Validation(0);
                                output.InvalidMove();
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
                                piece_remove = Array.IndexOf(wb, boardpos[i 
                                + movement]);
                                if (wb == b)
                                {
                                    b = b.Where((source, index) => index !=
                                    piece_remove).ToArray();
                                }
                                else
                                {
                                    w = w.Where((source, index) => index !=
                                    piece_remove).ToArray();
                                    Console.WriteLine(w.Length);
                                }
                                break;                                   
                            } 
                        }
                        else
                        {
                            temp = z.Validation(0);
                            output.InvalidMove();
                            break;
                        }
                    }
                    i += 1;
                }
                straight = false;
            }
        }
    }
}