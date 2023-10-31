using Entity.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ILecturaRepository<T> where T : class
    {
        List<T> ObtenerTodos();
        T ObtenerPorId(string id);
    }
}
