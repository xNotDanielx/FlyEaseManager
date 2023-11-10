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
        private string idVuelo;
        private VueloService vueloService = new VueloService();
        private AsientoService AsientoService = new AsientoService();
        private AereopuertoService aereopuertoService = new AereopuertoService();
        private AvionService AvionService = new AvionService();
        private EstadoService estadoService = new EstadoService();
        public FrmEditarVuelos(FrmPrincipal principal, string IdVuelo)
        {
            this.principal = principal;
            
            this.idVuelo= IdVuelo;
            InitializeComponent();
        }

        private async void FrmEditarVuelos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarCampos(ObtenerVuelo(await vueloService.ObtenerTodos()));
        }

        public Vuelo ObtenerVuelo(List<Vuelo> vuelos)
        {
            Vuelo vuelo = null;
            foreach (var item in vuelos)
            {
                if(item.IdVuelo.ToString() == idVuelo)
                {
                    vuelo = item;
                }
            }
            return vuelo;
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

        void CargarCampos(Vuelo vuelo)
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

        public async void CargarDatos()
        {
            var vuelo = await vueloService.ObtenerPorId(this.idVuelo);
            var listaAsientos = await AsientoService.ObtenerTodos();
            var obtenerNumeroAsientos = listaAsientos.Where(x => x.Avion.IdAvion == vuelo.Avion.IdAvion).ToList();
            var asientosPremium = obtenerNumeroAsientos.Where(x => x.Categoria.Nombre == "Premium").Count();
            var asientosEconomicos = obtenerNumeroAsientos.Where(x => x.Categoria.Nombre == "Economico").Count();
            TxtPrecio.Text = vuelo.PrecioVuelo.ToString();
            TxtTarifa.Text = vuelo.TarifaTemporada.ToString();
            TxtDescuento.Text = vuelo.Descuento.ToString();            
            CbDespegue.Text = vuelo.aereopuerto_Despegue.ToString();
            DtpFechaSalida.Value = DateTime.Parse(vuelo.FechaYHoraDeSalida);
            CbDestino.Text = vuelo.aereopuerto_Destino.ToString();
            TxtCantidadAsietos.Text = obtenerNumeroAsientos.Count().ToString();
            if(vuelo.Cupo == true)
            {
                ChkCupo.Checked = true;
            }
            else
            {
                ChkCupo.Checked = false;
            }
            TxtAsientosPremium.Text = asientosPremium.ToString();
            CbAvion.Text = vuelo.Avion.Nombre.ToString();
            TxtAsientosEconomicos.Text = asientosEconomicos.ToString();
            CbEstado.Text = vuelo.Estado.Nombre.ToString();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            var obtenerVuelo = await new VueloService().ObtenerTodos();
            var obtenerAereopuerto = await new AereopuertoService().ObtenerTodos();
            var obtenerEstado = await new EstadoService().ObtenerTodos();
            var obtenerAvvion = await new AvionService().ObtenerTodos();
            var Vuelo = obtenerVuelo.Where(p => p.IdVuelo == int.Parse(idVuelo)).FirstOrDefault();
            Vuelo vuelo = new Vuelo
            {
                IdVuelo = Vuelo.IdVuelo,
                PrecioVuelo = double.Parse(TxtPrecio.Text),
                TarifaTemporada = double.Parse(TxtTarifa.Text),
                Descuento = double.Parse(TxtDescuento.Text),
                DistanciaRecorrida = Vuelo.DistanciaRecorrida,
                FechaYHoraDeSalida = DtpFechaSalida.Value.ToString(),
                //FechaYHoraLlegada = Vuelo.FechaYHoraLlegada,
                Cupo = ChkCupo.Checked,
                aereopuerto_Despegue = obtenerAereopuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                aereopuerto_Destino = obtenerAereopuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                Estado = obtenerEstado.Where(p => p.Nombre == CbEstado.Text).FirstOrDefault(),
                Avion = obtenerAvvion.Where(p => p.Nombre == CbAvion.Text).FirstOrDefault(),
                FechaRegistro = Vuelo.FechaRegistro
            };
            var response = await vueloService.Actualizar(this.idVuelo, vuelo);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(response.Equals("Vuelo actualizado correctamente"))
            {
                limpiarCampos();
            }
            
        }

        void limpiarCampos()
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
