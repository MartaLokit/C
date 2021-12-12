using System;
using System.IO;
using System.Linq;
using Задание_2.Data_Access;
namespace Задание_2.Busines
{
    public class DocumentService : IDocumentService
    {
        public GetWord getWord = new GetWord();
        public WordCount WordCount = new WordCount();
        public NumberString numberString = new NumberString();


        public void GettingNumberWord()
        {        
            string text = getWord.Word();
            var allwords = text.Split(' ', '.','\t',':');
            var unique = (from word in allwords select word.ToLower()).Distinct().OrderBy(name => name);
            foreach (var word in unique)
            {
                int cnt = WordCount.Count(word);
                Console.Write($"\n{word}.....{cnt}...");
                numberString.numberWord(word);
            }
        }
        public void GettingNumberChar()
        {
            var word = File.ReadAllText("HerFault  — копия.txt");
            var allwords = word.Split(' ', ',', '.');
            var linq = (from words in allwords select words.ToLower()).Distinct().OrderBy(name => name);
            foreach (var item in linq)
            {           
                 var cnt= WordCount.CountLetter(item);
                 Console.Write($"\n{item}......{cnt}.....");
                 numberString.numberLetter(item);
                
            }
        }
    }
}
