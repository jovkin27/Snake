using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program //запускающая программа
    {

        static void Main(string[] args)
        {
            
           
            Start start = new Start();
            start.choice();

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*', ConsoleColor.Blue);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@', ConsoleColor.White);
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score(0);
            score.ScoreWrite();

            while (true)
            {
                if (walls.Ishit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("<------------------>");
                    Console.WriteLine("     GAME OVER      ");
                    Console.WriteLine("<------------------>");
                    Console.Write("Enter your name:\n ");
                    string name = Console.ReadLine();
                    Console.WriteLine(name);
                    if (name.Length < 3)
                    {
                        Console.WriteLine("Name should be at least 3 letters");
                        continue;
                    }
                    else
                    {
                        MyFileWriter writer = new MyFileWriter();
                        writer.WriteNameToFile(name);
                        writer.ShowResults();
                    }
                }
                if (snake.Eat(food))
                {
                    score.ScoreUp();
                    score.ScoreWrite();
                    Console.Beep();
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
