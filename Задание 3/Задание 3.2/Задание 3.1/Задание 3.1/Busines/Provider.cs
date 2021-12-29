using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Busines
{
    public class Provider
    {
        public SqlConnection sqlConnection = new SqlConnection();       
        public void GetProvider()
        {
            ActionProvider action = new ActionProvider();
            Console.WriteLine("Введите имя");
            var SurName = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            var password = Console.ReadLine();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter(
               $"SELECT * FROM Provider Where Surname=N'{SurName}'AND Password=N'{password }'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                Console.WriteLine("Подтверждено!");
                var number = Console.ReadLine();
                switch (number)
                {
                    case "4851":
                        action.ListCall();
                        break;
                    case "9012":
                        action.Block();
                        break;
                    default:
                        Console.WriteLine("Не верный номер");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Не верный логин или пароль");
            };
           
        }

    }
}
