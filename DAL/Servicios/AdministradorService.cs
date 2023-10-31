using DAL.Clases_Abstractas;
using DAL.Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servicios
{
    public class AdministradorService : AbstractLecturaService<Administrador>
    {
        public AdministradorService()
            : base(new AdministradorRepository())
        {
        }
    }
}
