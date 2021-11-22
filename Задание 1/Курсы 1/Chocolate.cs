using System;
using System.Collections.Generic;
using System.Text;

namespace Курсы_1
{
    enum ChocolateSweet
    {
        BORA_BORA,
        ЗолотаяЛилия,
        Ярче,
        НаПозитиве,
        MilkyWay,
        JohnyCrocker
    }
    public class ChocolateSweets : Сandies
    {

        public bool Bitter { get; set; }
        public bool Lactic { get; set; }
        public bool WithNuts { get; set; }
       
    }

}