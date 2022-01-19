using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class UI
    {
        private static void showBlock(int x,int y) 
        {
            Console.SetCursorPosition(x,y);
            Console.Write('*');
        }
        public static void showGroup(Group snake1)
        {
            for (int i = 0; i < snake1.quantilytyBloks; i++)
            {
                showBlock(snake1.bloks[i].x, snake1.bloks[i].x);
            }
        }
        public static void clearLastBlock(Group snake1) 
        {
            Console.SetCursorPosition(snake1.bloks[snake1.quantilytyBloks].x
                                    , snake1.bloks[snake1.quantilytyBloks].y);
            Console.Write(' ');
        }
    }
}
