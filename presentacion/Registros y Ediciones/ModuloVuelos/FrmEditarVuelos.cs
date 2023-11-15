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
    public partial class FrmEditarVuelos : Form
    {
        private FrmPrincipal principal;
        private Vuelo vuelo;
        private VueloService vueloService = new VueloService();
        private AsientoService AsientoService = new AsientoService();
        private AereopuertoService aereopuertoService = new AereopuertoService();
        private AvionService AvionService = new AvionService();
        private EstadoService estadoService = new EstadoService();

        public FrmEditarVuelos(FrmPrincipal principal, Vuelo vuelo)
        {
            this.principal = principal;
            
            this.vuelo= vuelo;
            InitializeComponent();
        }

        private void FrmEditarVuelos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarCampos(vuelo);
            TxtPrecio.ShortcutsEnabled = false;
            TxtDescuento.ShortcutsEnabled = false;
            TxtTarifa.ShortcutsEnabled = false;
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

        private void CargarCampos(Vuelo vuelo)
        {
            TxtPrecio.Text = vuelo.PrecioVuelo.ToString();
            TxtTarifa.Text = vuelo.TarifaTemporada.ToString();
            TxtDescuento.Text = vuelo.Descuento.ToString();
            CbDespegue.Text = vuelo.aereopuerto_Despegue.ToString();
            DtpFechaSalida.Value = vuelo.FechaYHoraDeSalida;
            CbDestino.Text = vuelo.aereopuerto_Destino.ToString();
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

            var vuelos = await vueloService.ObtenerTodos();
            var vuelosDelAvion = vuelos.Where(item => item.Avion.Nombre.Equals(CbAvion.Text)).ToList();

            foreach (var item in vuelosDelAvion)
            {
                    if (DtpFechaSalida.Value >= item.FechaYHoraDeSalida && DtpFechaSalida.Value <= item.FechaYHoraLlegada)
                    {
                        MessageBox.Show("La fecha de salida del avión seleccionado no debe interferir en la fecha de sus vuelos ya programados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }   
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
                    aereopuerto_Despegue = obtenerAereopuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                    aereopuerto_Destino = obtenerAereopuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                    Estado = obtenerEstado.Where(p => p.Nombre == CbEstado.Text).FirstOrDefault(),
                    Avion = obtenerAvvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault(),
                    FechaRegistro = this.vuelo.FechaRegistro
                };

                var response = await vueloService.Actualizar(this.vuelo.IdVuelo.ToString(), vuelo);

                if (response != "Error en la solicitud Put")
                {
                    limpiarCampos();
                    MessageBox.Show("Se ha actualizado correctamente el vuelo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
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
