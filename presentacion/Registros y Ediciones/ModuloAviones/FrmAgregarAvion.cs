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

        private void FrmAgregarAvion_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        async void CargarCombo()
        {
            CbAerolinea.DataSource = await aereolineaService.ObtenerTodos();
            CbAerolinea.DisplayMember = "Nombre";
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtModelo.Text = "";
            TxtFabricante.Text = "";
            TxtVelocidad.Text = "";
            TxtCatidadCarga.Text = "";
            CbAerolinea.Text = "";
            TxtCantidadAsietos.Text = "";
            TxtAsientosPremium.Text = "";
            TxtAsientosEconomicos.Text = "";
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

                var response = await avionService.Crear(avion);
                avionActual = avion;

                if (response != "Error en la solicitud Post")
                {
                    await GuardarAsientos();
                    limpiarCampos();
                    MessageBox.Show("Se ha creado correctamente el avión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el avión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GuardarAsientos()
        {
            try
            {
                var categorias = await categoriaService.ObtenerTodos();
                int contadorGeneral = 1;

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

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void TxtCatidadCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
    }
}
