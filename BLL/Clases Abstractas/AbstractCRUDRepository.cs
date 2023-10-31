using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Clases_Abstractas
{
    public abstract class AbstractCRUDRepository<T> : AbstractLecturaRepository<T>, ICRUDRepository<T> where T : class
    {

        public AbstractCRUDRepository(IServiceClient apiClient, string baseURI)
            : base(apiClient, baseURI)
        {
        }

        public virtual async Task<string> Crear(T entity)
        {
            string endpoint = $"{this.baseURI}/Post";
            return await this.apiClient.PostAsync(endpoint, entity);
        }
        
        public virtual async Task<string> Actualizar(string id, T entity)
        {
            string endpoint = $"{this.baseURI}/Put/{id}";
            return await apiClient.PutAsync(endpoint, entity);
        }

        public virtual async Task<string> EliminarTodos()
        {
            string endpoint = $"{this.baseURI}/DeleteAll";
            return await this.apiClient.DeleteAsync(endpoint);
        }

        public virtual async Task<string> EliminarPorId(string id)
        {
            string endpoint = $"{this.baseURI}/Delete/{id}";
            return await this.apiClient.DeleteAsync(endpoint);
        }
    }
}
