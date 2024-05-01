using System;
using Microsoft.Data.SqlClient;

namespace AspNetCoreApp.Services
{
    public static class DBManagerService
    {
        public static void ExecuteTopTenQuery()
        {
            string connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;Integrated Security=True";
            string query = "SELECT TOP 10 * FROM YourTable";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0].ToString()); // Adjust the index to match the column you're interested in
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}