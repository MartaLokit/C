using System;
using System.Collections.Generic;
using System.Text;
using Задание_3.Data_Access;

namespace Задание_3.Busines
{
    class Phone:DataBase
    {
        public string Name;
        public string DateOfBirth;
        public string NumbersPhone;
        public void NumberPhone()
        {
            foreach (var item in Data())
            {
                var values = item.ToString().Split('\t');
                Name = values[0];
                DateOfBirth = values[1];
                NumbersPhone = values[2];
            }
        }
    }
}
