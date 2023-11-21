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
    public partial class FrmModuloVuelos : Form
    {

        private FrmPrincipal principal;
        private VueloService vueloService = new VueloService();
        private AsientoService asientoService = new AsientoService();
        public FrmModuloVuelos(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnAgregarVuelo_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmAgregarVuelos vista = new FrmAgregarVuelos(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void FrmModuloVuelos_Load(object sender, EventArgs e)
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

        private void ConfigurarBotones()
        {
            if (DgvVuelos.RowCount == 0)
            {
                BtnEliminarVuelo.Enabled = false;
                BtnEditarVuelo.Enabled = false;
            }
            else
            {
                BtnEliminarVuelo.Enabled = true;
                BtnEditarVuelo.Enabled = true;
            }
        }

        private void CargarGrilla(List<Vuelo> vuelos)
        {
            try
            { 
                DgvVuelos.Rows.Clear();
                foreach (var item in vuelos)
                {
                    DgvVuelos.Rows.Add(item.IdVuelo.ToString(), item.PrecioVuelo.ToString(), item.TarifaTemporada.ToString(), item.Descuento.ToString(), item.DistanciaRecorrida.ToString(),
                        item.FechaYHoraDeSalida.ToString(), item.FechaYHoraLlegada.ToString(), item.aeropuerto_Despegue.Nombre, item.aeropuerto_Destino.Nombre, item.CupoToString(),
                        item.Estado.Nombre, item.Avion.Nombre, item.FechaRegistro.ToString());
                }
                
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void BtnEditarVuelo_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            if (DgvVuelos.CurrentRow == null) return;

            try
            {


                var vuelos = await vueloService.ObtenerTodos();
                var vuelo = vuelos.Where(item => item.IdVuelo == int.Parse(DgvVuelos.CurrentRow.Cells[0].Value.ToString())).FirstOrDefault();
                FrmEditarVuelos vista = new FrmEditarVuelos(principal, vuelo);
                vista.Dock = DockStyle.Fill;
                principal.OpenForms(vista);
                this.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void BtnEliminarVuelo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el vuelo: {DgvVuelos.CurrentRow.Cells[0].Value}?\nSe eliminaran todos los boletos asociados!", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var loading = CrearLoading();
                try
                {
                    loading.ShowLoading(loading);
                    var asientos = await asientoService.ObtenerTodos();
                    var vuelos = await vueloService.ObtenerTodos();
                    var vuelo = vuelos.Where(item => item.IdVuelo == int.Parse(DgvVuelos.CurrentRow.Cells[0].Value.ToString())).FirstOrDefault(); 
                    var asientosEliminar = asientos.Where(item => item.Avion.IdAvion == vuelo.Avion.IdAvion);

                    var response = await vueloService.EliminarPorId($"{DgvVuelos.CurrentRow.Cells[0].Value}");

                    if (response != "Error en la solicitud Delete")
                    {
                        foreach (var item in asientosEliminar)
                        {
                            await asientoService.EliminarPorId(item.IdAsiento.ToString());
                        }

                        await CargarDatos();
                        loading.HideLoading();
                        MessageBox.Show("Se ha eliminado correctamente el vuelo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Error al eliminar el vuelo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }

        private async Task CargarDatos()
        {
            
                CargarGrilla(await vueloService.ObtenerTodos());
                ConfigurarBotones();
                
        }

        private async void BtnRegresar_Click(object sender, EventArgs e) // ??
        {
            await Task.Delay(190);

            FrmEstados vista = new FrmEstados(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
