using System;
using Задание_3._1.Busines;
using Задание_3._1.Data_Base;

namespace Задание_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoCall infoCall = new InfoCall();
            CollectionPhone cp = new CollectionPhone();
            Registration registration = new Registration();
            Path path = new Path();         
            Console.WriteLine("1-Регистрация 2-Проверка на работу 3-Отчет по звонкам ");
            var number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    registration.AddUsers();
                    break;
                case "2":
                    Console.Write("Введите ФИО:  ");
                    string name = Console.ReadLine();
                    foreach (var item in path.path)
                    {
                        if (cp.GetData().Contains(name))
                        {
                            //cp.GetNumberPhone(name);
                            cp.GetNumberPhone(name);
                        }
                    }
                    break;
                case "3":
                    infoCall.GetInfo();
                    break;
            }         
        }
    }
}
