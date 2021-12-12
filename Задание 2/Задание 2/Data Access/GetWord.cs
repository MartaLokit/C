using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Задание_2.Data_Access
{
    public  class GetWord
    {
        public string Word()
        {
            return File.ReadAllText("HerFault  — копия.txt");
        }
    }
}
