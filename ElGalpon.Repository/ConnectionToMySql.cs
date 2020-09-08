using System;
using MySql.Data.MySqlClient;

namespace ElGalpon.Repository
{
    public abstract class ConnectionToMySql
    {
        private readonly string connectionString;
        public ConnectionToMySql()
        {
            connectionString = "Server=localhost; Database=elgalpon; User=mayco; port=3306; password=mayco1234;";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
