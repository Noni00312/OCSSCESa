using MySql.Data.MySqlClient;
using OCSSCESa.Properties;
using System;

namespace OCSSCESa.Helper
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
            try
            {
                return new MySqlConnection($"server={server}; user={username}; password={password}; database={databaseName}; port={port};");
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
