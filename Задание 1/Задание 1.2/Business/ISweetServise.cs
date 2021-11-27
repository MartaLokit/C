using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1._2.Business
{
    public interface ISweetServise
    {
         //IEnumerable<SweetBase> Sort(IEnumerable<SweetBase> sweets)
         string Sort();
         string Search();
         string Display();
         string Add();

    }
}
