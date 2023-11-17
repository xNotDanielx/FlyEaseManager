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
            //// Configura el tipo de gráfico como Pastel
            //ChartDestinosPopulares.Series[0].ChartType = SeriesChartType.Pie;

            //// Llama a tu método para obtener los datos del diccionario
            //Dictionary<string, int> conteoPorCiudad = await vueloService.ContarVuelosPorCiudadDestino();

            //// Llena la serie del gráfico circular con datos
            //foreach (var kvp in conteoPorCiudad)
            //{
            //    ChartDestinosPopulares.Series[0].Points.AddXY(kvp.Key, kvp.Value);
            //}

            //// Muestra la leyenda en el gráfico
            //ChartDestinosPopulares.Series[0].IsVisibleInLegend = true;
            //ChartDestinosPopulares.Legends.Add(new Legend("Leyenda"));
            //ChartDestinosPopulares.Legends["Leyenda"].Docking = Docking.Bottom;

            //String[] serieSE = { "IdVuelo", "PrecioVuelo", "TarifaTemporada", "Descuento ", "DistanciaRecorrida", "FechaYHoraDespegue", "FechaYHoraLlegada", "FechaRegistro", "Cupo", "ADespegue", "ADestino" };
            //int[] ResultadosSE = { logicaSE.ContarEmpleado(), logicaSE.ContarPropietario(), logicaSE.ContarT_Privado(), logicaSE.ContarC_Independiente(), logicaSE.ContarPensionado(), logicaSE.ContarSubisidiado(), logicaSE.ContarAccionista(), logicaSE.ContarT_Publico(), logicaSE.ContarI_Actividades(), logicaSE.ContarDesempleado() };
            //int[] ResultadosSH = { logicaSH.ContarRural(), logicaSH.ContarUrbana(), logicaSH.ContarAgua(), logicaSH.ContarLuz(), logicaSH.ContarGas(), logicaSH.ContarSaneamiento(), logicaSH.ContarVehiculo(), logicaSH.ContarInternet() };
            //int[] ResultadosSS = { logicaSS.ContarAfiliado(), logicaSS.ContarV_Conflicto(), logicaSS.ContarA_Estudio(), logicaSS.ContarArhuaco(), logicaSS.ContarKogui(), logicaSS.ContarKankuamo(), logicaSS.ContarWiwa(), logicaSS.ContarYucpa(), logicaSS.ContarChimila(), logicaSS.ContarNinguna_E(), logicaSS.ContarE_Formal(), logicaSS.ContarPrimaria(), logicaSS.ContarSecundaria(), logicaSS.ContarTecnicos(), logicaSS.ContarUniversitario(), logicaSS.ContarE_Otro() };
            //int[] ResultadosPE = { LogicaL.ContarCC(), LogicaL.ContarCE(), logicaP.ContarHombres(), logicaP.ContarMujeres(), logicaP.ContarMayorEdad(), logicaP.ContarMenorEdad(), logicaP.ContarHogar(), logicaP.ContarApartamento() };

        } 
        
        void configurarGrafica(Dictionary<string, int> conteo)
        {
            ChartDestinosPopulares.Series[0].ChartType = SeriesChartType.Pie;

            foreach (var kvp in conteo)
            {
                string legend = $"{kvp.Key} veces";
                ChartDestinosPopulares.Series[0].Points.AddXY(legend, kvp.Value);
            }

            // Ajusta otras propiedades según tus preferencias
            ChartDestinosPopulares.Legends.Add(new Legend("Leyenda"));
            ChartDestinosPopulares.Legends["Leyenda"].Docking = Docking.Bottom;
        }
    }
}
