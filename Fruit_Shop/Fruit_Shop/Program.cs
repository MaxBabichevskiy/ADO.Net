using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Create DB
            //string connectionString = @"Data Source = KOMPUTER\; Initial Catalog = master; Trusted_Connection=True";
            //string sqlExpression = "CREATE DATABASE Products";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    await connection.OpenAsync();
            //    Console.WriteLine("Подключение открыто");
            //    SqlCommand command = new SqlCommand();
            //    command.CommandText = "CREATE DATABASE Products";
            //    command.Connection = connection;
            //    await command.ExecuteNonQueryAsync();
            //    command = new SqlCommand();
            //}

            //Create Table
            //string connectionString = @"Data Source = KOMPUTER\; Initial Catalog = Products; Trusted_Connection=True";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    await connection.OpenAsync();
            //    SqlCommand command = new SqlCommand();
            //    command.CommandText = "CREATE TABLE Products_List(Id INT PRIMARY KEY IDENTITY," +
            //                              "Product_Name NVARCHAR(30) NOT NULL, " +
            //                              "Count INT NOT NULL)";
            //    command.Connection = connection;
            //    await command.ExecuteNonQueryAsync();
            //    Console.WriteLine("Таблица создана");
            //}
            //Console.Read();

            //Filling Table
            //string connectionString = @"Data Source = KOMPUTER\; Initial Catalog = Products; Trusted_Connection=True";
            //string sqlExpression = "INSERT INTO Products_List(Product_Name, Count) VALUES('Apple' , 5),('Cucumber' , 2),('Nuts' , 20)," +
            //                      "('Potato' , 15),('Onion' , 4),('Oil' , 1)";
            //using (SqlConnection connection = new SqlConnection(connectionString)){
            //    await connection.OpenAsync();
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    int number = await command.ExecuteNonQueryAsync();
            //    Console.WriteLine($"Добавленно объектов:  {number}");              
            //}

            //Get values
            //string connectionString = @"Data Source = KOMPUTER\; Initial Catalog = Products; Trusted_Connection=True";
            //string sqlExpression = "SELECT * FROM Products_List";
            //using (SqlConnection connection = new SqlConnection(connectionString)){
            //    await connection.OpenAsync();
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    command.CommandText = "SELECT MIN(Count) FROM Products_List";
            //    object minCount = await command.ExecuteScalarAsync();
            //    command.CommandText = "SELECT MAX(Count) FROM Products_List";
            //    object maxCount = await command.ExecuteScalarAsync();
            //    command.CommandText = "SELECT AVG(Count) FROM Products_List";
            //    object avgProducts = await command.ExecuteScalarAsync();
            //    Console.WriteLine($"Min products:  {minCount} ");
            //    Console.WriteLine($"Max products:  {maxCount} ");
            //    Console.WriteLine($"Average products:  {avgProducts} ");
            //}
            //Console.WriteLine("Подключение закрыто...");
            //Console.WriteLine("Finish programm");
            //Console.Read();
        }
    }
}
