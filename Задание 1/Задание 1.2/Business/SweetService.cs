using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Задание_1._2.Business
{
    class SweetService : ISweetServise
    {
        SweetBase sweet = new SweetBase();
        private readonly ISweetRepository _sweetRepository;
        public SweetService(ISweetRepository sweetRepository)
        {
            _sweetRepository = sweetRepository;
        }
        public SweetService()
        {

        }
        //public IEnumerable<SweetBase> Sort(IEnumerable<SweetBase> sweets)
        //{
        //    return sweets.OrderBy(s => s.Name); 
        //}
        public string Sort()
        {
            string[] sweetq = File.ReadAllLines("set.txt");
            var orderedNumbers = from i in sweetq
                                 orderby i
                                 select i;
            foreach (string item in orderedNumbers)
            {
                Console.WriteLine(item);
            }
            return "";
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
        public string Add()
        {
            Console.WriteLine("Добавить:       Сохранить - 66");
            while (true)
            {
                string write = Console.ReadLine();
                if (write != "66")
                {
                    foreach (string sweets in File.ReadAllLines("set.txt"))
                    {
                        if (sweets.Contains(write.ToString()))
                        {
                            List<string> ts = new List<string>();
                            using (StreamWriter sw = new StreamWriter("Save.txt", true))
                            {
                                sw.WriteLine(write.ToString());
                                sw.Close();
                            }
                        }
                    }
                }
                if (write == "66")
                {
                    double resault = sweet.Price;
                    int i;
                    for (i = 0; i < resault; i++)
                    {
                        resault += resault;
                    }
                    Console.WriteLine($"Cумма:  {resault}");
                    break;
                }
            }
            return " ";
        }
    }
}
