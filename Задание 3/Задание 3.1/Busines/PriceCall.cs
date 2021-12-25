using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Задание_3._1.Data_Base;
namespace Задание_3._1.Busines
{
    public class PriceCall
    {
        public SqlConnection sqlConnection = new SqlConnection();
        public void Price()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            using (var sqlCommand = new SqlCommand($"Select Diration From Data where Date=(Select Max(Date)From Data)",sqlConnection))
            {               
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                   Console.WriteLine($"{reader[5]}");
                }
                sqlConnection.Close();
            }
        }
    }
}
