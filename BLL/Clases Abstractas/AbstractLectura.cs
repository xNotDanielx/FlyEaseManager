using BLL.Interfaces;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Clases_Abstractas
{
    public abstract class AbstractLectura<T> : ILectura<T> where T : class
    {
        private readonly ApiClient apiClient;
        private readonly string URIbase;

        public AbstractLectura(ApiClient apiClient, string URIbase)
        {
            
            this.apiClient = new ApiClient(URIbase);
            this.URIbase = URIbase; 
        }

        public virtual async Task<List<T>> ObtenerTodos()
        {
            string jsonResponse = await apiClient.GetAsync(URIbase);
            List<T> items = JsonConvert.DeserializeObject<List<T>>(jsonResponse);
            return items;
        }
    }
}
