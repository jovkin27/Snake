using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Start
    {
        public ConsoleKeyInfo key;
        public Start()
        {
        }
        int valik = 0;
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
            }
            else if (key.Key == ConsoleKey.Q)
            {
                Console.Clear();
                Console.WriteLine("          ／＞　 フ");
                Console.WriteLine("         | 　_　 _|");
                Console.WriteLine("        ／`ミ _x 彡");
                Console.WriteLine("       /　　　 　 |");
                Console.WriteLine("      /　 ヽ　　 ﾉ");
                Console.WriteLine("　／￣|　　 |　|　|");
                Console.WriteLine("　| (￣ヽ＿_ヽ_)_)");
                Console.WriteLine("　＼二つ");
                Console.Beep();
                Environment.Exit(1);
            }
            return valik;
        }
    }
}
