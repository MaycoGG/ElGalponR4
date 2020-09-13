using System;
using System.Collections.Generic;
using System.Text;

namespace ElGalpon.Models
{
    public class ReservaModel
    {
        public int Id { get; set; }
        public DateTime Fecha{ get; set; }
        public string HoraDesde { get; set; }
        public string HoraHasta { get; set; }
        public int IdMesa { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CantidadPersonas { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public string Denominacion { get { return this.Nombre + " " + this.Apellido; } }
    }
}
