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
            try
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
                if (response != "Error en la solicitud Put: ")
                {
                    limpiarCampos();
                    MessageBox.Show("Se ha actualizado correctamente el avion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el avion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEditarAvion_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void cargarCampos(Avion avion)
        {
            TxtId.Text = avion.IdAvion;
            TxtNombre.Text = avion.Nombre;
            TxtModelo.Text = avion.Modelo;
            TxtFabricante.Text = avion.Fabricante;
            TxtVelocidad.Text = avion.VelocidadPromedio.ToString();
            TxtCantidadPasajeros.Text = avion.CantidadPasajeros.ToString();
            TxtCatidadCarga.Text = avion.CantidadCarga.ToString();
            CbAerolinea.Text = avion.Aereolinea.Nombre;
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

        async void CargarCombo()
        {
            CbAerolinea.DataSource = await AereolineaService.ObtenerTodos();
            CbAerolinea.DisplayMember = "Nombre";
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAviones vista = new FrmModuloAviones(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCantidadPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCatidadCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtVelocidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
