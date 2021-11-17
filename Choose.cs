using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Game
{
    public class TicTakGame
    {
        char[] Board = new char[10];
        public void gameBoard()
        {
            for (int i = 1; i < 9; i++)
            {
                Board[i] = ' ';
            }
            Console.ReadLine();
        }
        public static void choosrlatter()
        {
            char letter;
            Console.WriteLine("choose a latter  any one X or O :");
            letter = Console.ReadLine()[0];

            if (letter =='X')
            {
                Console.WriteLine("player's choose = 'X'");
                Console.WriteLine("computer choose = 'O'");
            }
            else if (letter=='O')
            { 
                Console.WriteLine("player's choose = 'O' ");
                Console.WriteLine("computer choose = 'X' ");
            }
            else
            {
                Console.WriteLine("press Ov or X");
            }
            Console.ReadLine();
        }
    }
}
