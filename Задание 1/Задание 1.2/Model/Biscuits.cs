using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Задание_1._2.Users;

namespace Задание_1._2
{
    class Biscuits: SweetRepository
    {
        public string Biscuit()
        {
            foreach (string line in File.ReadAllLines(@"Biscuite.txt"))
            {
                Console.WriteLine(line); //если тут будет return, выведет 1 строку, а так все
            }
            return "";
            //foreach (var item in ReadCollection())
            //{
            //    Biscui = item.Chocolate;
            //    foreach (var items in Biscui)
            //    {
            //        Console.Write(items);

            //    }
            //    Console.WriteLine("\t");
            //}
            //Console.WriteLine(Biscui);
        }
    }
}
