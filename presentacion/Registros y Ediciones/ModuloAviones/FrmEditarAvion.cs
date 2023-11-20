using BLL.Servicios;
using Entity;
using Entity.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FrmEditarAvion : Form
    {
        private FrmPrincipal principal;
        private Avion avion;
        private AereolineaService aereolineaService = new AereolineaService();
        private AvionService avionService = new AvionService();

        public FrmEditarAvion(FrmPrincipal principal, Avion avion)
        {
            this.principal = principal;
            this.avion = avion;
            InitializeComponent();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            string idAvion = TxtId.Text.Trim();
            string nombre = TxtNombre.Text.Trim();
            string modelo = TxtModelo.Text.Trim();
            string fabricante = TxtFabricante.Text.Trim();
            string velocidadPromedio = TxtVelocidad.Text.Trim();
            string cantidadCarga = TxtCatidadCarga.Text.Trim();

            if (Validacion.EsNuloOVacio(idAvion) || Validacion.EsNuloOVacio(nombre) || Validacion.EsNuloOVacio(modelo) || Validacion.EsNuloOVacio(fabricante) || Validacion.EsNuloOVacio(velocidadPromedio) || Validacion.EsNuloOVacio(cantidadCarga))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loading = CrearLoading();

            try
            {
                loading.ShowLoading(loading);
                var obtenerAerolinea = await aereolineaService.ObtenerTodos();
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
                    FechaRegistro = this.avion.FechaRegistro
                };

                var response = await avionService.Actualizar(avion.IdAvion, avion);

                if (response != "Error en la solicitud Put")
                {
                    limpiarCampos();
                    loading.HideLoading();
                    MessageBox.Show("Se ha actualizado correctamente el avion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loading.HideLoading();
                    MessageBox.Show("No se ha podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error al actualizar el avion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmEditarAvion_Load(object sender, EventArgs e)
        {
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                await CargarDatos();
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }

        private async Task CargarDatos()
        {
                            
                await CargarCombo(await aereolineaService.ObtenerTodos());
                cargarCampos(this.avion);
                TxtId.ShortcutsEnabled = false;
                TxtNombre.ShortcutsEnabled = false;
                TxtModelo.ShortcutsEnabled = false;
                TxtFabricante.ShortcutsEnabled = false;
                TxtVelocidad.ShortcutsEnabled = false;
                TxtCatidadCarga.ShortcutsEnabled = false;
                TxtCantidadPasajeros.Enabled = false;
                TxtCantidadPasajeros.BackColor = Color.White;
                TxtCantidadPasajeros.ForeColor = Color.Black;
                
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
            CbAerolinea.Text = avion.Aereolinea.Nombre.ToString();
        }

        void limpiarCampos()
        {
            TxtId.Text = "";
            TxtNombre.Text = "";
            TxtModelo.Text = "";
            TxtFabricante.Text = "";
            TxtVelocidad.Text = "";
            TxtCantidadPasajeros.Text = "";
            TxtCatidadCarga.Text = "";
            CbAerolinea.Text = "";
        }

        public async Task CargarCombo(List<Aereolinea> aereolineas)
        {
            foreach (var item in aereolineas)
            {
                CbAerolinea.Items.Add(item.Nombre);
            }
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
            if (TxtId.Text.Length > 49 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtModelo.Focus();
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

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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

            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtCatidadCarga.Focus();
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtId.Text.Length > 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtNombre.Focus();
            }
        }

        private void TxtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtId.Text.Length > 19 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtFabricante.Focus();
            }
        }

        private void TxtFabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtId.Text.Length > 39 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtVelocidad.Focus();
            }
        }
    }
}
