using BLL.Clases_Abstractas;
using DAL;
using Entity;
using Entity.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entity.Utilidades.RespuestaAutenticacion;

namespace BLL.Servicios
{
    public class AdministradorService : AbstractLecturaService<Administrador>
    {
        private readonly AdministradorRepository administradorRepository = new AdministradorRepository();

        public AdministradorService()
            : base(new AdministradorRepository())
        {
        }

        public async Task<Token> Autenticar(string username, string clave)
        {
            Administrador administrador = new Administrador()
            {
                Usuario = username,
                Clave = clave
            };

            var tokenManager = TokenManager.Instance;
            var response = await administradorRepository.Autenticar(administrador);

            if (response != null)
            {
                tokenManager._token = response.TokenString;
                tokenManager._refresh = response.RefreshToken;

                Token token = new Token
                {
                    TokenString = tokenManager._token,
                    RefreshToken = tokenManager._refresh
                };
                return token;
            }
            else
            {
                return null;
            }
        }
    }
}
