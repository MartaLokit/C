using System;
using Задание_3._1.Busines;
using Задание_3._1.Data_Base;

namespace Задание_3._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Provider provider = new Provider();
            PriceCall priceCall = new PriceCall();
            InfoCall infoCall = new InfoCall();
            PortSubscriber portSubscriber = new PortSubscriber("12345");
            PortCompanion portCompanion = new PortCompanion("12345");
            CollectionPhone cp = new CollectionPhone();
            Registration registration = new Registration();
            Path path = new Path();         
<<<<<<< HEAD
            Console.WriteLine("1-Регистрация 3-Отчет по звонкам 4- Вызов");
            while (true)
=======
            Console.WriteLine("1-Регистрация  3-Отчет по звонкам 4- Вызов");
            var number = Console.ReadLine();
            switch (number)
>>>>>>> d345db77acd860550de3e6c194646e702bbf6792
            {
                var number = Console.ReadLine();
                switch (number)
                {
                    case "01":
                        cp.GetNumberPhone("Орлов Киррил Егорович");
                        break;
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
                        portSubscriber.Notify += DisplayMessage;
                        portSubscriber.Take(cp.GetNumberPhone(nameSubscriber));
                        Console.WriteLine("Статус собеседника");
                        portCompanion.Notify += DisplayMessage;
                        portCompanion.Take(cp.GetNumberPhone(nameSubscriber), nameSubscriber);
                        Console.Read();
                        break;
                    case "qa1234":
                        provider.GetProvider();
                        break;
                }
            }         
        }
        private static void DisplayMessage(object sender, AccountEventArgs args)
        {
            Console.WriteLine($"Вызов:{args.NameSubscriber}");
            Console.WriteLine(args.Message);
        }
    }
}
