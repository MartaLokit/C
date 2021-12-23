using System.IO;
using System;
namespace Задание_3._1.Data_Base
{
    public class CollectionPhone:Path
    {
        public string phone;
        public string name;
        public string GetData()
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();
            return str;
        }
        public void GetNumberPhone(string name)
        {
            foreach (var item in path)
            {
                var values = item.ToString().Split(' ');
                phone = values[0];
                Console.Write(phone);
            }
        }
    }
}
