using BLL.Clases_Abstractas;
using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class AdministradorService : AbstractLecturaService<Administrador>
    {
        public AdministradorService()
            : base(new AdministradorRepository())
        {
        }

        public Administrador ObtenerPorNDocumento(string numeroDocumento)
        {
            var administrador = this.lecturaRepository.ObtenerPorId(numeroDocumento);
            return administrador;
        }
    }
}
