using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Diagnostics;

namespace projectX
{
    public class DB
    {
        private static string connectionString = "Server=192.168.1.37;Port=3306;User=root;Password=1234;Database=test";


        async static public Task createDB()
        {
            //string connectionString = "Server=192.168.1.37;Port=3306;User=root;Password=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            await connection.OpenAsync();
            Debug.WriteLine("✅ Открыто соединение");
            string zapros = @"
                CREATE DATABASE IF NOT EXISTS test;

                USE test;

                CREATE TABLE IF NOT EXISTS users (
                id INT PRIMARY KEY AUTO_INCREMENT,
                username VARCHAR(32) NOT NULL UNIQUE,
                password VARCHAR(32) NOT NULL
            )
        ";
            await using (var cmd1 = new MySqlCommand(zapros, connection))
            await cmd1.ExecuteNonQueryAsync();

        }

        async static public Task<bool> login(string username, string password)
        {
            //string connectionString = "Server=192.168.1.37;Port=3306;User=root;Password=1234;Database=test";
            await using var connection = new MySqlConnection(connectionString);
            await connection.OpenAsync();

            String sql = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password;";

            await using var cmd = new MySqlCommand(sql, connection);

            // Безопасно передаем переменные в запрос
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            // ExecuteScalarAsync возвращает одно значение (результат COUNT)
            long count = Convert.ToInt64(await cmd.ExecuteScalarAsync());

            // Если count > 0, значит совпадение найдено
            return count > 0;


        }
        async static public Task<bool> registration(string username, string password)
        {
            //string connectionString = "Server=192.168.1.37;Port=3306;User=root;Password=1234;Database=test";
            await using var connection = new MySqlConnection(connectionString);
            await connection.OpenAsync();

            String sql = @"INSERT INTO users (username, password)
                            VALUES (@username, @password)";

            await using var cmd = new MySqlCommand(sql, connection);

            // Безопасно передаем переменные в запрос
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            int rowsAffected = await cmd.ExecuteNonQueryAsync();

            // Если изминилась хотя бы 1 строка — запись прошла успешно
            return rowsAffected > 0;



        }
    }
}

