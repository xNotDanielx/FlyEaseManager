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
            DtpFechaSalida.Value = DateTime.Parse(vuelo.FechaYHoraDeSalida);
            CbDestino.Text = vuelo.aereopuerto_Destino.ToString();
            ChkCupo.Checked = vuelo.Cupo;
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
                    FechaYHoraDeSalida = DtpFechaSalida.Value.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"),
                    FechaYHoraLlegada = this.vuelo.FechaYHoraLlegada, //Se calcula y sobreescribe en la bd
                    Cupo = true, ////Se calcula y sobreescribe en la bd
                    aereopuerto_Despegue = obtenerAereopuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                    aereopuerto_Destino = obtenerAereopuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                    Estado = obtenerEstado.Where(p => p.Nombre == CbEstado.Text).FirstOrDefault(),
                    Avion = obtenerAvvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault(),
                    FechaRegistro = this.vuelo.FechaRegistro
                };

                var response = await vueloService.Actualizar(this.vuelo.IdVuelo.ToString(), vuelo);

                MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            TxtCantidadAsietos.Text = "";
            ChkCupo.Checked = true;
            TxtAsientosPremium.Text = "";
            CbAvion.Text = "";
            TxtAsientosEconomicos.Text = "";
            CbEstado.Text = "";
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void TxtCantidadAsietos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtAsientosPremium_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtAsientosEconomicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
