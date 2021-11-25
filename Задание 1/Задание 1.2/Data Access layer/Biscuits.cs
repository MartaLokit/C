using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Задание_1._2
{
    class Biscuits : Composition
    {
        public string sugar()
        {
            string sugars = Console.ReadLine();
            foreach (string line in File.ReadAllLines(@"BiscuitsSugar.txt"))
            {
                if (line.Contains(sugars))
                {
                    return line;
                }
            }
            return "";

        }
    }
}
