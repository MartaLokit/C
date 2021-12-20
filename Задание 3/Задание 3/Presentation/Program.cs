using System;
using Задание_3.Busines;
using Задание_3.Data_Access;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tariffPlan = new TariffPlan();
            var registration = new Registration();
            Console.WriteLine("1- Регистрация 2- Информация о трафике");
            var number = Console.ReadLine();
            switch (number)
            {
                case "1":                  
                   registration.AddUsers();
                    break;
                case "2":
                    tariffPlan.GetInfo();
                    break;
            }
            /////////////////////////////
           

            

        }
    }
}
