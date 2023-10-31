using DAL.Clases_Abstractas;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class VueloRepository : AbstractCRUDRepository<Vuelo>
    {
        public VueloRepository()
            : base(new ApiClient("http://www.flyease.somee.com/FlyEaseApi/Vuelos"), "http://www.flyease.somee.com/FlyEaseApi/Vuelos")
        {
        }
    }
}
