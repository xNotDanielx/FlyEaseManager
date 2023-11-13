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
    public partial class FrmAgregarVuelos : Form
    {
        private FrmPrincipal principal;
        private AereopuertoService aereopuertoService = new AereopuertoService();
        private AvionService AvionService = new AvionService();
        private EstadoService estadoService = new EstadoService();
        private VueloService VueloService = new VueloService();
        private CategoriaService CategoriaService = new CategoriaService();
        private AsientoService AsientoService = new AsientoService();
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
                    Cupo = ChkCupo.Checked,
                    aereopuerto_Despegue = obtenerAeropuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                    aereopuerto_Destino = obtenerAeropuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                    Estado = obtenerEstado.Where(p => p.Nombre == CbEstado.Text).FirstOrDefault(),
                    Avion = obtenerAvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault()
                };

                var response = await VueloService.Crear(vuelo);

                if (response != "Error en la solicitud Post")
                {
                    await GuardarAsientos();
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

        private async Task GuardarAsientos()
        {
            int contadorAsiento = 0;
            var obtenerCategoria = await CategoriaService.ObtenerTodos();
            var obtenerAvion = await AvionService.ObtenerTodos();

            for (int i = 1; i <= int.Parse(TxtAsientosPremium.Text); i++)
            {                
                Asiento asiento = new Asiento
                {
                    Posicion = i,
                    Disponibilidad = true,
                    Categoria = obtenerCategoria.Where(p => p.Nombre == "Premium").FirstOrDefault(),
                    Avion = obtenerAvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault()
                };
                await AsientoService.Crear(asiento);
                contadorAsiento = i;
            }

            for (int i = (contadorAsiento + 1); i <= (int.Parse(TxtAsientosEconomicos.Text) + contadorAsiento); i++)
            {
                Asiento asiento = new Asiento
                {
                    Posicion = i,
                    Disponibilidad = true,
                    Categoria = obtenerCategoria.Where(p => p.Nombre == "Economico").FirstOrDefault(),
                    Avion = obtenerAvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault()
                };
                await AsientoService.Crear(asiento);
            }
        }

        void LimpiarCampos()
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

        async void CargarCombos()
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
