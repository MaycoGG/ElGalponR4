using System.Data;
using MySql.Data.MySqlClient;
using ElGalpon.Base.Cache;
using ElGalpon.Models;
using System.Collections.Generic;
using System;

namespace ElGalpon.Repository
{
    public class ReservasRepository : ConnectionToMySql
    {
        public List<ReservaModel> SelectAllReservas()
        {
            DataSet ds = null;
            List<ReservaModel> reservas = new List<ReservaModel>();
            using (var connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("sp_reserva_get_all", connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
                ds = new DataSet();
                adaptador.Fill(ds);

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    ReservaModel reserva = new ReservaModel();
                    reserva.Id = int.Parse(item["id"].ToString());
                    reserva.Fecha = DateTime.Parse(item["fecha"].ToString());
                    reserva.HoraDesde = item["horaDesde"].ToString();
                    reserva.HoraHasta = item["horaHasta"].ToString();
                    reserva.IdMesa = int.Parse(item["idMesa"].ToString());
                    reserva.Nombre = item["nombre"].ToString();
                    reserva.Apellido = item["apellido"].ToString();
                    reserva.CantidadPersonas = int.Parse(item["cantidadPersonas"].ToString());
                    reserva.Observaciones = item["observaciones"].ToString();
                    reserva.Estado = item["descripcion"].ToString();
                    reservas.Add(reserva);
                }
            }
            return reservas;
        }

        public List<ReservaModel> SelectReservasByFecha(DateTime fecha)
        {
            DataSet ds = null;
            List<ReservaModel> reservas = new List<ReservaModel>();
            using (var connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("sp_reserva_get_by_fecha", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_fecha", fecha));
                MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
                ds = new DataSet();
                adaptador.Fill(ds);

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    ReservaModel reserva = new ReservaModel();
                    reserva.Id = int.Parse(item["id"].ToString());
                    reserva.Fecha = DateTime.Parse(item["fecha"].ToString());
                    reserva.HoraDesde = item["horaDesde"].ToString();
                    reserva.HoraHasta = item["horaHasta"].ToString();
                    reserva.IdMesa = int.Parse(item["idMesa"].ToString());
                    reserva.Nombre = item["nombre"].ToString();
                    reserva.Apellido = item["apellido"].ToString();
                    reserva.CantidadPersonas = int.Parse(item["cantidadPersonas"].ToString());
                    reserva.Observaciones = item["observaciones"].ToString();
                    reserva.Estado = item["descripcion"].ToString();
                    reservas.Add(reserva);
                }
            }
            return reservas;
        }
    }
}
