using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{


    class Program
    {
        static readonly int x = 70; 
        static readonly int y = 30; 
        static Walls walls;
        static Snake snake;
        static AddFoodToBoard addfood;
        static Timer time;

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.SetWindowSize(x + 1, y + 1);
            Console.SetBufferSize(x + 1, y + 1);
            Console.CursorVisible = false;

            walls = new Walls(x, y, '_');
            snake = new Snake(x / 2, y / 2, 3);
            addfood = new AddFoodToBoard(x, y, '₿');
            addfood.CreateFood();

            time = new Timer(Loop, null, 0, 200);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Rotation(key.Key);
                }
            }
        }

        static void Loop(object obj)
        {
            if (walls.Сollision(snake.GetHead()) || snake.IsHit(snake.GetHead()))
            {
                time.Dispose();
                GameOver();

            }
            else if (snake.Eat(addfood.food))
            {
                addfood.CreateFood();
            }
            else
            {
                snake.Move();
            }

        }
        static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over");
        }
    }

}