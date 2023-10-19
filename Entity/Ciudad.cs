using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ciudad
    {
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public Region Region { get; set; }
        public string FechaRegistro { get; set; }

        public Ciudad()
        {
        }
    }
}
