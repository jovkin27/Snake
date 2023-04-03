using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public class Start //стар меню, выбор размера поля и конец игры
    {
        public ConsoleKeyInfo key;
        public Start()
        {
        }
        int valik = 0;
        public void Game_stop()
        {
            Console.Clear();
            Console.WriteLine("                   ");
            Console.WriteLine("    /)/)   (\\..../)    (\\(\\ ");
            Console.WriteLine("  (':' )    (=';'=)    (=':')");
            Console.WriteLine("(\")(\") )   (\") -- (\")  ( (\")(\")");
            Parametrs settings = new Parametrs();
            Sounds exit = new Sounds(settings.GetResourceFolder());
            exit.Play("exit.mp3");
            Thread.Sleep(2500);
            Environment.Exit(1);


        }
        public int choice()
        {

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("<------------------>");
            Console.WriteLine(" Start game - S\n Quit game - Q");
            Console.WriteLine("<------------------>");
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("------------------");
                Console.WriteLine(" Large map - L\n Small map - S");
                Console.WriteLine("------------------");
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.L)
                {
                    valik = 101;
                }
                if (key.Key == ConsoleKey.S)
                {
                    valik = 80;
                }
                Console.Clear();
                Console.SetCursorPosition(0, 5);
            }
            else if (key.Key == ConsoleKey.Q)
            {
                valik = 2;
            }
            return valik;

        }
    }
}
