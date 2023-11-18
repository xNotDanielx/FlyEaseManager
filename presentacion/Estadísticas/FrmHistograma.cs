using BLL.Servicios;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class FrmHistograma : Form
    {
        private VueloService vueloService = new VueloService();
        public FrmHistograma()
        {
            InitializeComponent();
        }

        private async void FrmHistograma_Load(object sender, EventArgs e)
        {
            cargarCombo(await vueloService.ObtenerTodos());
            if (CbAño.Text != "")
            {
                configurarGrafica(await vueloService.ContarVuelosPorMes(int.Parse(CbAño.Text)));
            }
        }

        void configurarGrafica(Dictionary<int, int> conteo)
        {
            ChartTiempoVsVuelos.Series.Clear();
            ChartTiempoVsVuelos.Titles.Add("Historial de vuelos por mes en un año especifico");
            Series series = new Series
            {
                Name = "Vuelos",
                ChartType = SeriesChartType.Column
            };

            foreach (var kvp in conteo.OrderBy(item => item.Key))   
            {
                series.Points.AddXY(MesAString(kvp.Key), kvp.Value);
            }

            ChartTiempoVsVuelos.Series.Add(series);

            // Ajusta otras propiedades según tus preferencias
            ChartTiempoVsVuelos.ChartAreas[0].AxisX.Interval = 1;
            ChartTiempoVsVuelos.ChartAreas[0].AxisX.Title = "Meses";
            ChartTiempoVsVuelos.ChartAreas[0].AxisY.Title = "Vuelos";
        }

        private string MesAString(int mes)
        {
                return DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(mes);
        }

        void cargarCombo(List<Vuelo> vuelos)
        {
            foreach (var item in vuelos)
            {
                if (CbAño.Items.Contains(item.FechaRegistro.Year.ToString()) == false)
                {
                    CbAño.Items.Add(item.FechaRegistro.Year.ToString());
                }                
            }
        }

        private async void CbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            configurarGrafica(await vueloService.ContarVuelosPorMes(int.Parse(CbAño.Text)));
        }
    }
}
