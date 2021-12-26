using System;
using Задание_3._1.Busines;
using Задание_3._1.Data_Base;

namespace Задание_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceCall priceCall = new PriceCall();
            InfoCall infoCall = new InfoCall();
            Call call = new Call("12345");
            CollectionPhone cp = new CollectionPhone();
            Registration registration = new Registration();
            Path path = new Path();         
            Console.WriteLine("1-Регистрация  3-Отчет по звонкам 4- Вызов");
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
                            cp.GetNumberPhone(name);
                        }
                    }
                    break;
                case "3":
                    infoCall.GetInfo();
                    break;
                case "4":
                    Console.WriteLine("Выбор контакта");
                    var nameSubscriber = Console.ReadLine();
                    call.Notify += DisplayMessage;
                    call.Take(cp.GetNumberPhone(nameSubscriber));
                    Console.Read();
                    break;
            }               
        }
        private static void DisplayMessage(object sender, AccountEventArgs args)
        {
            Console.WriteLine($"Вызов:{args.Number}");
            Console.WriteLine(args.Message);
        }
    }
}
