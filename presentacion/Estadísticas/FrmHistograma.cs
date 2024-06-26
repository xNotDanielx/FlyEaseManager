﻿using BLL.Servicios;
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
        private FrmPrincipal principal;
        private VueloService vueloService = new VueloService();
        public FrmHistograma(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void FrmHistograma_Load(object sender, EventArgs e)
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
                    configurarGrafica(await vueloService.ContarVuelosPorMes(int.Parse(CbAno.Text)));
                }
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        void configurarGrafica(Dictionary<int, int> conteo)
        {
            ChartTiempoVsVuelos.Series.Clear();
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
                if (CbAno.Items.Contains(item.FechaYHoraDeSalida.Year.ToString()) == false)
                {
                    CbAno.Items.Add(item.FechaYHoraDeSalida.Year.ToString());
                }                
            }
        }

        private async void CbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarDatos();
        }
    }
}
