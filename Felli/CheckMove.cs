using System;
namespace Felli
{
    public class CheckMove
    {
        Output output = new Output();
        private int[] validationArray;
        public CheckMove()
        {
            validationArray = new int[] {0, 0};
        }
        
        public int Validation(int validnumber)
        {
            if (validnumber != -1){
                validationArray[1] = validnumber;
                return validationArray[0];
            }
            else
            {
                validationArray[0] = validnumber;
                return validationArray[1];
            }
        }
        public int CheckmoveStraight(int[] myArrayOne, int[] myArrayTwo, int i, 
        int move, int[] boardpos)
        {   
            int temp;
            int myIndex = -1;
            myIndex = Array.IndexOf(myArrayOne, boardpos[i + move]);
            if(myIndex == -1)
            {
                myIndex = Array.IndexOf(myArrayTwo, boardpos[i + move]);
                if(myIndex == -1)
                {
                    temp = Validation(1);
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
                            temp = Validation(1);
                            return 2;
                        }
                        else
                        {
                            temp = Validation(0);

                            return 0;
                        }
                    }
                    else
                    {
                        temp = Validation(0);

                        return 0;
                    }  
                }
            }
            else
            {
                temp = Validation(0);

                return 0;
            }
        }

        public int CheckmoveDiagonal(int[] myArrayOne, int[] myArrayTwo, 
        int i, int move, int check, int[] boardpos)
        {
            int temp;
            int myIndex = -1;
            myIndex = Array.IndexOf(myArrayOne, boardpos[i + move]);
            if(myIndex == -1)
            {
                myIndex = Array.IndexOf(myArrayTwo, boardpos[i + move]);
                if(myIndex == -1)
                {
                    temp = Validation(1);
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
                            temp = Validation(1);
                            return 2;
                        }
                        else
                        {
                            temp = Validation(0);

                            return 0;
                        }
                    }
                    else
                    {
                        temp = Validation(0);

                        return 0;
                    }  
                }
            }
            else
            {
                temp = Validation(0);

                return 0;
            }
        }

        public int CheckStuck(int[] myArrayOne, 
        int[] myArrayTwo, int[] boardpos)
        {
            int i = 0;
            int check;
            int move = 3;
            int numOfMoves = 0;
            i = 0;
            foreach(int j in myArrayOne)
            {   
                i = Array.IndexOf(boardpos, j);
                // Movimento para a direita
                if (j == 3 || j == 4 || j == 12 || j == 13 || j == 22 ||
                j == 23 || j == 31 || j == 32)
                {
                    move = 1;
                    if (boardpos[i + move] != 0)
                    {
                        numOfMoves += 
                        CheckmoveStraight(myArrayOne, myArrayTwo, i,
                        move, boardpos);
                    }
                }
                // Movimento para a esquerda
                if (j == 4 || j == 5 || j == 13 || j == 14 || j == 23 
                || j == 24 || j == 32 || j == 33)
                {
                    move = -1;
                    if (boardpos[i + move] != 0)
                    {
                        numOfMoves += 
                        CheckmoveStraight(myArrayOne, myArrayTwo, i,
                        move, boardpos);
                    }
                }
                // Movimento para cima
                if (j == 4 || j == 13 || j == 18 || j == 23 ||j == 32)
                {
                    move = -3;
                    if (boardpos[i + move] != 0)
                    {
                        numOfMoves += 
                        CheckmoveStraight(myArrayOne, myArrayTwo, i,
                        move, boardpos);
                    }
                }
                //Movimento para baixo
                if (j == 4 || j == 13 || j == 18 || j == 23 ||j == 32)
                {
                    move = 3;
                    if (boardpos[i + move] != 0)
                    {
                        numOfMoves += 
                        CheckmoveStraight(myArrayOne, myArrayTwo, i,
                        move, boardpos);
                    }
                }
                //Movimento para cima direita
                if (j == 12 || j == 14 || j == 18 || j == 24 || j == 32 
                || j == 33)
                {
                    if(j == 12 || j == 33)
                    {
                        move = -3;
                        check = -1;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += CheckmoveDiagonal(myArrayOne,
                            myArrayTwo, i, move, check, boardpos);
                        }
                    }
                    else
                    {
                        move = -4;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += 
                            CheckmoveStraight(myArrayOne, myArrayTwo, i,
                            move, boardpos);
                        }
                    }
                }
                //Movimento para cima esquerda
                if (j == 12 || j == 14 || j == 18 || j == 22 || j == 31 
                || j == 32)
                {
                    if(j == 14 || j == 31)
                    {
                        move = -3;
                        check = 1;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += CheckmoveDiagonal(myArrayOne,
                            myArrayTwo, i, move, check, boardpos);
                        }
                    }
                    else
                    {
                        move = -2;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += 
                            CheckmoveStraight(myArrayOne, myArrayTwo, i,
                            move, boardpos);
                        }
                    }
                }
                //Movimento para baixo esquerda
                if (j == 3 || j == 4 || j == 12 || j == 18 || j == 22 
                || j == 24)
                {
                    if(j == 12 || j == 33)
                    {
                        move = -3;
                        check = -1;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += CheckmoveDiagonal(myArrayOne,
                            myArrayTwo, i, move, check, boardpos);
                        }
                    }
                    else
                    {
                        move = -4;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += 
                            CheckmoveStraight(myArrayOne, myArrayTwo, i,
                            move, boardpos);
                        }
                    }
                }
                //Movimento para baixo direita
                if (j == 4 || j == 5 || j == 14 || j == 18 || j == 22 
                || j == 24)
                {
                    if(j == 5 || j == 22)
                    {
                        move = 3;
                        check = -1;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += CheckmoveDiagonal(myArrayOne,
                            myArrayTwo, i, move, check, boardpos);
                        }
                    }
                    else
                    {
                        move = 2;
                        if (boardpos[i + move] != 0)
                        {
                            numOfMoves += 
                            CheckmoveStraight(myArrayOne, myArrayTwo, i,
                            move, boardpos);
                        }
                    }
                }            
            }           
            return numOfMoves;
        }
    }
}