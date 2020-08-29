using System.Data;
using MySql.Data.MySqlClient;
using ElGalpon.Base.Cache;
using ElGalpon.Models;

namespace ElGalpon.Repository
{
    public class UserRepository : ConnectionToMySql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from users where (loginName=@user and password=@pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        {
                            UserCache.IdUser = reader.GetInt32(0);
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public UserModel LoginUser(string user, string pass)
        {
            UserModel usuario = new UserModel();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from users where (loginName=@user and password=@pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        {
                            usuario.IdUser = reader.GetInt32(0);
                            usuario.LoginName = reader.GetString(1);
                            usuario.Password = reader.GetString(2);
                        }
                        return usuario;
                    }
                    else
                        return null;
                }
            }
        }
    }
}
