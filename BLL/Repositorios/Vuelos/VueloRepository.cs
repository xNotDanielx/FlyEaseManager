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
    public class VueloRepository : AbstractCRUDRepository<Vuelo>
    {
        public VueloRepository()
            : base(new ApiClient("https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Vuelos", TokenManager.Instance._token, TokenManager.Instance._refresh), "https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Vuelos")
        {
        }
    }
}
