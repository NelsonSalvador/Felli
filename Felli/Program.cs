using System;

namespace Felli
{
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
