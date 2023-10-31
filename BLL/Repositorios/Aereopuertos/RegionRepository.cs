using DAL.Clases_Abstractas;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class RegionRepository : AbstractCRUDRepository<Region>
    {
        public RegionRepository()
            : base(new ApiClient("http://www.flyease.somee.com/FlyEaseApi/Regiones"), "http://www.flyease.somee.com/FlyEaseApi/Regiones")
        {
        }
    }
}
