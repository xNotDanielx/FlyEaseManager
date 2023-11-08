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
    public partial class FrmAgregarAvion : Form
    {
        private FrmPrincipal principal;
        private AereolineaService AereolineaService = new AereolineaService();
        private AvionService avionService = new AvionService();
        public FrmAgregarAvion(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void FrmAgregarAvion_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        async void CargarCombo()
        {
            CbAerolinea.DataSource = await AereolineaService.ObtenerTodos();
            CbAerolinea.DisplayMember = "Nombre";
        }

        void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtModelo.Text = "";
            TxtFabricante.Text = "";
            TxtVelocidad.Text = "";
            TxtCantidadPasajeros.Text = "";
            TxtCatidadCarga.Text = "";
            CbAerolinea.Text = "";
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            var obtenerAerolinea = await AereolineaService.ObtenerTodos();
            Avion avion = new Avion
            {
                IdAvion = TxtId.Text,
                Nombre = TxtNombre.Text,
                Modelo = TxtModelo.Text,
                Fabricante = TxtFabricante.Text,
                VelocidadPromedio = double.Parse(TxtVelocidad.Text),
                CantidadPasajeros = int.Parse(TxtCantidadPasajeros.Text),
                CantidadCarga = double.Parse(TxtCatidadCarga.Text),
                Aereolinea = obtenerAerolinea.Where(x => x.Nombre == CbAerolinea.Text).FirstOrDefault(),
            };

            var response = await avionService.Crear(avion);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (response.Equals("Avion registrado correctamente"))
            {
                limpiarCampos();
            }
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAviones vista = new FrmModuloAviones(principal);
            principal.OpenForms(vista);
            this.Close();
        }
    }
}
