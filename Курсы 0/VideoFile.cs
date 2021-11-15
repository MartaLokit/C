using System;
using System.Collections.Generic;
using System.Text;

namespace Курсы_0
{
    public class VideoFile: MediaFile, IAddition, IDeletion, ISearch
    {
        public string Author { get; set; }
        public int Quality { get; private set; }
        public string Duration { get; private set; }//продолжительность
       
    }
}