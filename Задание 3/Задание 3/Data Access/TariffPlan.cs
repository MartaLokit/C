using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3.Data_Access
{
    public class TariffPlan
    {
        public string GetName()
        {
            string nameunlimited = "Безлимитище+";
            Console.WriteLine(nameunlimited);
            return nameunlimited;
        }
        public double GetPrice()
        {
            double priceunlimited = 25.48;
            Console.WriteLine(priceunlimited);
            return 25.48;
        }
        public string Contains()
        {
            string containsunlimited = "Безлимитный интернет, 100 МБ режим модема, 400 мин звонки во все сети РБ," +
            " ТВ и кино кино и серриалы с бесплатным трафиком";
            Console.WriteLine(containsunlimited);
            return containsunlimited;
        }
        public string GetInfo()
        {
            return $"{GetName()} {GetPrice()}  {Contains()}";
        }

    }
}
