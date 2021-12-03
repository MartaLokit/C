using System;
using System.Collections.Generic;
using System.IO;
using Задание_1._2.Model;
namespace Задание_1._2.Users
{
    public class SweetRepository : ISweetRepository
    {  
        public IEnumerable<SweetBase> Read()
        {
            var sweets = File.ReadAllLines("set.txt");
            foreach (var sweet in sweets)
            {
                var values = sweet.Split('*');
                yield return  new SweetBase
                {
                    Name = values[0],
                    Price = Convert.ToDouble(values[1]),
                    Sugar = Convert.ToInt32(values[2]),
                    Weight = Convert.ToDouble(values[3])
                };
            }          
        }
        public IEnumerable<GiftSet> ReadCollection()
        {
            var sweets = File.ReadAllLines("set.txt");
            foreach (var sweet in sweets)
            {
                var values = sweet.Split("***");
                yield return new GiftSet
                {
                    Chocolate = values[0],
                    Biscuits = values[1],
                    Lollipops = values[2],
                };
            }
        }
        public IEnumerable<SweetBase> ReadSave()//можно так оставлять или нет?
        {
            var sweets = File.ReadAllLines("Save.txt");
            foreach (var sweet in sweets)
            {
                var values = sweet.Split('*');
                yield return new SweetBase
                {
                    Name = values[0],
                    Price = Convert.ToDouble(values[1]),

                };
            }
        }
    }
}
