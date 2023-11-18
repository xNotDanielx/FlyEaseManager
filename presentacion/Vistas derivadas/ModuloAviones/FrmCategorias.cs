using BLL.Servicios;
using Entity;
using Entity.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            await CargarDatos();
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }

        private async Task CargarDatos()
        {
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                CargarGrilla(await categoriaService.ObtenerTodos());
                TxtDescripcion.ShortcutsEnabled = false;
                TxtTarifa.ShortcutsEnabled = false;
                TxtNombre.Enabled = false;
                TxtNombre.BackColor = Color.White;
                TxtNombre.ForeColor = Color.Black;
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
}

        void CargarGrilla(List<Categoria> categorias)
        {
            var estado = "";
            var categoria = "";
            try
            {
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

                    if (item.Comercial == true)
                    {
                        categoria = "Sí";
                    }
                    else
                    {
                        categoria = "No";
                    }

                    DgvCategorias.Rows.Add(item.IdCategoria, item.Nombre, item.Descripcion, estado, item.Tarifa, categoria,  item.FechaRegistro.ToString());
                }
            }
            catch (Exception ex)
            {
                return;
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

            string nombre = TxtNombre.Text.Trim();
            string descripcion = TxtDescripcion.Text.Trim();
            string tarifa = TxtTarifa.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre) || Validacion.EsNuloOVacio(descripcion) || Validacion.EsNuloOVacio(tarifa))
            {
                MessageBox.Show("No pueden quedar campos vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar categoria: {DgvCategorias.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    Categoria categoria = new Categoria
                    {
                        IdCategoria = int.Parse(DgvCategorias.CurrentRow.Cells[0].Value.ToString()),
                        Nombre = nombre,
                        Descripcion = descripcion,
                        EstadoCategoria = ChkEstado.Checked,
                        Tarifa = double.Parse(tarifa),
                        FechaRegistro = DateTime.Parse(DgvCategorias.CurrentRow.Cells[6].Value.ToString()),
                    };

                    var response = await categoriaService.Actualizar(DgvCategorias.CurrentRow.Cells[0].Value.ToString(), categoria);

                    if (response != "Error en la solicitud Put")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente la categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show($"Error al actualizar la categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
            if (TxtNombre.Text.Length > 199 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
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
