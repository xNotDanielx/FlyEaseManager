using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Asiento
    {
        public int IdAsiento { get; set; }
        public int Posicion { get; set; }
        public bool Disponibilidad { get; set; }
        public Categoria Categoria { get; set; }
        public Avion Avion { get; set; }
        public string FechaRegistro { get; set; }

        public Asiento()
        {
        }
    }
}
