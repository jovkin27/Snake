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
        public void game_draw(int ymap)
        {
            Console.Clear();
            Console.Title = "Snake";
            Console.SetWindowSize(ymap, 26);
            HorizontalLIne upline = new HorizontalLIne(0, ymap - 1, 0, '+');
            HorizontalLIne downline = new HorizontalLIne(0, ymap - 1, 25, '+');
            VerticalLine leftline = new VerticalLine(1, 25, 0, '+');
            VerticalLine rightline = new VerticalLine(1, 25, ymap - 1, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(4, 5, '*', ConsoleColor.Red);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
           
        }
    }


}
