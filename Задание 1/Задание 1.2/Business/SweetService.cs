using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Задание_1._2.Users;

namespace Задание_1._2.Business
{
    class SweetService : ISweetServise
    {
        SweetBase sweets = new SweetBase();
        SweetRepository SweetRepository = new SweetRepository();
        private readonly ISweetRepository _sweetRepository;
        public SweetService(ISweetRepository sweetRepository)
        {
            _sweetRepository = sweetRepository;
        }
        public SweetService()
        {

        }
        public IEnumerable<SweetBase> Sort(/*IEnumerable<SweetBase> sweets*/)
        {
            IEnumerable<SweetBase> sweets=SweetRepository.Read();
            return sweets.OrderBy(s => s.Name);
        }
        public IEnumerable<SweetBase> GetSweets()
        {
            return _sweetRepository.Read();          
        }
        public string Display()
        {
            StreamReader reader = new StreamReader("set.txt");
            string str = reader.ReadToEnd();
            reader.Close();
            return "\t" + str;
        }
        public string Search()
        {
            int number = 0;
            var write = Console.ReadLine();
            foreach (string sweets in File.ReadAllLines("set.txt"))
            {
                number++;
                if (sweets.Contains(write.ToString()))
                {
                    return sweets;
                }
            }
            return "-----------";
        }
        public double Add()
        {
            string[] save = File.ReadAllLines("Save.txt");
            Console.WriteLine("Добавить:       Сохранить - 66");
            while (true)
            {
                string write = Console.ReadLine();
                if (write != "66")
                {
                       List<string> ts = new List<string>();
                       using (StreamWriter sw = new StreamWriter("Save.txt", true))
                       {
                          sw.WriteLine(write.ToString());
                          sw.Close();
                       }
                }               
                if (write == "66")// готово 
                {
                    double sum = 0;
                    Console.Write("Состав: ");
                    foreach (var items in SweetRepository.ReadSave())
                    {
                        sum += items.Price;
                    }
                    return sum;

                }
            }
        }
    }
}
