using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Курсы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("Lollipops.txt");
            //sw.WriteLine(lollipopsFirm);
            // string[] ChocolateSweet = File.ReadAllLines("fier.txt");
            string[] ChocolateSweet = new string[3] { "яяяяяя","ффффф","аааааа"};
            NewYearSet newYearSet = new NewYearSet();
            newYearSet.SetName();
            Console.WriteLine("Объем: 500 гр, 700 гр, 850 гр, 1000 гр");
            Console.Write("Введите пожалуйста вес:  ");
            newYearSet.WeightSet = Console.ReadLine();
            Console.WriteLine(newYearSet.SetName().ToString() + "\n Состав: " + newYearSet.Composition().ToString() + "\n Цена: " + newYearSet.Price().ToString());
            Console.WriteLine("Сортировка по:\n  1-Цене \n 2-Новогоднему подарку ");
            var sort = Console.ReadLine();
            switch (sort)
            {
                case "1":
                    Console.WriteLine("500 гр, 700 гр, 850 гр, 1000 гр");
                    break;
                case "2":
                    var sorting = from i in ChocolateSweet
                                  orderby i
                                  select i; 
                    foreach (string i in sorting)
                    {
                        Console.WriteLine(sorting);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка в заполнении");
                    break;
            }
            Console.WriteLine("* * * * * * * Поиск конфет* * * * * * ");
            Console.WriteLine("* * * без сахара, 56 грамм , 84 граммa * * *");
            Console.WriteLine("Уровень сахара");
            var sugar = Console.ReadLine();
            int numberLine = 0;
            foreach(string line in File.ReadAllLines(@"sugar.txt"))
            {
                numberLine++;
                if (line.Contains(sugar))
                { 
                    Console.WriteLine(line); 
                }
                else
                {
                    Console.WriteLine("Таких нет");
                }
            }
        }
    }
}
