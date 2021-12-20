using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Задание_3.Data_Access;
using System.Text.RegularExpressions;

namespace Задание_3.Busines
{
    class Registration:DataBase
    {
        
        public void AddUsers()
        {
            Console.WriteLine("Введите ФИО");
            var name = Console.ReadLine();
            Console.WriteLine("Введите Дату рождения");
            var DateOfBirth = Console.ReadLine();
            if (Data().Contains(name) && (Data().Contains(DateOfBirth)))
            {
                Console.WriteLine("Пользователь с такими данными уже есть");
            }
            else
            {
                StreamWriter sw = new StreamWriter("DataUsers.txt",true);
                int random=0;
                var telCode = "+375";
                int[] arr = new int[2] { 29, 33 };
                Random ran = new Random();
                var code = telCode+arr[new Random().Next(0, arr.Length)];
                Console.Write($"Спасибо за регистрацию {name}\nВаш номер телефона: { code}");
                sw.Write($"\n{name}\t{DateOfBirth}\t{code}");
                for (int i = 0; i < 7; i++)
                {
                        random = ran.Next(0, 9);
                        Console.Write(random);
                        sw.Write($"{random}");
                }              
                sw.Close();
            }
        }
    }
}
