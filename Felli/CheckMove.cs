using System;
namespace Felli
{
    public class CheckMove
    {
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
                            Output.OnTopOfOtherPieces();
                            return 0;
                        }
                    }
                    else
                    {
                        temp = Validation(0);
                        Output.OnTopOfOtherPieces();
                        return 0;
                    }  
                }
            }
            else
            {
                temp = Validation(0);
                Output.OnTopOfOtherPieces();
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
                            Output.OnTopOfOtherPieces();
                            return 0;
                        }
                    }
                    else
                    {
                        temp = Validation(0);
                        Output.OnTopOfOtherPieces();
                        return 0;
                    }  
                }
            }
            else
            {
                temp = Validation(0);
                Output.OnTopOfOtherPieces();
                return 0;
            }
        }
    }
}