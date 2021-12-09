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
            var text = File.ReadAllText("HerFault .txt");
            var Lines = File.ReadAllLines("HerFault .txt");
            int i = 1;
            var allwords = text.Split(' ', '.', '\n');
            var unique =(from word in allwords select word.ToLower()).Distinct().OrderBy(name => name);
                foreach (var word in unique)
                {
                    int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
                    Console.Write($"\n{word}.....");
                    Console.Write($"{cnt}.....");
                for (i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i].Contains(word))
                    {
                        Console.Write($"{i + 1},");
                    }
                }

            }
            Console.ReadLine();
            return "";
        }
        public string NumberChar()
        {
            int cnt = 0;
            int i = 0;
            var firstLetters = "";
            string[] text = File.ReadAllLines("HerFault .txt");
            var Lines = File.ReadAllLines("HerFault .txt");
            var sort = text.OrderBy(s => s);
            foreach (var item in text)
            {
                firstLetters = new String(item.Split(' ').Select(x => x[0]).ToArray());
            }         
            foreach (var item in text)
            {
                string[] Split = item.Split(new[] { ' ', ',','\n' });
                var linq = (from word in Split select word.ToLower()).Distinct();
                foreach (string word in linq)
                {
                    cnt = (from word2 in Split where word2.ToLower() == word select word2).Count();
                    for (int k = 0; k < text.Length; k++)
                    {
                        if (word[0] == firstLetters[k])
                        {
                            Console.WriteLine($"\n{word}...............");
                            Console.Write($"{cnt}...");
                        }
                    }                   
                    for (i = 0; i < text.Length; i++)
                    {
                        if (Lines[i].Contains(word))
                        {
                            Console.Write($"{i+1},");
                        }
                    }
                }
            }
            return " ";
        }
    }
}
