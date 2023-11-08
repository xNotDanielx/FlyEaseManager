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
        public FrmEditarVuelos(FrmPrincipal principal, string IdVuelo)
        {
            this.principal = principal;
            
            this.idVuelo= IdVuelo;
            InitializeComponent();
        }

        private void FrmEditarVuelos_Load(object sender, EventArgs e)
        {
            ConfigurarDateTimePickers();
        }

        void ConfigurarDateTimePickers()
        {
            DtpFechaSalida.MinDate = DateTime.Now;
            DtpFechaSalida.Value = DateTime.Now;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            
            FrmAgregarVuelos vista = new FrmAgregarVuelos(principal);
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
            CbDespegue.Text = vuelo.ADespegue.ToString();
            DtpFechaSalida.Value = DateTime.Parse(vuelo.FechaYHoraDespegue);
            CbDestino.Text = vuelo.ADestino.ToString();
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
            CbAviones.Text = vuelo.Avion.Nombre.ToString();
            TxtAsientosEconomicos.Text = asientosEconomicos.ToString();
            CbEstados.Text = vuelo.Estado.Nombre.ToString();
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
                FechaYHoraDespegue = DtpFechaSalida.Value.ToString(),
                //FechaYHoraLlegada = Vuelo.FechaYHoraLlegada,
                Cupo = ChkCupo.Checked,
                ADespegue = obtenerAereopuerto.Where(p => p.Nombre == CbDespegue.Text).FirstOrDefault(),
                ADestino = obtenerAereopuerto.Where(p => p.Nombre == CbDestino.Text).FirstOrDefault(),
                Estado = obtenerEstado.Where(p => p.Nombre == CbEstados.Text).FirstOrDefault(),
                Avion = obtenerAvvion.Where(p => p.Nombre == CbAviones.Text).FirstOrDefault(),
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
            CbAviones.Text = "";
            TxtAsientosEconomicos.Text = "";
            CbEstados.Text = "";
        }
    }
}
