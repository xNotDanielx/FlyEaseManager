using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Aereopuerto
    {
        public int IdAereopuerto { get; set; }
        public string Nombre { get; set; }
        public Coordenadas Coordenadas { get; set; }
        public Ciudad Ciudad { get; set; }
        public string FechaRegistro { get; set; }

        public Aereopuerto()
        {
        }
    }
}
