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
            string endpoint = $"{baseURI}/Post";
            return await apiClient.PostAsync(endpoint, entity);
        }
        
        public virtual async Task<string> Actualizar(string id, T entity)
        {
            string endpoint = $"{baseURI}/Put/{id}";
            return await apiClient.PutAsync(endpoint, entity);
        }

        public virtual async Task<string> EliminarTodos()
        {
            string endpoint = $"{baseURI}/DeleteAll";
            return await apiClient.DeleteAsync(endpoint);
        }

        public virtual async Task<string> EliminarPorId(string id)
        {
            string endpoint = $"{baseURI}/Delete/{id}";
            return await apiClient.DeleteAsync(endpoint);
        }
    }
}
