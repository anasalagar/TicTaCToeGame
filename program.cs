using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game");
            game o = new game();
            o.gameBoard();
        }
    }
}
