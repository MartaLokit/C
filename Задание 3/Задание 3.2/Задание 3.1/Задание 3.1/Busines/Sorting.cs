using System;
using System.Data.SqlClient;
using System.Configuration;
namespace Задание_3._1.Busines
{
    public class Sorting
    {
        public void Date()
        {
            var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            Console.WriteLine("****Сортировка по дате***");
            using (var sqlCommand = new SqlCommand($"Select * From[Data] Order By  Date DESC", sqlConnection))
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Номер телефона  Продолжительность    Номер Собеседника  Дата");
                    Console.WriteLine($"{reader[1]}   {reader[2]}   {reader[3]}  {reader[5]}");
                }
                sqlConnection.Close();
            }
        }
    }
}
