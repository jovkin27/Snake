using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class MyFileWriter
    {
        string name;

        public void WriteNameToFile(string name)
        {

            using (StreamWriter writer = new StreamWriter("results.txt",true))
            {
                writer.WriteLine(name);
            }

            Console.WriteLine("Имя успешно добавлено в файл.");
          
        }
        public void ShowResults()
        {
            StreamReader from_file = new StreamReader("results.txt");
            string text = from_file.ReadToEnd();
            Console.WriteLine(text);
            from_file.Close();
        }
    }
}
