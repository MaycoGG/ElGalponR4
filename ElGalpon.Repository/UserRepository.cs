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
            UserModel usuario = null;
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("get_user_login_pass", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_login", user));
                command.Parameters.Add(new MySqlParameter("p_pass", pass));
                MySqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    usuario = new UserModel();
                    usuario.LoginName = (dr["LoginName"]).ToString();
                    usuario.Password = (dr["password"]).ToString();
                }
                dr.Close();
                command.Connection.Close();
                return usuario;

                //using (var command = new MySqlCommand())
                //{

                //    command.Connection = connection;
                //    //command.CommandText = "select * from users where (loginName=@user and password=@pass)";
                //    command.CommandText = "get_user_login_pass(@user, @pass)";
                //    command.Parameters.AddWithValue("@user", user);
                //    command.Parameters.AddWithValue("@user", pass);
                //    command.CommandType = CommandType.StoredProcedure;
                //    MySqlDataReader reader = command.ExecuteReader();
                //    if (reader.HasRows)
                //    {
                //        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                //        {
                //            //usuario.IdUser = reader.GetInt32(0);
                //            usuario.LoginName = reader.GetString(1);
                //            usuario.Password = reader.GetString(2);
                //        }
                //        return usuario;
                //    }
                //    else
                //        return null;
                //}
            }
        }

        public void ChangeUserPassword(string user, string pass)
        {
            DataTable protError = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("update_user_login_pass", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_login", user));
                command.Parameters.Add(new MySqlParameter("p_pass", pass));
                MySqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                command.Connection.Close();
            }
        }
    }
}
