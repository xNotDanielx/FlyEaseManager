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
        public DateTime FechaYHoraLlegada { get; set; }
        public bool Cupo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaYHoraDeSalida { get; set; }
        public Avion Avion { get; set; }
        public Aereopuerto aeropuerto_Despegue { get; set; }
        public Aereopuerto aeropuerto_Destino { get; set; }
        public Estado Estado { get; set; }
        
        public Vuelo()
        {
        }

        public string CupoToString()
        {
            if (this.Cupo)
            {
                return "Hay cupo";
            }
            else
            {
                return "Lleno";
            }
        }
    }
}
