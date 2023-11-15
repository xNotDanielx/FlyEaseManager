using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Aereolinea
    {
        public int IdAereolinea { get; set; }
        public string Nombre { get; set; }
        public string CodigoIATA { get; set; }
        public string CodigoICAO { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Aereolinea()
        {
        }
    }
}
