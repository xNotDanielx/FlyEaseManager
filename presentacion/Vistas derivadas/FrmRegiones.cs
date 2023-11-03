using BLL.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using System.CodeDom;

namespace WindowsFormsApp1
{
    public partial class FrmRegiones : Form
    {
        private FrmPrincipal principal;
        private RegionService regionService = new RegionService();
        public FrmRegiones(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
        }

        private async void FrmRegiones_Load(object sender, EventArgs e)
        {
            CargarGrilla(await new RegionService().ObtenerTodos());

            CargarCombo(await new PaisService().ObtenerTodos());
            ConfigurarBotones();
        }

        void ConfigurarBotones()
        {
            if (DgvRegiones.RowCount == 1) // igual a 1 porque hay una fila vacia, poner 0 si se elimina esa linea
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

        void CargarGrilla(List<Region> regiones)
        {
            DgvRegiones.Rows.Clear();
            foreach (var item in regiones)
            {
                DgvRegiones.Rows.Add(item.IdRegion, item.Nombre, item.Pais.Nombre, item.FechaRegistro);
            }
        }

        void CargarCombo(List<Pais> paises)
        {
                CbPaises.DataSource = paises;
                CbPaises.DisplayMember = "Nombre";
        }

        private void DgvPaises_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var fila = DgvRegiones.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString(); // Hay que quitar la fila que sale vacia para que no de error por fila nula
            CbPaises.Text = fila.Cells[2].Value.ToString();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            //RegionService service = new RegionService();
            //Region region = new Region
            //{ 
            //Nombre = TxtNombre.Text;
            //Pais.Nombre = CbPaises.Text;
            //};
            
            var ObtenerPais = await new PaisService().ObtenerTodos();
            var pais = ObtenerPais.Where(p => p.Nombre == CbPaises.Text).FirstOrDefault();
            RegionService regionService = new RegionService();
            Region region = new Region
            {
                IdRegion = Convert.ToInt32(DgvRegiones.CurrentRow.Cells[0].Value.ToString()),
                Nombre = TxtNombre.Text,
                Pais = pais,
                FechaRegistro = DgvRegiones.CurrentRow.Cells[3].Value.ToString()
            };
            var response = await regionService.Actualizar(DgvRegiones.CurrentRow.Cells[0].Value.ToString(), region);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Se actualiza la lista
            var lista = await regionService.ObtenerTodos();
            CargarGrilla(lista);
            ConfigurarBotones();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la region: {DgvRegiones.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var response = await regionService.EliminarPorId($"{DgvRegiones.CurrentRow.Cells[0].Value}");
                var lista = await regionService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response);
                ConfigurarBotones();
            }
        }

    }
}
