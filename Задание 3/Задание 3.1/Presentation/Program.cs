using System;
using Задание_3._1.Busines;
using Задание_3._1.Data_Base;
using Задание_3._1.Временная;

namespace Задание_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSubscriber = " ";
            OnCalling calling = new OnCalling(nameSubscriber);
            Provider provider = new Provider();
            PriceCall priceCall = new PriceCall();
            InfoCall infoCall = new InfoCall();
            CollectionPhone cp = new CollectionPhone();
            Registration registration = new Registration();
            Path path = new Path();         
            Console.WriteLine("1-Регистрация 3-Отчет по звонкам 4- Вызов");
            while (true)
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
                        nameSubscriber = Console.ReadLine();
                        calling.Notify += Station.DisplayMessage;
                        calling.Take(cp.GetNumberPhone(nameSubscriber));
                        Console.Read();
                        break;
                    case "qa1234":
                        provider.GetProvider();
                        break;
                }
            }                
        }
    }
}
