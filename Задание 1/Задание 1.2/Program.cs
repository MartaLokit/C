using System.IO;
using System;
using System.Linq;
using Задание_1._2.Users;

namespace Задание_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };
            Composition composition = new Composition();
            Biscuits biscuits = new Biscuits();
            Lollipops lollipops = new Lollipops();
            СhocolateSweets сhocolate = new СhocolateSweets();
            Sorting sorting = new Sorting();
            Console.Write("Выберете пожалуйста вес: 550, 850,1000: "); 
            composition.WeightSet = Convert.ToInt32(Console.ReadLine());
            if (composition.WeightSet == 550 || composition.WeightSet == 850 || composition.WeightSet == 1000)
            {
                Console.WriteLine("Сохранено");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                composition.WeightSet = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Состав: ");
            Console.WriteLine(composition.composition().ToString());
            Console.WriteLine("* * * * * Сортировка * * * * *");
            Console.WriteLine("1 - Алфавиту_______________2 - Цене");
            int res =Convert.ToInt32(Console.ReadLine());
            if (res==1)
            {
                Console.WriteLine(sorting.sortAlphabet().ToString());
            }
            if (res==2)
            {
                Console.WriteLine(sorting.sortPrice().ToString());
            }
            Console.WriteLine("* * * * * Поиск по содержанию сахара * * * * *");
            Console.WriteLine("1 - конфеты, 2 - леденцы, 3 - печенье ");
            int resault = Convert.ToInt32(Console.ReadLine());
            if (resault == 1)
            {
                Console.WriteLine("0,54,59,61,65");
            }
            if (resault == 2)
            {
                Console.WriteLine("39,56,58,59,65");
            }
            if (resault == 3)
            {
                Console.WriteLine("29,36,38,41");
            }
            Console.Write("Уровень сахара:   ");
            if (resault==1)
            {
                Console.WriteLine(сhocolate.sugar());
            }
            if (resault == 2)
            {
                Console.WriteLine(lollipops.sugar());
            }
            if (resault == 3)
            {
                Console.WriteLine(biscuits.sugar());
            }
            if (composition.WeightSet == 550)
            {
                Console.WriteLine("Стоимость 8.64");
            }
            if (composition.WeightSet == 850)
            {
                Console.WriteLine("Стоимость 10.12");
            }
            if (composition.WeightSet == 1000)
            {
                Console.WriteLine("12.56");
            }
        }
    }
}
