using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICRUDRepository<T> : ILecturaRepository<T> where T : class
    {
        Task<string> Crear(T entity);
        Task<string> Actualizar(string id, T entity);
        Task<string> EliminarPorId(string id);
        Task<string> EliminarTodos();
    }
}
