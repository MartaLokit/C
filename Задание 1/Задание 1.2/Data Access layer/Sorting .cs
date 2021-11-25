using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Задание_1._2.Users;
using System.Text.RegularExpressions;

namespace Задание_1._2
{
    class Sorting
    {
        public string[] sweets = File.ReadAllLines("sweets.txt");
      
        public string sortAlphabet()
        {
            IEnumerable<string> query = from word in sweets
                                        orderby word
                                        select word;
            foreach (string str in query)
            {
                Console.Write(str + " ");
            }
            return " ";
            
        }
        public int sortPrice()
        {
            List<Composition> composition = new List<Composition>();
            composition.Add(new Composition() { SweetName= "Stevia", Price = 9.13 });
            composition.Add(new Composition() { SweetName = "Добрый совет", Price = 11.45 });
            composition.Add(new Composition() { SweetName = "Петродиет", Price = 8.65 });
            composition.Add(new Composition() { SweetName = "Авиатор", Price = 15.45 });
            composition.Add(new Composition() { SweetName = "AlboFruits", Price = 17.56 });
            composition.Add(new Composition() { SweetName = "Вишневые", Price = 9.57 });
            composition.Add(new Composition() { SweetName = "Страйк двойной вкус", Price = 9.37 });
            composition.Add(new Composition() { SweetName = "Тимми микс", Price = 18.65 });
            composition.Add(new Composition() { SweetName = "Клубника со сливками", Price = 15.65 });
            composition.Add(new Composition() { SweetName = "BORA BORA", Price = 19.45 });
            composition.Add(new Composition() { SweetName = "Золотая лилия", Price = 7.56 });
            composition.Add(new Composition() { SweetName = "Ярче", Price = 9.13 });
            composition.Add(new Composition() { SweetName = "На Позитиве", Price = 9.65 });
            composition.Add(new Composition() { SweetName = "MilkyWay", Price = 15.65 });
            composition.Add(new Composition() { SweetName = "JohnyCrocker", Price = 5.12 });
            composition.Add(new Composition() { SweetName = "Бине", Price = 6.78 });
            composition.Add(new Composition() { SweetName = "Живинка", Price = 7.97 });
            composition.Add(new Composition() { SweetName = "Пчелка", Price = 6.89 });
            composition.Add(new Composition() { SweetName = "Фритландия", Price = 5.67 });
            

            var resault = from word in composition
                                        orderby word.Price
                                        select word;
            foreach (Composition com in resault)
            {
                Console.WriteLine($"{com.Price}- - -{com.SweetName}");
            }
            return 0;
        }
  
    }
}
