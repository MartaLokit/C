using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Busines;

namespace Задание_3._1.Data_Base
{
    public class AddPhone: EventReg
    {
        public bool GetPhone(string name, DateTime DateOfBirth)
        {
            StreamWriter sw = new StreamWriter("DataUsers.txt", true);
            int random = 0;
            var telCode = "+375";
            int[] arr = new int[2] { 29, 33 };
            Random ran = new Random();
            var code = telCode + arr[new Random().Next(0, arr.Length)];
            Console.Write($"Спасибо за регистрацию {name}\nВаш номер телефона: { code}");
            sw.Write($"\n{name}\t{DateOfBirth}\t{code}");
            for (int i = 0; i < 7; i++)
            {
                random = ran.Next(0, 9);
                Console.Write(random);
                sw.Write($"{random}");
            }
            sw.Close();
            return false;
        }
    }
}
