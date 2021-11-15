using System;
using System.Collections.Generic;
using System.Text;

namespace Курсы_0
{
    public class File
    {
        public string Name { get; set; }
        //public string Extension { get; private set; }
        public int Size { get; private set; }
        public string path { get; set; }
        public string Extension { get; private set; }
        public File(string extension) => Extension = extension;
    }
}