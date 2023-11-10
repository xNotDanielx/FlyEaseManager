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
            var obtenerAeropuerto = await aereopuertoService.ObtenerTodos();
            var obtenerEstado = await estadoService.ObtenerTodos();
            var obtenerAvion = await AvionService.ObtenerTodos();
            Vuelo vuelo = new Vuelo
            {
                PrecioVuelo = double.Parse(TxtPrecio.Text),
                TarifaTemporada = double.Parse(TxtTarifa.Text),
                Descuento = double.Parse(TxtDescuento.Text),
                FechaYHoraDeSalida = DtpFechaSalida.Value.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"),
                FechaYHoraLlegada = "2023-11-12T20:43:18.719323",
                Cupo = ChkCupo.Checked,
                aereopuerto_Despegue = obtenerAeropuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                aereopuerto_Destino = obtenerAeropuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                Estado = obtenerEstado.Where(p => p.Nombre == CbEstado.Text).FirstOrDefault(),
                Avion = obtenerAvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault()
                //ADespegue = (Aereopuerto)CbDespegue.SelectedItem,
                //ADestino = (Aereopuerto)CbDestino.SelectedItem,
                //Estado = (Estado)CbEstado.SelectedItem,
                //Avion = (Avion)CbAvion.SelectedItem
            };

            var response = await VueloService.Crear(vuelo);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (response.Equals("Vuelo registrado correctamente"))//AjustarMensaje
            {
                GuardarAsientos();
                LimpiarCampos();
            }
        }

        async void GuardarAsientos()
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
                contadorAsiento++;
            }

            for (int i = contadorAsiento + 1; i < int.Parse(TxtAsientosEconomicos.Text); i++)
            {
                Asiento asiento = new Asiento
                {
                    Posicion = i,
                    Disponibilidad = true,
                    Categoria = obtenerCategoria.Where(p => p.Nombre == "Economico").FirstOrDefault(),
                    Avion = obtenerAvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault()
                };
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
    }
}
