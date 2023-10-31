using DAL.Interfaces;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Clases_Abstractas;

namespace BLL.Clases_Abstractas
{
    public abstract class AbstractCRUDService<T> : AbstractLecturaService<T>, ICRUDService<T> where T : class
    {
        protected readonly ICRUDRepository<T> crudRepository;

        public AbstractCRUDService(ICRUDRepository<T> crudRepository)
            : base(crudRepository)
        {
            this.crudRepository = crudRepository;
        }

        public virtual async Task<string> Crear(T entity)
        {
            try
            {
                return await crudRepository.Crear(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public virtual async Task<string> Actualizar(string id, T entity)
        {
            try
            {
                return await crudRepository.Actualizar(id, entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public virtual async Task<string> EliminarTodos()
        {
            try
            {
                return await crudRepository.EliminarTodos();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public virtual async Task<string> EliminarPorId(string id)
        {
            try
            {
                return await crudRepository.EliminarPorId(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
