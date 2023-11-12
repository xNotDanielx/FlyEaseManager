using DAL.Clases_Abstractas;
using Entity;
using Entity.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class EstadoRepository : AbstractCRUDRepository<Estado>
    {
        public EstadoRepository()
            : base(new ApiClient("http://www.flyease.somee.com/FlyEaseApi/Estados", TokenManager.Instance._token), "http://www.flyease.somee.com/FlyEaseApi/Estados")
        {
        }
    }
}
