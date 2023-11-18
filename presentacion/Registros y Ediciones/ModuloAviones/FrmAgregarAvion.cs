using BLL.Servicios;
using Entity;
using Entity.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAgregarAvion : Form
    {
        private FrmPrincipal principal;
        private AereolineaService aereolineaService = new AereolineaService();
        private AvionService avionService = new AvionService();
        private CategoriaService categoriaService = new CategoriaService();
        private AsientoService asientoService = new AsientoService();
        private Avion avionActual = null;

        public FrmAgregarAvion(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private async void FrmAgregarAvion_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }

        private async Task CargarDatos()
        {
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                await CargarCombo();
                TxtId.ShortcutsEnabled = false;
                TxtNombre.ShortcutsEnabled = false;
                TxtModelo.ShortcutsEnabled = false;
                TxtFabricante.ShortcutsEnabled = false;
                TxtVelocidad.ShortcutsEnabled = false;
                TxtCatidadCarga.ShortcutsEnabled = false;
                TxtCantidadAsietos.ShortcutsEnabled = false;
                TxtAsientosPremium.ShortcutsEnabled = false;
                TxtAsientosEconomicos.ShortcutsEnabled = false;
                txtAsientosNoComerciales.ShortcutsEnabled = false;
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private async Task CargarCombo()
        {
            CbAerolinea.DataSource = await aereolineaService.ObtenerTodos();
            CbAerolinea.DisplayMember = "Nombre";
        }

        private void limpiarCampos()
        {
            TxtId.Text = "";
            TxtNombre.Text = "";
            TxtModelo.Text = "";
            TxtFabricante.Text = "";
            TxtVelocidad.Text = "";
            TxtCatidadCarga.Text = "";
            CbAerolinea.Text = "";
            TxtCantidadAsietos.Text = "";
            TxtAsientosPremium.Text = "";
            TxtAsientosEconomicos.Text = "";
            txtAsientosNoComerciales.Text = "";
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAviones vista = new FrmModuloAviones(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            string idAvion = TxtId.Text.Trim();
            string nombre = TxtNombre.Text.Trim();
            string modelo = TxtModelo.Text.Trim();
            string fabricante = TxtFabricante.Text.Trim();
            string velocidadPromedio = TxtVelocidad.Text.Trim();
            string cantidadCarga = TxtCatidadCarga.Text.Trim();
            string cantidadAsientos = TxtCantidadAsietos.Text.Trim();
            string asientosPremium = TxtAsientosPremium.Text.Trim();
            string asientosEconomicos = TxtAsientosEconomicos.Text.Trim();

            if (Validacion.EsNuloOVacio(idAvion) || Validacion.EsNuloOVacio(nombre) || Validacion.EsNuloOVacio(modelo) || Validacion.EsNuloOVacio(fabricante) || Validacion.EsNuloOVacio(velocidadPromedio) || Validacion.EsNuloOVacio(cantidadCarga) || Validacion.EsNuloOVacio(cantidadAsientos) || Validacion.EsNuloOVacio(asientosPremium) || Validacion.EsNuloOVacio(asientosEconomicos))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((int.Parse(asientosPremium) + int.Parse(asientosEconomicos)) > int.Parse(cantidadAsientos) )
            {
                MessageBox.Show("La suma de asientos premium y económicos no puede ser mayor a la cantidad de asientos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCantidadAsietos.Focus();
                return;
            }

            var loading = CrearLoading();

            try
            {
                var obtenerAerolinea = await aereolineaService.ObtenerTodos();
                Avion avion = new Avion
                {
                    IdAvion = TxtId.Text,
                    Nombre = TxtNombre.Text,
                    Modelo = TxtModelo.Text,
                    Fabricante = TxtFabricante.Text,
                    VelocidadPromedio = double.Parse(TxtVelocidad.Text),
                    CantidadPasajeros = int.Parse(TxtCantidadAsietos.Text),
                    CantidadCarga = double.Parse(TxtCatidadCarga.Text),
                    Aereolinea = obtenerAerolinea.Where(x => x.Nombre == CbAerolinea.Text).FirstOrDefault(),
                };

                
                loading.ShowLoading(loading);
                var response = await avionService.Crear(avion);
                avionActual = avion;

                if (response != "Error en la solicitud Post")
                {
                    await GuardarAsientos();
                    loading.HideLoading();
                    limpiarCampos();
                    MessageBox.Show("Se ha creado correctamente el avión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Error al crear el avión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GuardarAsientos()
        {
            try
            {
                var categorias = await categoriaService.ObtenerTodos();
                int contadorGeneral = 1;

                contadorGeneral = await CrearAsientos("No comercial", int.Parse(txtAsientosNoComerciales.Text), true, avionActual, categorias, contadorGeneral);
                contadorGeneral = await CrearAsientos("Primera clase", int.Parse(TxtAsientosPremium.Text), true, avionActual, categorias, contadorGeneral);
                contadorGeneral = await CrearAsientos("Turista", int.Parse(TxtAsientosEconomicos.Text), true, avionActual, categorias, contadorGeneral);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear los asientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<int> CrearAsientos(string categoriaNombre, int cantidad, bool disponibilidad, Avion avion, List<Categoria> categorias, int contador)
        {
            var categoria = categorias.FirstOrDefault(c => c.Nombre == categoriaNombre);

            if (categoria != null)
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    Asiento asiento = new Asiento
                    {
                        Posicion = contador++,
                        Disponibilidad = disponibilidad,
                        Categoria = categoria,
                        Avion = avion
                    };

                    await asientoService.Crear(asiento);
                }
            }

            return contador;
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

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtCatidadCarga.Focus();
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
                TxtCantidadAsietos.Focus();
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

        private void TxtCantidadAsietos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtAsientosPremium.Focus();
            }
        }

        private void TxtAsientosPremium_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtAsientosEconomicos.Focus();
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
