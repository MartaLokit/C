using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Задание_1._2
{
    public class СhocolateSweets : SweetBase
    {
        public string СhocolateSweet()
        {
            foreach (string line in File.ReadAllLines(@"Chocolate.txt"))
            {
                Console.WriteLine(line); 
            }
            return "";


        }

    }
}


