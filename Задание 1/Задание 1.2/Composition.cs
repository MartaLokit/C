using System;
using System.Collections.Generic;
using System.Text;
using Задание_1._2.Users;

namespace Задание_1._2
{
    class Composition
    {
        SweetRepository sweet = new SweetRepository();
        public string SweetName { get; set; }
        public int WeightSet { get; set; }
        public int Sugar { get; set; }
        public double Price { get; set; }
        public string composition()
        {
             return sweet.Read();
        }
    }
}
