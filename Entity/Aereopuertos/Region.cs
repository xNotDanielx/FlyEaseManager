using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Region
    {
        public int IdRegion { get; set; }
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Region()
        {
        }
    }
}
