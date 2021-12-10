using System;
using System.IO;
using System.Linq;

namespace Задание_2.Busines
{
    public class DocumentService : IDocumentService
    {    
        public string NumberWord()
        {
            string text = File.ReadAllText("HerFault  — копия.txt");
            var Lines = File.ReadAllLines("HerFault  — копия.txt");
            int i = 1;
            var allwords = text.Split(' ', '.');
            var unique = (from word in allwords select word.ToLower()).Distinct().OrderBy(name => name);
            foreach (var word in unique)
            {
                int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
                Console.Write($"\n{word}.....{cnt}...");
                for (i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i].Contains(word))
                    {
                        Console.Write($"{i + 1},");
                    }
                }
            }
            return "";
        }
        public string NumberChar()
        {
            string firstLetters;
            var word = File.ReadAllText("HerFault  — копия.txt");
            var Lines = File.ReadAllLines("HerFault  — копия.txt");
            var allwords = word.Split(' ', ',', '\n');
            var linq = (from words in allwords select words.ToLower()).Distinct().OrderBy(name => name);
            foreach (var item in linq)
            {
                char[] s = item.ToCharArray();
                firstLetters = new String(item.Split(' ').Select(x => x[0]).ToArray());
                if (s[0] == firstLetters[0])
                {
                    var cnt = (from word2 in allwords where word2.ToLower() == item select word2).Count();
                    Console.Write($"\n{item}......{cnt}.....");
                    for (int i = 0; i < Lines.Length; i++)
                    {
                        if (Lines[i].Contains(item))
                        {
                            Console.Write($"{i + 1},");
                        }
                    }
                }
            }
            return " ";
        }
    }
}
