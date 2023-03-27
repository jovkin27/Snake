using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {

        //int ymap = 0;
        static void Main(string[] args)
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*', ConsoleColor.Blue);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(101, 26, '@', ConsoleColor.White);
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (walls.Ishit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
            }

        }

    }


}
