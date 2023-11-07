using BLL.Servicios;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCiudades : Form
    {
        private FrmPrincipal principal;
        private CiudadService ciudadService = new CiudadService();
        public FrmCiudades(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
        }

        void CargarCombo(List<Region> regiones)
        {
            CbRegiones.DataSource = regiones;
            CbRegiones.DisplayMember = "Nombre";
        }

        private void DgvCiudades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1) return;
            var fila = DgvCiudades.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
            CbRegiones.Text = fila.Cells[2].Value.ToString();
        }

        private async void FrmCiudades_Load(object sender, EventArgs e)
        { 
            CargarCombo(await new RegionService().ObtenerTodos());
            CargarGrilla(await new CiudadService().ObtenerTodos());
            ConfigurarBotones();
        }

        void CargarGrilla(List<Ciudad> ciudades)
        {
            DgvCiudades.Rows.Clear();
            foreach (var item in ciudades)
            {
                DgvCiudades.Rows.Add(item.IdCiudad, item.Nombre, item.Region.Nombre, item.FechaRegistro);
            }
        }

        void ConfigurarBotones()
        {
            if (DgvCiudades.RowCount == 0) // igual a 1 porque hay una fila vacia, poner 0 si se elimina esa linea
            {
                BtnEliminar.Enabled = false;
                BtnActualizar.Enabled = false;
            }
            else
            {
                BtnEliminar.Enabled = true;
                BtnActualizar.Enabled = true;
            }
        }

        void limpiarCampos()
        {
            TxtNombre.Text = "";
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            var obtenerRegion = await new RegionService().ObtenerTodos();
            Ciudad ciudad = new Ciudad()
            {
                Nombre = TxtNombre.Text,
                Region = obtenerRegion.Where(x => x.Nombre == CbRegiones.Text).FirstOrDefault()
            };
            var response = await ciudadService.Crear(ciudad);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var lista = await ciudadService.ObtenerTodos();
            CargarGrilla(lista);
            limpiarCampos();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Toca editar el mensaje enviado al usuario
            if (DgvCiudades.SelectedCells.Count > 0)
            {
                var obtenerRegion = await new RegionService().ObtenerTodos();
                var region = obtenerRegion.Where(p => p.Nombre == CbRegiones.Text).FirstOrDefault();
                Ciudad ciudad = new Ciudad
                {
                    IdCiudad = Convert.ToInt32(DgvCiudades.CurrentRow.Cells[0].Value.ToString()),
                    Nombre = TxtNombre.Text,
                    Region = region,
                    FechaRegistro = DgvCiudades.CurrentRow.Cells[3].Value.ToString()
                };
                var response = await ciudadService.Actualizar(DgvCiudades.CurrentRow.Cells[0].Value.ToString(), ciudad);

                MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var lista = await ciudadService.ObtenerTodos();
                CargarGrilla(lista);
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvCiudades.CurrentRow == null) return;
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la ciudad: {DgvCiudades.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var response = await ciudadService.EliminarPorId($"{DgvCiudades.CurrentRow.Cells[0].Value}");
                var lista = await ciudadService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response);
                ConfigurarBotones();
            }
        }
    }
}
