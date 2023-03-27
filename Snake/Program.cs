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
        public void Main(string[] args)
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

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep( 100 );
                snake.Move();
            }
           
        }

    }


}
