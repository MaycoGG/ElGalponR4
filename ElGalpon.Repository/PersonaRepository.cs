using System.Data;
using MySql.Data.MySqlClient;
using ElGalpon.Base.Cache;
using ElGalpon.Models;
using System.Collections;
using System.Collections.Generic;

namespace ElGalpon.Repository
{
    public class PersonaRepository : ConnectionToMySql
    {
        public List<PersonaModel> SelectAllMozos()
        {
            DataSet ds = null;
            List<PersonaModel> mozos = new List<PersonaModel>();
            using (var connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("get_usuario_por_tipo", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_tipo", 2));

                MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
                ds = new DataSet();
                adaptador.Fill(ds);

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    PersonaModel mozo = new PersonaModel();
                    mozo.Id = int.Parse(item["id"].ToString());
                    mozo.Nombre = item["nombre"].ToString();
                    mozo.Apellido = item["apellido"].ToString();
                    mozo.Celular = long.Parse(item["celular"].ToString());
                    mozo.IdTipoPersona = int.Parse(item["idTipoPersona"].ToString());
                    mozos.Add(mozo);
                }
            }
            return mozos;
        }

    }
}
