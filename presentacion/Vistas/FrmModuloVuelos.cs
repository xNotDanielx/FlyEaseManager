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

        }

        private async void FrmModuloVuelos_Load(object sender, EventArgs e)
        {
            var lista = await vueloService.ObtenerTodos();
            //CargarGrilla(lista);
            ConfigurarBotones();
        }

        void ConfigurarBotones()
        {
            if (DgvVuelos.RowCount == 1) // igual a 1 porque hay una fila vacia, poner 0 si se elimina esa linea
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

        void CargarGrilla(List<Vuelo> vuelos)
        {
            DgvVuelos.Rows.Clear();
            foreach (var item in vuelos)
            {
                DgvVuelos.Rows.Add(item.IdVuelo, item.PrecioVuelo, item.TarifaTemporada, item.Descuento, item.DistanciaRecorrida, 
                    item.FechaYHoraDespegue, item.FechaYHoraLlegada, item.Cupo, item.ADespegue.Nombre, item.ADestino.Nombre, 
                    item.Estado.Nombre, item.Avion.Nombre, item.FechaRegistro);
            }
        }

        private async void BtnEditarVuelo_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            // Verifica si hay al menos una fila seleccionada
            if (DgvVuelos.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = DgvVuelos.SelectedRows[0]; // Obtenemos la primera fila seleccionada


                string valorCelda = filaSeleccionada.Cells[0].Value.ToString();

                FrmEditarVuelos vista = new FrmEditarVuelos(principal, valorCelda);
                vista.Dock = DockStyle.Fill;
                principal.OpenForms(vista);
            }
            else
            {
                return;
            }
        }

        private async void BtnGestionEstado_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            FrmEstados vista = new FrmEstados(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
        }

        private async void BtnEliminarVuelo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el vuelo: {DgvVuelos.CurrentRow.Cells[0].Value}?\nSe eliminaran todos los boletos asociados!", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var response = await vueloService.EliminarPorId($"{DgvVuelos.CurrentRow.Cells[0].Value}");
                var lista = await vueloService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response);
                ConfigurarBotones();
            }
        }
    }
}
