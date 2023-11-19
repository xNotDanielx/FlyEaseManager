using BLL.Servicios;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class FrmDineroGeneradoXVuelos : Form
    {
        private FrmPrincipal principal;
        private VueloService vueloService = new VueloService();
        private BoletoService BoletoService = new BoletoService();
        public FrmDineroGeneradoXVuelos(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void FrmDineroGeneradoXVuelos_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }

        private async Task CargarDatos()
        {
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                cargarCombo(await vueloService.ObtenerTodos());
                cargarGrilla(await BoletoService.ObtenerTodos());
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
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
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
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
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
}
    }
}
