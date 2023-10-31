using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Boleto
    {
        public int IdBoleto { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }
        public double PrecioTotal { get; set; }
        public Cliente Cliente { get; set; }
        public Asiento Asiento { get; set; }
        public Vuelo Vuelo { get; set; }
        public string FechaRegistro { get; set; }

        public Boleto()
        {
        }
    }
}
