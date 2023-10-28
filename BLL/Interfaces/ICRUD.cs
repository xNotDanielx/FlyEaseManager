using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICRUD<T> : ILectura<T> where T : class
    {
        Task<string> Crear(T entity);
        Task<string> Actualizar(T entity);
        Task<string> Eliminar();
    }
}
