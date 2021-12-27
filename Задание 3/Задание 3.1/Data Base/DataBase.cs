using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Задание_3._1.Data_Base
{
   public class DataBase
   {
       public SqlConnection sqlConnection = new SqlConnection(); 
       
       public void ConStr()
       {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                Console.WriteLine("Подключено"); 
            }
       }
       public void GetDataBase()
       {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            using (var sqlCommand = new SqlCommand($"Select * From Data", sqlConnection))
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {  
                    Console.WriteLine($"{reader[1]} {reader[2]}\t {reader[3]}\t {reader[4]}\t {reader[5]}");
                }
                sqlConnection.Close();
            }
        }
   }
}
