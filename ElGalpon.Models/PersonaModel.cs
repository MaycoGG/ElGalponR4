using System;
using System.Collections.Generic;
using System.Text;

namespace ElGalpon.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Celular { get; set; }
        public int IdTipoPersona { get; set; }
        public string Denominacion { get { return this.Nombre + " " + this.Apellido; } }
    }
}
