using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Detencion { get; set; }
        public string FechaRegistro { get; set; }

        public Estado()
        {
        }
    }
}
