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

namespace WindowsFormsApp1
{
    public partial class FrmEditarAereopuerto : Form
    {
        private FrmPrincipal principal;
        private Aereopuerto aeropuerto;
        private CiudadService ciudadService = new CiudadService();
        private AereopuertoService aereopuertoService = new AereopuertoService();
        public FrmEditarAereopuerto(FrmPrincipal principal, Aereopuerto aereopuerto)
        {
            this.principal = principal;
            InitializeComponent();
            this.aeropuerto = aereopuerto;
        }

        private async void FrmEditarAereopuerto_Load(object sender, EventArgs e)
        {
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                await CargarDatos();
                TxtNombre.Focus();
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
                CargarCombo(await ciudadService.ObtenerTodos());
                CargarCampos(this.aeropuerto);
                TxtNombre.ShortcutsEnabled = false;
                TxtLongitud.ShortcutsEnabled = false;
                TxtLatitud.ShortcutsEnabled = false;
                
            
        }

        private void CargarCampos(Aereopuerto aeropuerto)
        {
            TxtNombre.Text = aeropuerto.Nombre;
            TxtLatitud.Text = aeropuerto.Coordenadas.Latitud.ToString();
            TxtLongitud.Text = aeropuerto.Coordenadas.Longitud.ToString();
            CbCiudades.Text = aeropuerto.Ciudad.Nombre.ToString();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string latitud = TxtLatitud.Text.Trim();
            string longitud = TxtLongitud.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre) || Validacion.EsNuloOVacio(latitud) || Validacion.EsNuloOVacio(longitud))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.Parse(latitud) < -90 || double.Parse(latitud) > 90)
            {
                MessageBox.Show("La latitud debe estar entre -90 y 90.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.Parse(longitud) < -90 || double.Parse(longitud) > 90)
            {
                MessageBox.Show("La longitud debe estar entre -90 y 90.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loading = CrearLoading();

            try
            {
                loading.ShowLoading(loading);
                var obtenerCiudad = await ciudadService.ObtenerTodos();

                Coordenadas coordenada = new Coordenadas
                {
                    Latitud = double.Parse(latitud),
                    Longitud = double.Parse(longitud)
                };

                Aereopuerto aeropuerto = new Aereopuerto
                {
                    IdAereopuerto = this.aeropuerto.IdAereopuerto,
                    Nombre = nombre,
                    Coordenadas = coordenada,
                    Ciudad = obtenerCiudad.Where(p => p.Nombre == CbCiudades.Text).FirstOrDefault(),
                    FechaRegistro = this.aeropuerto.FechaRegistro
                };

                var response = await aereopuertoService.Actualizar(this.aeropuerto.IdAereopuerto.ToString(), aeropuerto);

                if (response != "Error en la solicitud Put")
                {
                    loading.HideLoading();
                    limpiarCampos();
                    MessageBox.Show("Se ha actualizado correctamente el aeropuerto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Error al actualizar el aeropuerto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombo(List<Ciudad> ciudades)
        {
            foreach (var item in ciudades)
            {
                CbCiudades.Items.Add(item.Nombre);
            }
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtLatitud.Text = "";
            TxtLongitud.Text = "";
            CbCiudades.Text = "";
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtNombre.Text.Length > 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtLatitud.Focus();
            }
        }

        private void TxtLatitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtLongitud.Focus();
            }
        }

        private void TxtLongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
