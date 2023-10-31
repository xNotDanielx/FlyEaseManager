using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Utilidades
{
    public class ResponseObject<T> where T : class
    {
        public string Mensaje { get; set; }
        public bool Succes { get; set; }
        public T response { get; set; }

        public ResponseObject()
        {
        }

    }
}
