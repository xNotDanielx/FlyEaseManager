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

        public async Task<List<Vuelo>> FiltrarPorEstado(string estado)
        {
            List<Vuelo> vuelosFiltrados = await lecturaRepository.ObtenerTodos();
            return vuelosFiltrados.Where(item => String.Equals(item.Estado.Nombre, estado, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public async Task<Dictionary<string, int>> ContarVuelosPorCiudadDestino()
        {
            //List<Vuelo> vuelosRealizados = await lecturaRepository.ObtenerTodos();

            //vuelosRealizados = vuelosRealizados.Where(item => item.Estado.Nombre.Equals("Realizado")).ToList();

            //var conteoPorCiudad = new Dictionary<string, int>();

            //foreach (Vuelo vuelo in vuelosRealizados)
            //{
            //    string ciudadDestino = vuelo.aeropuerto_Destino.Ciudad.Nombre;

            //    if (conteoPorCiudad.ContainsKey(ciudadDestino))
            //    {
            //        conteoPorCiudad[ciudadDestino]++;
            //    }
            //    else
            //    {
            //        conteoPorCiudad[ciudadDestino] = 1;
            //    }
            //}
            //return conteoPorCiudad;

            List<Vuelo> vuelosRealizados = await lecturaRepository.ObtenerTodos();
            List<string> ciudades = vuelosRealizados.Select(vuelo => vuelo.aeropuerto_Destino.Ciudad.Nombre).ToList();

            Dictionary<string, int> conteoPorCiudad = new Dictionary<string, int>();

            foreach (string ciudad in ciudades)
            {
                if (conteoPorCiudad.ContainsKey(ciudad))
                {
                    conteoPorCiudad[ciudad]++;
                }
                else
                {
                    conteoPorCiudad[ciudad] = 1;
                }
            }
            return conteoPorCiudad;
        }

    }
}
