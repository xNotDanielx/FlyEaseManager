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
        private VueloService vueloService = new VueloService();
        public FrmDestinosPopulares()
        {
            InitializeComponent();
        }

        private async void FrmDestinosPopulares_Load(object sender, EventArgs e)
        {
            cargarCombo(await vueloService.ObtenerTodos());
            if (CbAno.Text != "")
            {                
                
                configurarGrafica(await vueloService.ContarVuelosPorCiudadDestino(int.Parse(CbAno.Text)));
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
            configurarGrafica(await vueloService.ContarVuelosPorCiudadDestino(int.Parse(CbAno.Text)));
        }
    }
}
