using System;
namespace Felli
{
    public class Game
    {
        Output output = new Output();
        /// <summary>
        /// struct onde é guardada a informação sobre a jogada de um jogador em
        /// cada turno
        /// </summary>
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
        /// <summary>
        /// este método utiliza as peças, 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="z"></param>
        public void gameloop(Positions a, CheckMove z)
        {
            int turncounter;
            int turno = 0;
            bool gameover = false;
            bool gamestarted = false;
            bool validmove = false;
            int validation = 0;
            int lengthB;
            int lengthW;
            int[] b = a.GetB();
            int[] w = a.GetW();
            string second_input;
            int[] boardpos;
            int possiblemoves;
            
            //loop principal do jogo
            do
            {
                possiblemoves = 0;
                output.instructions();
                output.printBoard(a);
                //verifica se o jogo começou ou não para os jogadores terem de 
                //escolher qual dos jogadores começa
                if (gamestarted == false)
                {
                    output.startOutput();
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
                        output.invalidInput();
                    }
                }
                //ronda normal
                else
                {
                    b = a.GetB();
                    w = a.GetW();
                    boardpos = a.boardpos;
                    if ((turno % 2) == 0)
                    {
                        possiblemoves += z.CheckStuck(b, w, boardpos);
                        
                        if ( possiblemoves == 0)
                        {
                            output.BlacksWIn();
                            gamend();
                        }
                    }
                    else
                    {
                        possiblemoves += z.CheckStuck(w, b, boardpos);
                        
                        
                        if ( possiblemoves == 0)
                        {
                            output.WhitesWIn();
                            gamend();
                        }
                    }
                    lengthB = b.Length;
                    lengthW = w.Length;
                    //verifica se algum dos jogadores está sem peças
                    if (lengthB != 0 && lengthW != 0)
                    {
                        turncounter = turn(turno);
                        TurnInformation c;
                        //Este while não permite que passe para o próximo turno
                        //sem o jogadores darem input válido
                        while (validmove == false)
                        {
                            second_input = Console.ReadLine();
                            //If verifica se o input dado pelo o utilizador é um
                            //número ou não
                            if (int.TryParse(second_input, out c.piece))
                            {
                                c.direction=Convert.ToChar(Console.ReadLine());
                                //método que irá definir e verificar o movimento
                                //das peças
                                a.SetPeace(c.piece, c.direction, turno, z);
                                validation = z.Validation(-1);
                                if (validation == 1)
                                { 
                                    validmove = true;
                                }
                            }
                            else if(second_input == "exit")
                            {
                                gamend();
                            }
                            else
                            {
                                output.invalidInput();
                            }
                        }
                        //termina um turno e repete-se o ciclo do while
                        validmove = false;
                        turno++;   
                    }
                    else
                    {
                        gameover = true;
                    }
                }
            } while (gameover == false);
        }
        public int turn(int turn)
        {
            output.turnOutput(turn);
            turn++;
            return turn;
        }
        public void gamend()
        {
            //código para sair do programa
            System.Environment.Exit(0);
        }
    }
}