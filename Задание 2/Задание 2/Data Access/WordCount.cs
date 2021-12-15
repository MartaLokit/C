using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Задание_2.Data_Access
{
    public class WordCount:GetWord
    {
        public int GetCount(string word)
        {
            var allwords = Word().Split(' ', '.', '\t', ':');
            int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
            return cnt;
        }
        public int GetCountLetter(string word)
        {
            var allwords = Word().Split(' ', ',', '.');
            int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
            return cnt;
        }
    }
}
