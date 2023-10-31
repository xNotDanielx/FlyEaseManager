using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Utilidades
{
    public class ResponseList<T> where T : class
    {
        public string Mensaje { get; set; }
        public bool Succes { get; set; }
        public List<T> response { get; set; }
   
        public ResponseList()
        { 
        }

    }
}
