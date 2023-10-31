using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Clases_Abstractas
{
    public abstract class AbstractLecturaService<T> : ILecturaService<T> where T : class
    {
        protected ILecturaRepository<T> _lecturaRepository;

        public AbstractLecturaService(ILecturaRepository<T> lecturaRepository)
        {
            _lecturaRepository = lecturaRepository;
        }

        public virtual async Task<List<T>> ObtenerTodos()
        {
            try
            {
                return await _lecturaRepository.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los elementos.", ex); // Cambiar la excepcion
            }
        }


    }
}
