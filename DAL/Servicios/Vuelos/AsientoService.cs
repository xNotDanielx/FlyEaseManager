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
    public class AsientoService : AbstractCRUDService<Asiento>
    {
        public AsientoService()
            : base(new AsientoRepository())
        {
        }
    }
}
