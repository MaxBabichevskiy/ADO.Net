using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Rozetka
{
    internal class Program
    {
        static async Task Main(string[] args)
        {


            //Create DB
            string connectionString = @"Data Source = KOMPUTER\; Initial Catalog = master; Trusted_Connection=True";
            string sqlExpression = "CREATE DATABASE Rozetka";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand();
                command.CommandText = "CREATE DATABASE Rozetka";
                command.Connection = connection;
                await command.ExecuteNonQueryAsync();
                Console.WriteLine("БД создана");
            }
            //Create Table
            connectionString = @"Data Source = KOMPUTER\; Initial Catalog = Rozetka; Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand();

                command.CommandText = "CREATE TABLE Users(Id INT PRIMARY KEY IDENTITY, " +
                                        "Name VARCHAR(50) NOT NULL, Email VARCHAR(50) NOT NULL, " +
                                        "Password VARCHAR(50) NOT NULL,Phone VARCHAR(20) NOT NULL," +
                                        "Address VARCHAR(100) NOT NULL)";
                command.Connection = connection;
                await command.ExecuteNonQueryAsync();
                Console.WriteLine("Таблица создана");
            }







            Console.ReadLine();












        }
    }
}
