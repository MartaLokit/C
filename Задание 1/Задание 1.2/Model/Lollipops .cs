using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Задание_1._2
{
    public class Lollipops 
    {
        public string lollipops()
        {
            foreach (string line in File.ReadAllLines(@"Lollipops.txt"))
            {
                Console.WriteLine(line); 
            }
            return "";
            

        }
    }
}
