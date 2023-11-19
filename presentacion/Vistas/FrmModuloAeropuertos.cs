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
    public partial class FrmModuloAeropuertos : Form
    {
        private FrmPrincipal principal;
        private AereopuertoService aereopuertoService = new AereopuertoService();

        public FrmModuloAeropuertos(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private async void FrmModuloAeropuertos_Load(object sender, EventArgs e)
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

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAeropuertos.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el aeropuerto: {DgvAeropuertos.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var loading = CrearLoading();
                try
                {
                    loading.ShowLoading(loading);
                    var response = await aereopuertoService.EliminarPorId($"{DgvAeropuertos.CurrentRow.Cells[0].Value}");

                    if (response != "Error en la solicitud Delete")
                    {
                        await CargarDatos();
                        loading.HideLoading();
                        MessageBox.Show("Se ha eliminado correctamente el aereopuerto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        loading.HideLoading();
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    loading.HideLoading();
                    MessageBox.Show($"Error al eliminar el aereopuerto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvAeropuertos.CurrentRow == null) return;
            await Task.Delay(190);

            var aereopuerto = await aereopuertoService.ObtenerPorId($"{DgvAeropuertos.CurrentRow.Cells[0].Value}");
            FrmEditarAereopuerto vista = new FrmEditarAereopuerto(principal, aereopuerto);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmAgregarAereopuerto vista = new FrmAgregarAereopuerto(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnGestionPaises_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmPaises vista = new FrmPaises(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnGestionRegiones_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmRegiones vista = new FrmRegiones(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnGestionCiudades_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmCiudades vista = new FrmCiudades(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }


        private async Task CargarDatos()
        {
            
                CargarGrilla(await aereopuertoService.ObtenerTodos());
                ConfigurarBotones();
                
        }

        private void ConfigurarBotones()
        {
            if (DgvAeropuertos.RowCount == 0)
            {
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
            }
            else
            {
                BtnEliminar.Enabled = true;
                BtnEditar.Enabled = true;
            }
        }

        private void CargarGrilla(List<Aereopuerto> aeropuertos)
        {
            try
            {
                DgvAeropuertos.Rows.Clear();
                foreach (var item in aeropuertos)
                {
                    DgvAeropuertos.Rows.Add(item.IdAereopuerto, item.Nombre, item.Coordenadas.Latitud, item.Coordenadas.Longitud, item.Ciudad.Nombre, item.FechaRegistro.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
