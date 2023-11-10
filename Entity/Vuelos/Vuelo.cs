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
        public string FechaYHoraLlegada { get; set; }
        public bool Cupo { get; set; }
        public string FechaRegistro { get; set; }
        public string FechaYHoraDeSalida { get; set; }
        public Aereopuerto aereopuerto_Despegue { get; set; }
        public Aereopuerto aereopuerto_Destino { get; set; }
        public Estado Estado { get; set; }
        public Avion Avion { get; set; }
        

        public Vuelo()
        {
        }
    }
}
