using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICRUDService<T> : ILecturaService<T> where T : class
    {
        Task<string> Crear(T entity);
        Task<string> Actualizar(T entity);
        Task<string> Eliminar();
    }
}
