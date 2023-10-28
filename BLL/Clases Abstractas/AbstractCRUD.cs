using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Clases_Abstractas
{
    public abstract class AbstractCRUD<T> : AbstractLectura<T>, ICRUD<T> where T : class
    {
        private readonly ApiClient apiClient;
        private readonly string URIbase;

        public AbstractCRUD(ApiClient apiClient, string URIbase)
            : base(apiClient, URIbase)
        {
            
            this.apiClient = new ApiClient(URIbase);
            this.URIbase = URIbase;
        }

        public virtual async Task<string> Crear(T entity)
        {
            string endpoint = URIbase + "/crear";
            return await apiClient.PostAsync(endpoint, entity);
        }

        public virtual async Task<string> Actualizar(T entity)
        {
            string endpoint = URIbase + "/actualizar";
            return await apiClient.PutAsync(endpoint, entity);
        }

        public virtual async Task<string> Eliminar()
        {
            string endpoint = URIbase + "/eliminar";
            return await apiClient.DeleteAsync(endpoint);
        }
    }
}
