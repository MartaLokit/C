using System;
using System.Collections.Generic;
using System.Text;

namespace Курсы_0
{
    public class Picture : MediaFile, IAddition, IDeletion, ISearch
    {
        public string Painter { get; set; }
    }
}