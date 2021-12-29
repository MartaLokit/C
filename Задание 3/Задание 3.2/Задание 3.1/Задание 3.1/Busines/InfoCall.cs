using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Busines
{
    public class InfoCall
    {
       public void GetInfo()
       {
            Sorting sorting = new Sorting();
            RepotCall reportCall = new RepotCall();
            DataBase dataBase = new DataBase();
            Console.WriteLine("1- Детализированный отчет по звонкам 2-Сортирвка");
            var read = Console.ReadLine();
            switch (read)
            {
                case "1":
                    reportCall.RepotCalls();
                    // dataBase.ConStr();
                    break;
                case "2":
                    sorting.Date();
                    break;
                default:
                    Console.WriteLine("Ошибка в заполнении");
                    break;
            }
        }
    }
}
