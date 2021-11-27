using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1._2
{
   public interface ISweetRepository
   {
        IEnumerable<SweetBase> Read();
   }
}
