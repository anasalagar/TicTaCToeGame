using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE GAME ");
            Console.ReadLine();
            
            TicTakGame.choosrlatter();
            TicTakGame.board();
        }
    }
}
