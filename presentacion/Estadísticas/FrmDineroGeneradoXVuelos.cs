using BLL.Servicios;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class FrmDineroGeneradoXVuelos : Form
    {
        private VueloService vueloService = new VueloService();
        private BoletoService BoletoService = new BoletoService();
        public FrmDineroGeneradoXVuelos()
        {
            InitializeComponent();
        }

        private async void FrmDineroGeneradoXVuelos_Load(object sender, EventArgs e)
        {
            cargarCombo(await vueloService.ObtenerTodos());
            cargarGrilla(await BoletoService.ObtenerTodos());
        }

        void cargarCombo(List<Vuelo> vuelos)
        {
            foreach (var item in vuelos)
            {
                if (item.Estado.Nombre == "Completado")
                {
                    if (CbAno.Items.Contains(item.FechaYHoraDeSalida.Year.ToString()) == false)
                    {
                        CbAno.Items.Add(item.FechaYHoraDeSalida.Year.ToString());
                    }
                }
            }
        }

        void cargarGrilla(List<Boleto> boletos)
        {            
                try
                {
                    DgvDineroGenerado.Rows.Clear();
                    foreach (var item in boletos)
                    {
                        DgvDineroGenerado.Rows.Add(item.Vuelo.IdVuelo, item.PrecioTotal);
                    }
                }
                catch (Exception)
                {
                    return;
                }            
        }

        private async void CbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Total = 0;
            if (CbAno.Text != "")
            {
                cargarGrilla(await BoletoService.ListaPorAno(int.Parse(CbAno.Text)));
                foreach (var item in await BoletoService.ListaPorAno(int.Parse(CbAno.Text)))
                {
                    Total += item.PrecioTotal;
                }
            }
            LblTotal.Text = Total.ToString();
            LblTotal.Show();
        }
    }
}
