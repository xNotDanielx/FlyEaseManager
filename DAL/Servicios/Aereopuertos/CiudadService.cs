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
    public class CiudadService : AbstractCRUDService<Ciudad>
    {
        public CiudadService()
            : base(new CiudadRepository())
        {
        }
    }
}
