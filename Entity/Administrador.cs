using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Administrador : Persona
    {
        public bool Estado { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string FechaRegistro { get; set; }

        public Administrador()
        {
        }
    }
}
