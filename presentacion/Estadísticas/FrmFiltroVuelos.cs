using BLL.Servicios;
using Entity;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmFiltroVuelos : Form
    {
        private EstadoService EstadoService = new EstadoService();
        private VueloService VueloService = new VueloService();
        public FrmFiltroVuelos()
        {
            InitializeComponent();
        }

        private async void FrmFiltroVuelos_Load(object sender, EventArgs e)
        {
            
            cargarCombo(await EstadoService.ObtenerTodos());
            CargarGrilla(await VueloService.ObtenerTodos());
        }

        void cargarGrillaSinFiltro()
        {
            CargarGrilla(VueloService.ObtenerTodos().Result);
        }

        void cargarCombo(List<Estado> estados)
        {
            foreach (var item in estados)
            {
                CbEstado.Items.Add(item.Nombre.ToString());
            }
            //CbEstado.DataSource = estados;
            //CbEstado.DisplayMember = "Nombre";
        }

        private void CargarGrilla(List<Vuelo> vuelos)
        {
            try
            {
                DgvVuelos.Rows.Clear();
                foreach (var item in vuelos)
                {
                    DgvVuelos.Rows.Add(item.IdVuelo, item.PrecioVuelo,item.TarifaTemporada, item.Descuento, item.DistanciaRecorrida, item.FechaYHoraDeSalida, item.FechaYHoraLlegada,
                        item.aeropuerto_Despegue.Nombre, item.aeropuerto_Destino.Nombre, item.Estado.Nombre, item.Avion.Nombre, item.FechaRegistro.ToString());
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private async void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vuelos = await VueloService.ObtenerTodos();

            if (CbEstado.Text == "")
            {
                CargarGrilla(vuelos);
            }
            else
            {
                CargarGrilla(vuelos.Where(item => item.Estado.Nombre.Equals(CbEstado.Text)).ToList());
            }            
        }
    }
}
