using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Задание_2.Data_Access
{
   public class NumberString:GetWord
    {
        public string[] Lines = File.ReadAllLines("HerFault  — копия.txt");
        public void GetNumberWord(string word)
        {
            int i = 0;
            for ( i = 1; i < Lines.Length; i++)
            {
                if (Lines[i].Contains(word))
                {
                    Console.Write(i +",");  
                }
            }
            
        }
        public void GetNumberLetter(string item)
        {
            var allwords = Word().Split(' ', '.', '\t', ',');
            char[] s = item.ToCharArray();
            var firstLetters = new String(item.Split(' ').Select(x => x[0]).ToArray());
            for (int i = 0; i < Lines.Length; i++)
            {
                if (s[0] == firstLetters[0])
                {
                    if (Lines[i].Contains(item))
                    {
                        Console.Write($"{i + 1},");
                    }
                }
            }
         }
    }
}
