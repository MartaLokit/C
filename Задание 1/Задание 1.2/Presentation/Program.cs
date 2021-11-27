using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Задание_1._2.Users;
using Задание_1._2.Business;

namespace Задание_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetBase sweetBase = new SweetBase();

            var isWorking = true;
            SweetService sweet = new SweetService();
            while (isWorking)
            {
                Console.WriteLine("* * * * * * * * Рабочая панель * * * * * * * * ");
                Console.WriteLine("1 - создание подарка * * * 2 - сортировка * * * 3 - поиск * * * 66 - Выход");
                var number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Console.WriteLine(sweet.Display());
                        Console.WriteLine(sweet.Add());
                        break;
                    case "2":
                           Console.WriteLine(sweet.Sort());
                        break;
                    case "3"://+-
                        Console.Write("Введите для поиска  ");
                        Console.WriteLine(sweet.Search());
                        break;
                    case "66"://
                           break;
                }
            }
            
        }
    }
}
