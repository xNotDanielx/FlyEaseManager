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
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                cargarCombo(await vueloService.ObtenerTodos());
                if (CbAno.Items.Count >= 0)
                {
                    CbAno.SelectedIndex = 0;
                    loading.HideLoading();
                    await CargarDatos();
                }
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
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
            ChartDestinosPopulares.ForeColor = Color.White;
            foreach (var kvp in conteo)
            {
                string leyenda = $"{kvp.Value} veces";
                ChartDestinosPopulares.Series[0].Points.AddXY(kvp.Key, kvp.Value);
                ChartDestinosPopulares.Series[0].Points.Last().LegendText = leyenda;
            }

            // Ajusta otras propiedades según tus preferencias
            ChartDestinosPopulares.Legends.Add(new Legend("Leyenda"));
            ChartDestinosPopulares.Legends["Leyenda"].Docking = Docking.Bottom;
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
