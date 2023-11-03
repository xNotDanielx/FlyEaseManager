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

        public Administrador ObtenerPorNDocumento(string numeroDocumento) // No se usará. Tiene posibles errores porque el método que está dentro es asíncrono
        {
            var administrador = administradorRepository.ObtenerPorNDocumento(numeroDocumento);
            return administrador;
        }

        public async Task<Administrador> AutenticarAdministrador(string usuario, string clave)
        {
            List<Administrador> administradores = await administradorRepository.ObtenerTodos();
            Administrador administrador = administradores.Where(item => item.Usuario.Equals(usuario) && item.Clave.Equals(clave)).FirstOrDefault();
            return administrador;
        }
    }
}
