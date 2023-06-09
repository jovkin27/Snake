﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class MyFileWriter //записывает имя и очки в тхт файл
    {
        public void WriteNameAndScoreToFile(string name, int score)
        {
            using (StreamWriter sw = new StreamWriter("results.txt", true))
            {
                sw.WriteLine(name + " - " + score.ToString() + " points");
            }
        }

        public void ShowResults() //показывает их
        {
            Console.WriteLine("Results:");
            Console.WriteLine("--------");
            using (StreamReader reader = new StreamReader("results.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
