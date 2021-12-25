using System.IO;
using System;
namespace Задание_3._1.Data_Base
{
    public class CollectionPhone:Path
    {
        public string phone;
        public  string phoneSubscriber;
        public string name;
        public string GetData()
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();
            return str;
        }
        public string GetNumberPhone(string NameSubscriber)
        {
            foreach (var line in File.ReadAllLines(@"DataUsers.txt"))
            {
                if (line.Contains(NameSubscriber))
                {
                    var values = line.ToString().Split('\t');
                    phone = values[0];
                }
            }
            return phone;
        }
    }
}
