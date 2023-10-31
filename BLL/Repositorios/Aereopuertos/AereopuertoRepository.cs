using DAL.Clases_Abstractas;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class AereopuertoRepository : AbstractCRUDRepository<Aereopuerto>
    {
        public AereopuertoRepository()
            : base(new ApiClient("http://www.flyease.somee.com/FlyEaseApi/Aereopuertos"), "http://www.flyease.somee.com/FlyEaseApi/Aereopuertos")
        {
        }
    }
}
