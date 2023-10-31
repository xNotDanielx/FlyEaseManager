using DAL.Clases_Abstractas;
using Entity;
using Entity.Utilidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdministradorRepository : AbstractLecturaRepository<Administrador>
    {
        public AdministradorRepository()
            : base(new ApiClient("http://www.flyease.somee.com/FlyEaseApi/Administradores"), "http://www.flyease.somee.com/FlyEaseApi/Administradores")
        {
        }

        public Administrador ObtenerPorNDocumento(string numeroDocumento)
        {
            
            string endpoint = $"{this.baseURI}/GetByDocument/{numeroDocumento}";
            string jsonResponse = this.apiClient.GetAsync(endpoint).Result;
            var administrador = JsonConvert.DeserializeObject<Administrador>(jsonResponse);
            return administrador;
        }
    }
}
