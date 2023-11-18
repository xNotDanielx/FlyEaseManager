using BLL.Clases_Abstractas;
using DAL.Repositorios;
using Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class BoletoService : AbstractCRUDService<Boleto>
    {
        public BoletoService()
            : base(new BoletoRepository())
        {

        }


        public async Task<List<Boleto>> ListaPorAno(int ano)
        {
            List<Boleto> boletos = await lecturaRepository.ObtenerTodos();
            List<Boleto> boletosPorAño = new List<Boleto>();
            foreach (var item in boletos)
            {
                if (item.Vuelo.Estado.Nombre == "Completado")
                {
                    if (item.Vuelo.FechaYHoraDeSalida.Year == ano)
                    {
                        boletosPorAño.Add(item);
                    }
                }
            }

            return boletosPorAño;
        }
    }
}
