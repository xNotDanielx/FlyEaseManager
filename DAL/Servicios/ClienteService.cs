﻿using DAL.Clases_Abstractas;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servicios
{
    public class ClienteService : AbstractCRUDService<Cliente>
    {
        public ClienteService()
            : base(new ClienteRepository())
        {
        }
    }
}
