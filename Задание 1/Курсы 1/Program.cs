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
            //LollipopsFirm lollipopsFirm  = new LollipopsFirm();
            //StreamWriter sw = new StreamWriter("Lollipops.txt");
            //sw.WriteLine(lollipopsFirm);
            string[] ChocolateSweet = File.ReadAllLines("fier.txt");
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
                    foreach (var i in sorting)
                    {
                        Console.WriteLine(sorting);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка в заполнении");
                    break;
            }
        }
    }
}
