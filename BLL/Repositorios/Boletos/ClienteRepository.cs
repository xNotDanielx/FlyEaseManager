using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DAL.Clases_Abstractas;
using DAL.Interfaces;
using Entity;
using Entity.Utilidades;
using Newtonsoft.Json;

namespace DAL.Repositorios
{
    public class ClienteRepository : AbstractCRUDRepository<Cliente>
    {
        public ClienteRepository()
            : base(new ApiClient("http://flyeaseapi-dev-env.eba-sbxyzdge.us-east-2.elasticbeanstalk.com/FlyEaseApi/Clientes", TokenManager.Instance._token, TokenManager.Instance._refresh), "http://flyeaseapi-dev-env.eba-sbxyzdge.us-east-2.elasticbeanstalk.com/FlyEaseApi/Clientes")
        {
        }
    }
}
