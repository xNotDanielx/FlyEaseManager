using DAL.Interfaces;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Clases_Abstractas
{
    public abstract class AbstractLecturaService<T> : ILecturaService<T> where T : class
    {
        protected ILecturaRepository<T> lecturaRepository;

        public AbstractLecturaService(ILecturaRepository<T> lecturaRepository)
        {
            this.lecturaRepository = lecturaRepository;
        }

        public virtual async Task<List<T>> ObtenerTodos()
        {
            try
            {
                return await lecturaRepository.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los elementos.", ex); // Cambiar la excepcion
            }
        }

        public virtual async Task<T> ObtenerPorId(string id)
        {
            try
            {
                return await lecturaRepository.ObtenerPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el elemento.", ex); // Cambiar la excepcion
            }
        }

    }
}
