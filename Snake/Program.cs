using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Runtime;

namespace Snake
{
    class Program //запускающая программа
    {

        public void Game_draw(int ymap)
        {
            Parametrs settings = new Parametrs();
            Sounds sound = new Sounds(settings.GetResourceFolder());
            sound.Play("main.mp3");
            Sounds dead = new Sounds(settings.GetResourceFolder());
            //Sounds eat = new Sounds(settings.GetResourceFolder());

            Walls walls = new Walls(ymap);
            walls.Draw();

            Point p = new Point(4, 5, '*', ConsoleColor.Red);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$', ConsoleColor.Green);
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score(0);
            score.ScoreWrite(120,10);

            while (true)
            {
                if (walls.Ishit(snake) || snake.IsHitTail())
                {
                    sound.Stop("main.mp3");
                    dead.Play("lost.mp3");
                    Console.Clear();
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("<------------------>");
                    Console.WriteLine("     GAME OVER      ");
                    Console.WriteLine("<------------------>");
                    Console.Write("Enter your name:\n ");
                    string name = Console.ReadLine();
                    dead.Stop("lost.mp3");
                    if (name.Length < 3)
                    {
                        Console.WriteLine("Name should be at least 3 letters");
                    }
                    else
                    {
                        MyFileWriter writer = new MyFileWriter();
                        writer.WriteNameAndScoreToFile(name, score.ScoreUp());
                        writer.ShowResults();
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
                }
                if (snake.Eat(food))
                {
                    Console.Beep();
                    //eat.Play("numnum.mp3");
                    score.ScoreUp();
                    score.ScoreWrite(90,10);
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    //eat.Stop("numnum.mp3");
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
        static void Main(string[] args)
        {
            
            Console.CursorVisible = false;
            Start start = new Start();

            while (true)
            {
                int ymap = start.Choice();
                if (ymap == 101 || ymap == 80)
                {
                    Program prog = new Program();
                    prog.Game_draw(ymap);
                }
                else 
                {
                    start.Game_stop();
                    break;
                }
            }

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }


    }

}
