using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Busines
{
   public class ActionProvider:IActionProvider
   {      
        CollectionPhone phone = new CollectionPhone();
        DataBase dataBase = new DataBase();
        public SqlConnection sqlConnection = new SqlConnection();
        public void Block()
        {
            Console.Write("Номер телефона:  ");
            var number= Console.ReadLine();
            foreach (var line in File.ReadAllLines(@"DataUsers.txt"))
            {
                if (line.Contains(number))
                {
                    int lenght = line.Length-1;
                    StreamWriter sw = new StreamWriter("BlackList.txt", true);
                    sw.WriteLine(line);
                    sw.Close();                 
                }
            }
        }
        public void ListCall()
        {
            dataBase.GetDataBase();
        }
        public void Search()
        {
            Console.WriteLine("Имя пользователя");
            var data = Console.ReadLine();
            phone.GetNumberPhone(data);
        }
   }
}
