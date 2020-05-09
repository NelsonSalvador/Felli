using System;

namespace Felli
{
    class Program
    {
        static void Main(string[] args)
        {
            Output.instructions();
            Output.printBoard();
            game.gameloop();
        }
    }
}
