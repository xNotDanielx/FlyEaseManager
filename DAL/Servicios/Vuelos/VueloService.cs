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
            List<Vuelo> vuelosRealizados = await lecturaRepository.ObtenerTodos();
            List<string> ciudadesCompletadas = vuelosRealizados.Where(vuelo => vuelo.Estado.Nombre == "Completado").Select(vuelo => vuelo.aeropuerto_Destino.Ciudad.Nombre).ToList();

            Dictionary<string, int> conteoPorCiudad = new Dictionary<string, int>();

            foreach (string ciudad in ciudadesCompletadas)
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

            var ciudadesTop10 = conteoPorCiudad.OrderByDescending(pair => pair.Value).Take(10).ToDictionary(pair => pair.Key, pair => pair.Value);

            return ciudadesTop10;
        }

        public async Task<Dictionary<int, int>> ContarVuelosPorMes(int AñoVuelo)
        {
            List<Vuelo> vuelosRealizados = await lecturaRepository.ObtenerTodos();

            List<Vuelo> vuelosFiltrrados = vuelosRealizados.Where(vuelo => vuelo.FechaRegistro.Year == AñoVuelo).ToList();

            Dictionary<int, int> vuelosPorMes = new Dictionary<int, int>();

            foreach (var vuelo in vuelosRealizados)
            {
                int mes = vuelo.FechaRegistro.Month;

                if (vuelosPorMes.ContainsKey(mes))
                {
                    vuelosPorMes[mes]++;
                }
                else
                {
                    vuelosPorMes[mes] = 1;
                }
            }
            return vuelosPorMes;
        }        
    }
}
