using DAL.Clases_Abstractas;
using Entity;
using Entity.Utilidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Entity.Utilidades.RespuestaAutenticacion;

namespace DAL
{
    public class AdministradorRepository : AbstractLecturaRepository<Administrador>
    {
        public AdministradorRepository()
            : base(new ApiClient("https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Administradores", TokenManager.Instance._token, TokenManager.Instance._refresh), "https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Administradores")
        {
        }

        public async Task<Token> Autenticar(Administrador administrador)
        {
            string endpoint = $"{baseURI}/Authentication";

            using (HttpClient client = new HttpClient())
            {
                string jsonBody = JsonConvert.SerializeObject(administrador);
                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    var responseObject = JsonConvert.DeserializeObject<RespuestaAutenticacion>(jsonResponse);

                    Token token = responseObject?.Response?.Token;
                    return token;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
