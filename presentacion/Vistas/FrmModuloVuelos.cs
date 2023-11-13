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
            var lista = await vueloService.ObtenerTodos();
            await CargarGrilla(lista);
            ConfigurarBotones();
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

        private async Task CargarGrilla(List<Vuelo> vuelos)
        {
            if (await vueloService.ObtenerTodos() == null)
            {
                return;
            }
            else
            {
                DgvVuelos.Rows.Clear();
                foreach (var item in vuelos)
                {
                    DgvVuelos.Rows.Add(item.IdVuelo, item.PrecioVuelo, item.TarifaTemporada, item.Descuento, item.DistanciaRecorrida,
                        item.FechaYHoraDeSalida, item.FechaYHoraLlegada, item.aereopuerto_Despegue.Nombre, item.aereopuerto_Destino.Nombre,
                        item.Estado.Nombre, item.Avion.Nombre, item.FechaRegistro);
                }
            }            
        }

        private async void BtnEditarVuelo_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            if (DgvVuelos.CurrentRow == null) return;

            var vuelos = await vueloService.ObtenerTodos();
            var vuelo = vuelos.Where(item => item.IdVuelo == int.Parse(DgvVuelos.CurrentRow.Cells[0].Value.ToString())).FirstOrDefault();
            FrmEditarVuelos vista = new FrmEditarVuelos(principal, vuelo);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnEliminarVuelo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el vuelo: {DgvVuelos.CurrentRow.Cells[0].Value}?\nSe eliminaran todos los boletos asociados!", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
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
                        MessageBox.Show("Se ha eliminado correctamente el vuelo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el vuelo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task CargarDatos()
        {
            await CargarGrilla(await vueloService.ObtenerTodos());
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
    }
}
