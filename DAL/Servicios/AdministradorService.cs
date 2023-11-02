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
        private readonly AdministradorRepository administradorRepository = new AdministradorRepository();

        public AdministradorService()
            : base(new AdministradorRepository())
        {
        }

        public Administrador ObtenerPorNDocumento(string numeroDocumento)
        {
            var administrador = administradorRepository.ObtenerPorNDocumento(numeroDocumento);
            return administrador;
        }

        public Administrador AutenticarAdministrador(string usuario, string clave)
        {
            List<Administrador> administradores = administradorRepository.ObtenerTodos();
            Administrador administrador = administradores.Where(item => item.Usuario.Equals(usuario) && item.Clave.Equals(clave)).FirstOrDefault();
            return administrador;
        }
    }
}
