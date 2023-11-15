using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Utilidades
{
    public class ResponseAdmin
    {
            public string Mensaje { get; set; }
            public Administrador response { get; set; }

            public ResponseAdmin()
            {
            }
    }
}
