using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToeGame
{
    class game
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
        }
    }
