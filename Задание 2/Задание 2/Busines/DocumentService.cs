using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Задание_2.Busines
{
    public class DocumentService: IDocumentService
    {
        public string NumberWord()
        {
            int number = 0;
            string[] text = File.ReadAllLines("HerFault .txt");
            foreach (var item in text)
            {
                var split = item.Split(new char[] { ' ', ',' });
                var linq = (from word in split select word.ToLower()).Distinct().OrderBy(s => s);
                for (int i = 1; i <= text.Length; i++)
                {
                    foreach (var items in linq)
                    {
                        number++;
                        int resault = (from word2 in split where word2.ToLower() == items select word2).Count();
                        Console.WriteLine($"{items}......{resault}.{i}"); 
                    }
                }
            }     
              return "";
        }
        public string NumberChar()
        {
            string input = "орлы на месте, от жары тает весь мир С ним еле живой, еле живой. Я лезу в ванну";
            var result = Regex.Matches(input, @"\b[о]\w+").Count;
            Console.WriteLine(result);
            return "";
            
        }
    }
}
