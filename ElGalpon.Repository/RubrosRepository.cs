using System.Data;
using MySql.Data.MySqlClient;
using ElGalpon.Base.Cache;
using ElGalpon.Models;
using System.Collections.Generic;

namespace ElGalpon.Repository
{
    public class RubrosRepository : ConnectionToMySql
    {
        public List<RubroModel> SelectAllRubrosMenu()
        {
            DataSet ds = null;
            List<RubroModel> rubros = new List<RubroModel>();
            using (var connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("get_rubros_menu", connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
                ds = new DataSet();
                adaptador.Fill(ds);

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    RubroModel rubro = new RubroModel();
                    rubro.Id = int.Parse(item["id"].ToString());
                    rubro.Descripcion = item["descripcion"].ToString();
                    rubros.Add(rubro);
                }
            }
            return rubros;
        }

        public List<RubroModel> SelectAllRubrosGastos()
        {
            DataSet ds = null;
            List<RubroModel> rubros = new List<RubroModel>();
            using (var connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("get_rubros_gastos", connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
                ds = new DataSet();
                adaptador.Fill(ds);

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    RubroModel rubro = new RubroModel();
                    rubro.Id = int.Parse(item["id"].ToString());
                    rubro.Descripcion = item["descripcion"].ToString();
                    rubros.Add(rubro);
                }
            }
            return rubros;
        }
    }
}
