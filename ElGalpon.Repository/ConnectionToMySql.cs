using System;
using MySql.Data.MySqlClient;

namespace ElGalpon.Repository
{
    public abstract class ConnectionToMySql
    {
        private readonly string connectionString;
        public ConnectionToMySql()
        {
            connectionString = "Server=localhost; Database=MyCompany; User=root; port=3306; password=;";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
