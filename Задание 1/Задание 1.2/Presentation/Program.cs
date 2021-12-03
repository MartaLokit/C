using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Задание_1._2.Users;
using Задание_1._2.Business;
using Задание_1._2;
namespace Задание_1._2
{
    class Program
    {
        static void Main(string[] args)
        {         
            var isWorking = true;
            Lollipops lollipops = new Lollipops();
            СhocolateSweets сhocolateSweets = new СhocolateSweets();
            var sweetBase = new SweetBase();
            SweetService sweetServise = new SweetService();
            //var sweets = sweetServise.GetSweets();
            //var sweets = sweetServise.Sort();
            Biscuits biscuits = new Biscuits();
           
            while (isWorking)
            {
                Console.WriteLine("* * * * * * * * Рабочая панель * * * * * * * * ");
                Console.WriteLine("1 - создание подарка  * * * 2 - сортировка * * * 3 - поиск * * *  4 - состав");// добавить 4-вывод состава
                var number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Console.WriteLine("Пример заполнения: Пчелка*3,46");
                        Console.WriteLine(sweetServise.Display());
                        Console.WriteLine(sweetServise.Add());
                        break;
                    case "2":
                        foreach (var item in sweetServise.Sort())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3"://+-
                        Console.Write("Введите для поиска  ");
                        Console.WriteLine(sweetServise.Search());
                        break;
                    case "4"://
                        Console.WriteLine("1-Печенье * * * 2 - Шоколадные конфеты * * * 3 - Леденцы");
                        var Сomposition = Console.ReadLine();
                        switch (Сomposition)
                        {
                            case "1":
                                Console.WriteLine(biscuits.Biscuit()+"\t");
                                break;
                            case "2":
                                Console.WriteLine(сhocolateSweets.СhocolateSweet() + "\t");
                                break;
                            case "3":
                                Console.WriteLine(lollipops.lollipops() + "\t");
                                break;
                        }
                        break;
                }
               
            }
            
        }
    }
}
