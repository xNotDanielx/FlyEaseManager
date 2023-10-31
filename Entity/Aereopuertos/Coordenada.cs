using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Coordenada
    {
        public int IdCoordenada { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string FechaRegistro { get; set; }

        public Coordenada()
        {
        }
    }
}
