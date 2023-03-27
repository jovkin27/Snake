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
            HorizontalLIne upline = new HorizontalLIne(0, 78 , 0, '+');
            HorizontalLIne downline = new HorizontalLIne(0,78, 25, '+');
            VerticalLine leftline = new VerticalLine(0, 25, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 25, 78, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(4, 5, '*', ConsoleColor.Blue);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(101, 26, '@', ConsoleColor.White);
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
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
