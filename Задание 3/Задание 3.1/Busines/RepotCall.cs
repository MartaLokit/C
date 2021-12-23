using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Busines
{
   public  class RepotCall:DataBase
   {
        public SqlCommand sqlCommand = new SqlCommand();
        public void RepotCalls()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            using (sqlCommand = new SqlCommand($"Select * From[Data]", sqlConnection))
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Номер телефона  Продолжительность  Цена      Номер Собеседника  Дата");
                    Console.WriteLine($"{reader[1]}   {reader[2]}   {reader[3]}  {reader[4]}    {reader[5]}");
                }
                sqlConnection.Close();
            }
        }
   }
}
