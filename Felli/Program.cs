using System;

namespace Felli
{
    /// <summary>
    /// classe Program cria uma instância do game 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Positions a = new Positions();
            CheckMove z = new CheckMove();
            Game game = new Game();
            game.gameloop(a , z);
        }
    }
}
