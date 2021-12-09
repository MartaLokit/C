using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Задание_2.Busines
{
    public class Class1
    {
        public int Number()
        {
            var text = File.ReadAllText("HerFault .txt");
            var all = text.Split('.');
            int i = 0;
            for ( i = 0; i < all.Length; i++)
            {
                
            }
            return i;
        }
    }
}
