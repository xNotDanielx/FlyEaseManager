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
    public partial class FrmCategorias : Form
    {
        private FrmPrincipal principal;
        private CategoriaService categoriaService = new CategoriaService();
        public FrmCategorias(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAviones vista = new FrmModuloAviones(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async void FrmCategorias_Load(object sender, EventArgs e)
        {
            
            CargarGrilla(await categoriaService.ObtenerTodos());
        }

        void CargarGrilla(List<Categoria> categorias)
        {
            var estado = "";
            DgvCategorias.Rows.Clear();
            foreach (var item in categorias)
            {
                if (item.EstadoCategoria == true)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }

                DgvCategorias.Rows.Add(item.IdCategoria, item.Nombre, item.Descripcion, estado, item.Tarifa,  item.FechaRegistro);
            }
        }

        private void DgvCategorias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvCategorias.Rows[e.RowIndex];

            TxtNombre.Text = fila.Cells[1].Value.ToString();
            TxtDescripcion.Text = fila.Cells[2].Value.ToString();
            TxtTarifa.Text = fila.Cells[4].Value.ToString();

            if (fila.Cells[3].Value.ToString().Equals("Activo"))
            {
                ChkEstado.Checked = true;
            }
            else
            {
                ChkEstado.Checked = false;
            }
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvCategorias.CurrentRow == null) return;
            Categoria categoria = new Categoria
            {
                IdCategoria = int.Parse(DgvCategorias.CurrentRow.Cells[0].Value.ToString()),
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                EstadoCategoria = ChkEstado.Checked,
                Tarifa = double.Parse(TxtTarifa.Text),
                FechaRegistro = DgvCategorias.CurrentRow.Cells[5].Value.ToString(),
            };

            var response = await categoriaService.Actualizar(DgvCategorias.CurrentRow.Cells[0].Value.ToString(), categoria);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var lista = await categoriaService.ObtenerTodos();
            CargarGrilla(lista);
            limpiarCampos();
        }

        void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtTarifa.Text = "";
            ChkEstado.Checked = false;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
