using System.IO;
using System;

namespace Задание_3._1.Data_Base
{
    class Registration: CollectionPhone
    {
        public void AddUsers()
        {
            AddPhone addPhone = new AddPhone();
            string name = " ";
            DateTime DateOfBirth = new DateTime();
            try
            {
                Console.WriteLine("Введите ФИО");
                name = Console.ReadLine();
                Console.WriteLine("Введите Дату рождения");
                DateOfBirth = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в заполнении");
                Console.ReadLine();
            }
            if (GetData().Contains(name) && (GetData().Contains(DateOfBirth.ToString())))
            {
                Console.WriteLine("Пользователь с такими данными уже есть");
            }
            else
            {            
               addPhone.GetPhone(name,DateOfBirth);
            }
        }
    }
}
