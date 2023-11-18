using BLL.Servicios;
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
            configurarGrafica(await vueloService.ContarVuelosPorCiudadDestino());           
        } 
        
        void configurarGrafica(Dictionary<string, int> conteo)
        {

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
    }
}
