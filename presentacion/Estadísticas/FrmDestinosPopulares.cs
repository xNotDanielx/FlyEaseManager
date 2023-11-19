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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class FrmDestinosPopulares : Form
    {
        private FrmPrincipal principal;
        private VueloService vueloService = new VueloService();

        public FrmDestinosPopulares(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void FrmDestinosPopulares_Load(object sender, EventArgs e)
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

                if (CbAno.Text != "")
                {
                    configurarGrafica(await vueloService.ContarVuelosPorCiudadDestino(int.Parse(CbAno.Text)));
                }
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        void configurarGrafica(Dictionary<string, int> conteo)
        {
            ChartDestinosPopulares.Series[0].Points.Clear();
            ChartDestinosPopulares.Legends[0].CustomItems.Clear();

            ChartDestinosPopulares.ForeColor = Color.White;
            foreach (var kvp in conteo)
            {
                string leyenda = $"{kvp.Value} veces";
                ChartDestinosPopulares.Series[0].Points.AddXY(kvp.Key, kvp.Value);
                ChartDestinosPopulares.Series[0].Points.Last().LegendText = leyenda;
            }  
        }

        void cargarCombo(List<Vuelo> vuelos)
        {
            foreach (var item in vuelos)
            {
                if (CbAno.Items.Contains(item.FechaRegistro.Year.ToString()) == false)
                {
                    CbAno.Items.Add(item.FechaRegistro.Year.ToString());
                }                
            }
        }

        private async void CbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarDatos();
        }
    }
}
