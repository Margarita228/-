﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СалонКрасоты
{
    internal class db
    {
        public static string[] userInfo = new string[] { "-1", "test" };

        public static SqlConnection connection = new SqlConnection(@"Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True");

        // Запрос к БД и возврат результирующей таблицы
        public static List<string[]> Select(string request)
        {
            connection.Open();

            var command = new SqlCommand(String.Format(request), connection);
            var tempList = new List<string>(); // Запись из БД
            var result = new List<string[]>(); // Результат запроса к БД

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempList.Clear();
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            tempList.Add(Convert.ToString(reader.GetValue(i)));
                        }
                        var tempArray = new string[tempList.Count];
                        tempList.CopyTo(tempArray);
                        result.Add(tempArray);
                    }
                }
            }
            connection.Close();
            return result;
        }
    }
}
