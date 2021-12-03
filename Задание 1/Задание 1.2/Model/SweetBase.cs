using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Задание_1._2
{
    public /*abstract */ class SweetBase
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Sugar { get; set; }
        public double Price { get; set; }
        public  string GetInfo()
        {
            return Name + Weight + Sugar + Price;
        }

    }
}
