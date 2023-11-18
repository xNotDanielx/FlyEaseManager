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

        public async Task<Dictionary<string, int>> ContarVuelosPorCiudadDestino(int anoVuelo)
        {
            List<Vuelo> Vuelos = await lecturaRepository.ObtenerTodos();

            List<Vuelo> vuelosFiltradosPorAno = Vuelos.Where(vuelo => vuelo.FechaYHoraDeSalida.Year == anoVuelo).ToList();

            Dictionary<string, int> conteoPorCiudad = new Dictionary<string, int>();

            foreach (Vuelo vuelo in vuelosFiltradosPorAno)
            {
                if (vuelo.Estado.Nombre == "Completado")
                {
                    if (conteoPorCiudad.ContainsKey(vuelo.aeropuerto_Destino.Ciudad.Nombre.ToString()))
                    {
                        conteoPorCiudad[vuelo.aeropuerto_Destino.Ciudad.Nombre.ToString()]++;
                    }
                    else
                    {
                        conteoPorCiudad[vuelo.aeropuerto_Destino.Ciudad.Nombre.ToString()] = 1;
                    }
                }
            }

            var ciudadesTop10 = conteoPorCiudad.OrderByDescending(pair => pair.Value).Take(10).ToDictionary(pair => pair.Key, pair => pair.Value);

            return ciudadesTop10;
        }

        public async Task<Dictionary<int, int>> ContarVuelosPorMes(int anoVuelo)
        {
            List<Vuelo> Vuelos = await lecturaRepository.ObtenerTodos();

            List<Vuelo> vuelosFiltradosPorAno = Vuelos.Where(vuelo => vuelo.FechaYHoraDeSalida.Year == anoVuelo).ToList();

            Dictionary<int, int> vuelosPorMes = new Dictionary<int, int>();

            foreach (var vuelo in vuelosFiltradosPorAno)
            {
                int mes = vuelo.FechaRegistro.Month;

                if (vuelo.Estado.Nombre == "Completado")
                {
                    if (vuelosPorMes.ContainsKey(mes))
                    {
                        vuelosPorMes[mes]++;
                    }
                    else
                    {
                        vuelosPorMes[mes] = 1;
                    }
                }                
            }
            return vuelosPorMes;
        }                
    }
}
