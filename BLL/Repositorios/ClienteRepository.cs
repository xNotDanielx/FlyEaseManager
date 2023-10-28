using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BLL.Clases_Abstractas;
using Entity;
using Newtonsoft.Json;

namespace BLL
{
    public class ClienteRepository : AbstractCRUD<Cliente>
    {
        public ClienteRepository(ApiClient apiClient)
            : base(apiClient, "URI base ejemplo clientes")
        {
        }
    }
}
