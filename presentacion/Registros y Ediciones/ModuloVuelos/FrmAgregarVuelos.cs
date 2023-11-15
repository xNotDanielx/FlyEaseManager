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

        private void FrmAgregarVuelos_Load(object sender, EventArgs e)
        {
            ConfigurarDateTimePickers();
            CargarCombos();
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
                MessageBox.Show("EL areopuerto de descpegue no puede ser el mismo de destino", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vuelos = await VueloService.ObtenerTodos();
            var vuelosDelAvion = vuelos.Where(item => item.Avion.Nombre.Equals(CbAvion.Text)).ToList();

            DateTime fechaYHoraSalidaVuelo;
            DateTime fechaYHoraLlegadaVuelo;

            foreach (var item in vuelosDelAvion)
            {
                if (DateTime.TryParseExact(item.FechaYHoraDeSalida, "yyyy-MM-ddTHH:mm:ss.ffffff", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaYHoraSalidaVuelo) &&
                    DateTime.TryParseExact(item.FechaYHoraLlegada, "yyyy-MM-ddTHH:mm:ss.ffffff", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaYHoraLlegadaVuelo))
                {
                    if (DtpFechaSalida.Value >= fechaYHoraSalidaVuelo && DtpFechaSalida.Value <= fechaYHoraLlegadaVuelo)
                    {
                        MessageBox.Show("La fecha de salida del avión seleccionado no debe interferir en la fecha de sus vuelos ya programados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

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
                    FechaYHoraDeSalida = DtpFechaSalida.Value.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"),
                    FechaYHoraLlegada = "2023-12-12T20:43:18.719323",
                    Cupo = true,
                    aereopuerto_Despegue = obtenerAeropuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                    aereopuerto_Destino = obtenerAeropuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                    Estado = obtenerEstado.Where(p => p.Nombre == CbEstado.Text).FirstOrDefault(),
                    Avion = obtenerAvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault()
                };

                var response = await VueloService.Crear(vuelo);

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
            CbEstado.Text = "";
        }

        private async void CargarCombos()
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

            //Estado
            CbEstado.DataSource = await estadoService.ObtenerTodos();
            CbEstado.DisplayMember = "Nombre";
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
