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

namespace DAL
{
    public class AdministradorRepository : AbstractLecturaRepository<Administrador>
    {
        public AdministradorRepository()
            : base(new ApiClient("https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Administradores", TokenManager.Instance._token), "https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Administradores")
        {
        }

        public async Task<string> Autenticar(Administrador administrador)
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

                    string token = responseObject?.Response?.Token?.TokenString;
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
