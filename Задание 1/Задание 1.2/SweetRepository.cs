using System;
using System.IO;
namespace Задание_1._2.Users
{
    public class SweetRepository : ISweetRepository
    {  
        public string[] sweets = File.ReadAllLines("set.txt");
        public string Read()
        {
            foreach (var item in sweets)
            {
                Console.WriteLine(item);
            }
            return " ";
        }
    }
}
