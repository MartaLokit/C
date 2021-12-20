using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Задание_3.Data_Access
{
    class DataBase
    {
        private string path = @"DataUsers.txt";
        public string Data()
        {        
            string str = File.ReadAllText(path);
            return str;
        }
    }
}
