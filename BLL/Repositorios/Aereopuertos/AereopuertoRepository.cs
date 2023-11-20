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
    public class AereopuertoRepository : AbstractCRUDRepository<Aereopuerto>
    {
        public AereopuertoRepository()
            : base(new ApiClient("https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Aeropuertos", TokenManager.Instance._token, TokenManager.Instance._refresh), "https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Aeropuertos")
        {
        }
    }
}
