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
   }
}
