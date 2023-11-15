using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoCategoria { get; set; }
        public double Tarifa { get; set; }
        public bool Comercial { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Categoria()
        {
        }
    }
}
