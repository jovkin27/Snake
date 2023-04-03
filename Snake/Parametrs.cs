﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Parametrs
    {

        private string resourcesFolder;

        public Parametrs()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal); // Получить индекс папки bin

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                    .ToString(); // путь до указанной в инкесе папки

            resourcesFolder = binFolder + "Resources\\";
        }

        public string GetResourceFolder()
        {
            return resourcesFolder;
        }


    }
}
