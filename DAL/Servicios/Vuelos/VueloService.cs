using BLL.Clases_Abstractas;
using DAL.Repositorios;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class VueloService : AbstractCRUDService<Vuelo>
    {

        public VueloService()
            : base(new VueloRepository())
        {
        }

        public List<Vuelo> FiltrarPorEstado(string estado)
        {
            List<Vuelo> vuelosFiltrados = lecturaRepository.ObtenerTodos().Where(item => item.Estado.Equals(estado)).ToList();
            return vuelosFiltrados;
        }

        public Dictionary<string, int> ContarVuelosPorCiudadDestino()
        {
            List<Vuelo> vuelosRealizados = lecturaRepository.ObtenerTodos().Where(item => item.Estado.Equals("Realizado")).ToList();

            var conteoPorCiudad = new Dictionary<string, int>();

            foreach (Vuelo vuelo in vuelosRealizados)
            {
                string ciudadDestino = vuelo.ADestino.Ciudad.Nombre;

                if (conteoPorCiudad.ContainsKey(ciudadDestino))
                {
                    conteoPorCiudad[ciudadDestino]++;
                }
                else
                {
                    conteoPorCiudad[ciudadDestino] = 1;
                }
            }
            return conteoPorCiudad;
        }

    }
}
