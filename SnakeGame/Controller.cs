using System;

namespace SnakeGame
{
    class Controller
    {
        static void Main(string[] args)
        {
            ConsoleKey key = Console.ReadKey().Key;

            int keyCode = (int)key;
            Blok blok1 = BL.CreateBlok(10, 10);
            Blok blok2 = BL.CreateBlok(10, 11);


            Group snake = new Group();
            BL.AddBlokToSnake(blok1, ref snake);
            BL.AddBlokToSnake(blok2, ref snake);
            int x = 0;
            int y = 0;
            int a = 0;
            int dir = 2;

        

            while (a != 1)
            {
                BL.movement(dir, ref snake);
                switch (key)
                {
                    
                    case ConsoleKey.LeftArrow:
                        dir--;
                        if (dir == -1)
                        {
                            dir = 3;
                        }
                        //BL.movement(dir,ref snake);
                        break;
              
                    case ConsoleKey.RightArrow:
                        if (dir != 3) dir++;
                        else dir = 0;
                        //BL.movement(dir, ref snake);
                        break;

                    case ConsoleKey.Enter:
                        a = 1;
                        break;
                }
                key = Console.ReadKey().Key;
                
            }

        }
    }
}