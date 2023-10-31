using BLL.Clases_Abstractas;
using DAL.Repositorios;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class CategoriaService : AbstractCRUDService<Categoria>
    {
        public CategoriaService()
            : base(new CategoriaRepository())
        {
        }
    }
}
