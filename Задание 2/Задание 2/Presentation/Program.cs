using System;
using Задание_2.Busines;
namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentService documentService = new DocumentService();        
            while(true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        documentService.GettingNumberWord();
                            break;
                    case "2":
                        documentService.GettingNumberChar();
                             break;
                }
            }
        }
    }
}
