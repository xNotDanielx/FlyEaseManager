using DAL.Clases_Abstractas;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class AereolineaRepository : AbstractCRUDRepository<Aereolinea>
    {
        public AereolineaRepository()
            : base(new ApiClient("http://www.flyease.somee.com/FlyEaseApi/Aereolineas"), "http://www.flyease.somee.com/FlyEaseApi/Aereolineas")
        {
        }
    }
}
