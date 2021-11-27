using System;
using System.Collections.Generic;
using System.IO;
namespace Задание_1._2.Users
{
    public class SweetRepository : ISweetRepository
    {  
        public IEnumerable<SweetBase> Read()
        {
            var sweets = File.ReadAllLines("set.txt");
            foreach (var sweet in sweets)
            {
                var values = sweet.Split(',');
                yield return  new SweetBase
                {
                    Name = values[0],
                    Price = Convert.ToDouble(values[1]),
                    Sugar = Convert.ToInt32(values[3]),
                    Weight= Convert.ToInt32(values[2])
                };
            }          
        }
    }
}
