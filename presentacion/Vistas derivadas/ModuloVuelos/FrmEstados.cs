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
    public partial class FrmEstados : Form
    {
        private FrmPrincipal principal;
        private EstadoService estadoService = new EstadoService();
        public FrmEstados(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloVuelos vista = new FrmModuloVuelos(principal);
            principal.OpenForms(vista);
        }

        private async void FrmEstados_Load(object sender, EventArgs e)
        {
            CargarGrilla(await new EstadoService().ObtenerTodos());
        }

        void CargarGrilla(List<Estado> estados)
        {
            DgvEstados.Rows.Clear();
            foreach (var item in estados)
            {
                DgvEstados.Rows.Add(item.IdEstado, item.Nombre, item.Descripcion, item.Detencion, item.FechaRegistro);
            }
        }

        private void DgvEstados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvEstados.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString(); 
            TxtDescripcion.Text = fila.Cells[2].Value.ToString();
            if (fila.Cells[3].Value.ToString() == "True")
            {
                RbDetencion.Checked = true;
            }
            else
            {
                RbDetencion.Checked = false;
            } 
        }

        void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            RbDetencion.Checked = true;
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado
            {
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                Detencion = RbDetencion.Checked
            };

            var response = await estadoService.Crear(estado);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var lista = await estadoService.ObtenerTodos();
            CargarGrilla(lista);
            limpiarCampos();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvEstados.CurrentRow == null) return;
            Estado estado = new Estado
            {
                IdEstado = Convert.ToInt32(DgvEstados.CurrentRow.Cells[0].Value.ToString()),
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                Detencion = RbDetencion.Checked,
                FechaRegistro = DgvEstados.CurrentRow.Cells[4].Value.ToString()
            };
            var response = await estadoService.Actualizar(DgvEstados.CurrentRow.Cells[0].Value.ToString(), estado);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var lista = await estadoService.ObtenerTodos();
            CargarGrilla(lista);
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvEstados.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el estado: {DgvEstados.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var response = await estadoService.EliminarPorId($"{DgvEstados.CurrentRow.Cells[0].Value}");
                var lista = await estadoService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response);
            }
        }
    }
}
