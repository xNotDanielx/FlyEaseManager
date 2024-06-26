﻿using BLL.Servicios;
using Entity;
using Entity.Utilidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class FrmEditarVuelos : Form
    {
        private FrmPrincipal principal;
        private Vuelo vuelo;
        private VueloService vueloService = new VueloService();
        private AereopuertoService aereopuertoService = new AereopuertoService();
        private AvionService AvionService = new AvionService();
        private EstadoService estadoService = new EstadoService();

        public FrmEditarVuelos(FrmPrincipal principal, Vuelo vuelo)
        {
            this.principal = principal;
            
            this.vuelo = vuelo;
            InitializeComponent();
        }

        private async void FrmEditarVuelos_Load(object sender, EventArgs e)
        {
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                await CargarDatos();
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private async Task CargarDatos()
        {            
                await CargarCombos();
                CargarCampos(this.vuelo);
                TxtPrecio.ShortcutsEnabled = false;
                TxtDescuento.ShortcutsEnabled = false;
                TxtTarifa.ShortcutsEnabled = false;                
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }

        private async Task CargarCombos()
        {
            //Despegue             
            foreach (var item in await aereopuertoService.ObtenerTodos())
            {
                CbDespegue.Items.Add(item.Nombre);
            }

            //Destino
            foreach (var item in await aereopuertoService.ObtenerTodos())
            {
                CbDestino.Items.Add(item.Nombre);
            }

            //Avion
            foreach (var item in await AvionService.ObtenerTodos())
            {
                CbAvion.Items.Add(item.Nombre);
            }

            //Estado
            foreach (var item in await estadoService.ObtenerTodos())
            {
                CbEstado.Items.Add(item.Nombre);
            }
        }

        private void CargarCampos(Vuelo vuelo)
        {
            TxtPrecio.Text = vuelo.PrecioVuelo.ToString();
            TxtTarifa.Text = vuelo.TarifaTemporada.ToString();
            TxtDescuento.Text = vuelo.Descuento.ToString();
            CbDespegue.Text = vuelo.aeropuerto_Despegue.Nombre.ToString();
            DtpFechaSalida.Value = vuelo.FechaYHoraDeSalida;
            CbDestino.Text = vuelo.aeropuerto_Destino.Nombre.ToString();
            CbAvion.Text = vuelo.Avion.Nombre.ToString();
            CbEstado.Text = vuelo.Estado.Nombre.ToString();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            
            FrmModuloVuelos vista = new FrmModuloVuelos(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            string precio = TxtPrecio.Text.Trim();
            string descuento = TxtDescuento.Text.Trim();
            string tarifa = TxtTarifa.Text.Trim();

            if (Validacion.EsNuloOVacio(precio) || Validacion.EsNuloOVacio(descuento) || Validacion.EsNuloOVacio(tarifa))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CbDespegue.Text.Equals(CbDestino.Text))
            {
                MessageBox.Show("EL areopuerto de despegue no puede ser el mismo de destino", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loading = CrearLoading();
            loading.ShowLoading(loading);

            var vuelos = await vueloService.ObtenerTodos();
            var vuelosDelAvion = vuelos.Where(item => item.Avion.Nombre.Equals(CbAvion.Text)).ToList();

            foreach (var item in vuelosDelAvion)
            {
                if (vuelo.IdVuelo != item.IdVuelo) {
                    if (DtpFechaSalida.Value >= item.FechaYHoraDeSalida && DtpFechaSalida.Value <= item.FechaYHoraLlegada)
                    {
                        loading.HideLoading();
                        MessageBox.Show("La fecha de salida del avión seleccionado no debe interferir en la fecha de sus vuelos ya programados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            DateTime horaActual = DateTime.Now;
            DateTime horaLimite = horaActual.AddHours(1);

            if (DtpFechaSalida.Value < horaLimite)
            {
                loading.HideLoading();
                MessageBox.Show("La hora de salida debe ser al menos una hora más tarde que la hora actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            try
            {
                
                var obtenerVuelo = await new VueloService().ObtenerTodos();
                var obtenerAereopuerto = await new AereopuertoService().ObtenerTodos();
                var obtenerEstado = await new EstadoService().ObtenerTodos();
                var obtenerAvvion = await new AvionService().ObtenerTodos();

                Vuelo vuelo = new Vuelo
                {
                    IdVuelo = this.vuelo.IdVuelo,
                    PrecioVuelo = double.Parse(TxtPrecio.Text),
                    TarifaTemporada = double.Parse(TxtTarifa.Text),
                    Descuento = double.Parse(TxtDescuento.Text),
                    DistanciaRecorrida = this.vuelo.DistanciaRecorrida, //Se calcula y sobreescribe en la bd
                    FechaYHoraDeSalida = DtpFechaSalida.Value,
                    FechaYHoraLlegada = DateTime.Parse("2023-12-12T20:43:18.719323"), //Se calcula y sobreescribe en la bd
                    Cupo = true, ////Se calcula y sobreescribe en la bd
                    aeropuerto_Despegue = obtenerAereopuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                    aeropuerto_Destino = obtenerAereopuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                    Estado = obtenerEstado.Where(p => p.Nombre == CbEstado.Text).FirstOrDefault(),
                    Avion = obtenerAvvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault(),
                    FechaRegistro = this.vuelo.FechaRegistro
                };

                var response = await vueloService.Actualizar(this.vuelo.IdVuelo.ToString(), vuelo);

                if (response != "Error en la solicitud Put")
                {
                    limpiarCampos();
                    loading.HideLoading();
                    MessageBox.Show("Se ha actualizado correctamente el vuelo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loading.HideLoading();
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error al actualizar el vuelo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpiarCampos()
        {
            TxtPrecio.Text = "";
            TxtTarifa.Text = "";
            TxtDescuento.Text = "";
            CbDespegue.Text = "";
            DtpFechaSalida.Value = DateTime.Now;
            CbDestino.Text = "";
            CbAvion.Text = "";
            CbEstado.Text = "";
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && TxtPrecio.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
