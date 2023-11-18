using BLL.Servicios;
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

namespace WindowsFormsApp1
{
    public partial class FrmAgregarVuelos : Form
    {
        private FrmPrincipal principal;
        private AereopuertoService aereopuertoService = new AereopuertoService();
        private AvionService AvionService = new AvionService();
        private EstadoService estadoService = new EstadoService();
        private VueloService VueloService = new VueloService();
        public FrmAgregarVuelos(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloVuelos vista = new FrmModuloVuelos(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async void FrmAgregarVuelos_Load(object sender, EventArgs e)
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
                ConfigurarDateTimePickers();
                await CargarCombos();
                TxtPrecio.ShortcutsEnabled = false;
                TxtDescuento.ShortcutsEnabled = false;
                TxtTarifa.ShortcutsEnabled = false;
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        void ConfigurarDateTimePickers()
        {
            DtpFechaSalida.MinDate = DateTime.Now;
            DtpFechaSalida.Value = DateTime.Now;
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
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

            var vuelos = await VueloService.ObtenerTodos();
            var vuelosDelAvion = vuelos.Where(item => item.Avion.Nombre.Equals(CbAvion.Text)).ToList();

            foreach (var item in vuelosDelAvion)
            {
                if (DtpFechaSalida.Value >= item.FechaYHoraDeSalida && DtpFechaSalida.Value <= item.FechaYHoraLlegada)
                {
                    MessageBox.Show("La fecha de salida del avión seleccionado no debe interferir en la fecha de sus vuelos ya programados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DateTime horaActual = DateTime.Now;
            DateTime horaLimite = horaActual.AddHours(1);

            if (DtpFechaSalida.Value < horaLimite)
            {
                MessageBox.Show("La hora de salida debe ser al menos una hora más tarde que la hora actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loading = CrearLoading();

            try
            {
                var obtenerAeropuerto = await aereopuertoService.ObtenerTodos();
                var obtenerEstado = await estadoService.ObtenerTodos();
                var obtenerAvion = await AvionService.ObtenerTodos();

                Vuelo vuelo = new Vuelo
                {
                    PrecioVuelo = double.Parse(TxtPrecio.Text),
                    TarifaTemporada = double.Parse(TxtTarifa.Text),
                    Descuento = double.Parse(TxtDescuento.Text),
                    FechaYHoraDeSalida = DtpFechaSalida.Value,
                    FechaYHoraLlegada = DateTime.Parse("2023-12-12T20:43:18.719323"),
                    Cupo = true,
                    aeropuerto_Despegue = obtenerAeropuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                    aeropuerto_Destino = obtenerAeropuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                    Estado = obtenerEstado.Where(p => p.Nombre == "Disponible").FirstOrDefault(),
                    Avion = obtenerAvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault()
                };

                loading.ShowLoading(loading);
                var response = await VueloService.Crear(vuelo);
                loading.HideLoading();

                if (response != "Error en la solicitud Post")
                {
                    LimpiarCampos();
                    MessageBox.Show("Se ha creado correctamente el vuelo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error al crear el vuelo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void LimpiarCampos()
        {
            TxtPrecio.Text = "";
            TxtTarifa.Text = "";
            TxtDescuento.Text = "";
            CbDespegue.Text = "";
            DtpFechaSalida.Value = DateTime.Now;
            CbDestino.Text = "";
            CbAvion.Text = "";      
        }

        private async Task CargarCombos()
        {
            //Despegue             
            CbDespegue.DataSource = await aereopuertoService.ObtenerTodos();
            CbDespegue.DisplayMember = "Nombre";

            //Destino
            CbDestino.DataSource = await aereopuertoService.ObtenerTodos();
            CbDestino.DisplayMember = "Nombre";

            //Avion
            CbAvion.DataSource = await AvionService.ObtenerTodos();
            CbAvion.DisplayMember = "Nombre";

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
