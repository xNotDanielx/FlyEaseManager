using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vuelo
    {
        public int IdVuelo { get; set; }
        public double PrecioVuelo { get; set; }
        public double TarifaTemporada { get; set; }
        public double Descuento { get; set; }
        public double DistanciaRecorrida { get; set; }
        public string FechaYHoraDespegue { get; set; }
        public string FechaYHoraLlegada { get; set; }
        public bool Cupo { get; set; }
        public Aereopuerto ADespegue { get; set; }
        public Aereopuerto ADestino { get; set; }
        public Estado Estado { get; set; }
        public Avion Avion { get; set; }
        public string FechaRegistro { get; set; }

        public Vuelo()
        {
        }
    }
}
