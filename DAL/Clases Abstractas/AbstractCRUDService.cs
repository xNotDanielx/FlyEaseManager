using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Clases_Abstractas
{
    public abstract class AbstractCRUDService<T> : AbstractLecturaService<T>, ICRUDService<T> where T : class
    {
        protected ICRUDRepository<T> _crudRepository;

        public AbstractCRUDService(ICRUDRepository<T> crudRepository)
            : base(crudRepository)
        {
            _crudRepository = crudRepository;
        }

        public virtual async Task<string> Crear(T entity)
        {
            try
            {
                return await _crudRepository.Crear(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public virtual async Task<string> Actualizar(T entity)
        {
            try
            {
                return await _crudRepository.Actualizar(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public virtual async Task<string> Eliminar()
        {
            try
            {
                return await _crudRepository.Eliminar();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
