using DataAccess.Properties;
using MySql.Data.MySqlClient;
using System;


namespace DataLibrary
{
    public class DatabaseHelper
    {
        public static MySqlConnection DatabaseConnection()
        {
            var port = Settings.Default.Port;
            var server = Settings.Default.Server;  
            var username = Settings.Default.Username;
            var password = Settings.Default.Password;
            var databaseName = Settings.Default.Database;

            string connectionString = $"server={server}; user={username}; password={password}; database={databaseName}; port={port};";
            try
            {

                var connection = new MysqlConnection(connectionString);
                connection.Open();
               
                return connection;

            }catch (Exception)
            {
                return null;
            }
            
        }

        
    }
}
