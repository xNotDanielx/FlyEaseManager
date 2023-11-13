using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Utilidades
{
    public class RespuestaAutenticacion
    {
        [JsonProperty("response")]
        public Respuesta Response { get; set; }

        public class Respuesta
        {
            [JsonProperty("tokens")]
            public Token Token { get; set; }

            [JsonProperty("succes")]
            public bool Success { get; set; }

            [JsonProperty("msg")]
            public string Mensaje { get; set; }
        }

        public class Token
        {
            [JsonProperty("Primarytoken")]
            public string TokenString { get; set; }

            [JsonProperty("refreshToken")]
            public string RefreshToken { get; set; }

            [JsonProperty("adminAuthentication")]
            public bool AdminAuthentication { get; set; }
        }
    }
}
