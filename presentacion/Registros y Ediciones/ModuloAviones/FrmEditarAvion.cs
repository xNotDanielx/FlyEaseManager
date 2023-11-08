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
    public partial class FrmEditarAvion : Form
    {
        private FrmPrincipal principal;
        private string idAvion;
        private AereolineaService AereolineaService = new AereolineaService();
        private AvionService avionService = new AvionService();
        public FrmEditarAvion(FrmPrincipal principal, string IdAvion)
        {
            this.principal = principal;
            this.idAvion = IdAvion;
            InitializeComponent();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
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
                Aereolinea = obtenerAerolinea.Where(p => p.Nombre == CbAerolinea.Text).FirstOrDefault(),
            };
            var response = await avionService.Actualizar(idAvion, avion);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(response.Equals("Avion actualizado correctamente"))
            {
                limpiarCampos();
            }
        }

        private void FrmEditarAvion_Load(object sender, EventArgs e)
        {
            CargarCombo();
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

        void CargarCombo()
        {
            CbAerolinea.DataSource = AereolineaService.ObtenerTodos();
            CbAerolinea.DisplayMember = "Nombre";
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
