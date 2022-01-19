using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class BL
    {

        public static void movement(int direction, ref Group snake1)
        {

            switch (direction)
            {
                case 0:

                    UI.clearLastBlock(snake1);
                    folowUpHead(ref snake1);
                    snake1.bloks[0].y--;
                    UI.showGroup(snake1);
                    break;
                case 1:

                    UI.clearLastBlock(snake1);
                    folowUpHead(ref snake1);
                    snake1.bloks[0].x++;
                    UI.showGroup(snake1);
                    break;

                case 2:

                    UI.clearLastBlock(snake1);
                    folowUpHead(ref snake1);
                    snake1.bloks[0].y++;
                    UI.showGroup(snake1);
                    break;

                case 3:

                    UI.clearLastBlock(snake1);
                    folowUpHead(ref snake1);
                    snake1.bloks[0].x--;
                    UI.showGroup(snake1);
                    break;


            }
        }
        public static void folowUp(ref Group snake, int numOfBlok)
        {
            snake.bloks[numOfBlok + 1] = snake.bloks[numOfBlok];
        }
        public static void folowUpHead(ref Group group)
        {
            for (int i = group.quantilytyBloks; i < 0; i++)
            {
                folowUp(ref group, i);
            }
        }
        public static Blok CreateBlok(int x, int y)
        {
            Blok blok1 = new Blok();

            blok1.x = 0;
            blok1.y = 0;

            return blok1;
        }
        public static void AddBlokToSnake(Blok blok1, ref Group group)
        {

            
                group.bloks[group.quantilytyBloks] = blok1;
                group.quantilytyBloks++;
            

        }
        
    }
}