using DAL.Clases_Abstractas;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class CiudadRepository : AbstractCRUDRepository<Ciudad>
    {
        public CiudadRepository()
            : base(new ApiClient("http://www.flyease.somee.com/FlyEaseApi/Ciudades"), "http://www.flyease.somee.com/FlyEaseApi/Ciudades")
        {
        }
    }
}
