using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Задание_2.Busines;
namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentService documentService = new DocumentService();
            //Console.WriteLine(documentService.NumberWord());//не до конца
            //Console.WriteLine("*****************************");
            Console.WriteLine(documentService.NumberChar());
        }
    }
}
