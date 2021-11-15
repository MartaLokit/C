using System;
using System.Collections.Generic;
using System.Text;

namespace Курсы_0
{
    public class Songs:MediaFile,IAddition, IDeletion, ISearch
    {
        public string direction { get;  set; }
        public string PlaybackFrequency { get; private set; }//частота воспроизведения 
       
    }
}