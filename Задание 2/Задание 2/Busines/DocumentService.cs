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
            string[] text = File.ReadAllLines("HerFault  — копия.txt");
            foreach (var item in text)
            {
                var split = item.Split(new char[] { ' ', ',' });
                var linq = (from word in split select word.ToLower()).Distinct()/*.OrderBy(s => s)*/;
                for (int i = 1; i <= text.Length; i++)
                {
                    foreach (var items in linq)
                    {
                        int resault = (from word2 in split where word2.ToLower() == items select word2).Count();
                        Console.WriteLine($"{items}......{resault}.{i}");
                    }
                }
            }
            return "";
        }
        public string NumberChar()
        {
            string[] text = File.ReadAllLines("HerFault .txt");
            char letter = 'о';
            int resault=0;
            int i=1;
            Console.WriteLine(letter);
            
            foreach (var item in File.ReadAllLines("HerFault .txt"))
            {
                string[] words = item.Split(new[] { ',', ' ', '.' });
                var linq = (from word in words select word.ToLower()).Distinct()/*.OrderBy(s => s)*/;
                
                foreach (var word in linq)
                {
                    char[] s = word.ToCharArray();
                    if (s[0] == letter)
                    {
                        resault = (from word2 in words where word2.ToLower() == word select word2).Count();
                        var spl = item.Split('\n');
                        Console.WriteLine($"{word}......{resault}...{i++}");
                    }
                }
            }
            return "";
        }
    }
}
