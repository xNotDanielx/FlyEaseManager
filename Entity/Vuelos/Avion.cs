using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Avion
    {
        public string IdAvion { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public double VelocidadPromedio { get; set; }
        public int CantidadPasajeros { get; set; }
        public double CantidadCarga { get; set; }
        public Aereolinea Aereolinea { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Avion()
        {
        }
    }
}
