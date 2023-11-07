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
    public partial class FrmAgregarAereopuerto : Form
    {
        private FrmPrincipal principal;
        private CiudadService ciudadService = new CiudadService();
        //private CoordenadaService coordenadaService = new CoordenadaService();
        private AereopuertoService aereopuertoService = new AereopuertoService();
        public FrmAgregarAereopuerto(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            var obtenerCiudad = await ciudadService.ObtenerTodos();
            Coordenada coordenada = new Coordenada
            {
                Latitud = double.Parse(TxtLatitud.Text),
                Longitud = double.Parse(TxtLongitud.Text)
            };

            //await coordenadaService.crear(coordenada);

            Aereopuerto aereopuerto = new Aereopuerto
            {
                Nombre = TxtNombre.Text,
                Coordenada = coordenada,
                Ciudad = obtenerCiudad.Where(p => p.Nombre == CbCiudades.Text).FirstOrDefault()
            };

            var response = await aereopuertoService.Crear(aereopuerto);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var lista = await aereopuertoService.ObtenerTodos();            

            if (response.Equals("Aereopuerto registrado correctamente"))
            {
                limpiarCampos();
            }
        }

        private async void FrmAgregarAereopuerto_Load(object sender, EventArgs e)
        {
            CargarCombo(await ciudadService.ObtenerTodos());
        }

        void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtLatitud.Text = "";
            TxtLongitud.Text = "";
            CbCiudades.Text = "";
        }

        void CargarCombo(List<Ciudad> ciudades)
        {
            CbCiudades.DataSource = ciudades;
            CbCiudades.DisplayMember = "Nombre";
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
        }
    }
}
