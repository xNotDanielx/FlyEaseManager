using DAL.Interfaces;
using Entity.Utilidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Clases_Abstractas
{
    public abstract class AbstractLecturaRepository<T> : ILecturaRepository<T> where T : class
    {
        protected readonly IServiceClient apiClient;
        protected readonly string baseURI;

        public AbstractLecturaRepository(IServiceClient apiClient, string baseURI)
        {
            this.apiClient = apiClient;
            this.baseURI = baseURI; 
        }

        public virtual async Task<List<T>> ObtenerTodos()
        {
            string endpoint = $"{baseURI}/GetAll";
            string jsonResponse = await apiClient.GetAsync(endpoint);
            var response = JsonConvert.DeserializeObject<ResponseList<T>>(jsonResponse);
            return response.response;
        }
        public virtual async Task<T> ObtenerPorId(string id)
        {
            string endpoint = $"{baseURI}/GetById/{id}";
            string jsonResponse = await apiClient.GetAsync(endpoint);
            var response = JsonConvert.DeserializeObject<ResponseObject<T>>(jsonResponse);
            return response.response;
        }
    }
}
