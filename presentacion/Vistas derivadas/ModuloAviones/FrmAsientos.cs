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
    public partial class FrmAsientos : Form
    {
        private FrmPrincipal principal;
        private AsientoService asientoService = new AsientoService();
        private CategoriaService categoriaService = new CategoriaService();
        private AvionService avionService = new AvionService();
        public FrmAsientos(FrmPrincipal principal)
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

        private async void FrmAsientos_Load(object sender, EventArgs e)
        {
            CargarGrilla(await asientoService.ObtenerTodos());
            CargarCombos();
        }

        void CargarGrilla(List<Asiento> asientos)
        {
            var disponibilidad = "";
            DgvAsientos.Rows.Clear();
            foreach (var item in asientos)
            {
                if (item.Disponibilidad == true)
                {
                    disponibilidad = "Activo";
                }
                else
                {
                    disponibilidad = "Inactivo";
                }
                DgvAsientos.Rows.Add(item.IdAsiento, item.Posicion, disponibilidad, item.Categoria.Nombre, item.Avion.Nombre, item.FechaRegistro);
            }
        }

        async void CargarCombos()
        {
            //Categorias
            CbCategorias.DataSource = await categoriaService.ObtenerTodos();
            CbCategorias.DisplayMember = "Nombre";

            //Aviones
            CbAviones.DataSource = await avionService.ObtenerTodos();
            CbAviones.DisplayMember = "Nombre";
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            var obtenerCategoria = await categoriaService.ObtenerTodos();
            var obtenerAvion = await avionService.ObtenerTodos();
            Asiento asiento = new Asiento
            {
                Posicion = int.Parse(TxtPosicion.Text),
                Disponibilidad = ChkDisponibilidad.Checked,
                Categoria = obtenerCategoria.Where(p=>p.Nombre == CbCategorias.Text).FirstOrDefault(),
                Avion = obtenerAvion.Where(p=>p.Nombre == CbAviones.Text).FirstOrDefault(),
            };
        }

        private void DgvAsientos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvAsientos.Rows[e.RowIndex];
            TxtPosicion.Text = fila.Cells[1].Value.ToString();
            if (fila.Cells[2].Value.ToString() == "True")
            {
                ChkDisponibilidad.Checked = true;
            }
            else
            {
                ChkDisponibilidad.Checked = false;
            }
            CbCategorias.Text = fila.Cells[3].Value.ToString();
            CbAviones.Text = fila.Cells[4].Value.ToString();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Toca editar el mensaje enviado al usuario
            if (DgvAsientos.CurrentRow == null) return;
            var obtenerCategoria = await categoriaService.ObtenerTodos();
            var obtenerAvion = await avionService.ObtenerTodos();
            Asiento asiento = new Asiento
            {
                IdAsiento = Convert.ToInt32(DgvAsientos.CurrentRow.Cells[0].Value.ToString()),
                Posicion = int.Parse(TxtPosicion.Text),
                Disponibilidad = ChkDisponibilidad.Checked,
                Categoria = obtenerCategoria.Where(p => p.Nombre == CbCategorias.Text).FirstOrDefault(),
                Avion = obtenerAvion.Where(p => p.Nombre == CbAviones.Text).FirstOrDefault(),
                FechaRegistro = DgvAsientos.CurrentRow.Cells[5].Value.ToString()
            };

            var response = await asientoService.Actualizar(DgvAsientos.CurrentRow.Cells[0].Value.ToString(), asiento);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var lista = await asientoService.ObtenerTodos();
            CargarGrilla(lista);
            limpiarCampos();
        }

        void limpiarCampos()
        {
            TxtPosicion.Text = "";
            ChkDisponibilidad.Checked = true;
            CbCategorias.Text = "";
            CbAviones.Text = "";
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAsientos.CurrentRow == null) return;
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el asiento?: {DgvAsientos.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(resultado == DialogResult.OK)
            {
                var response = await asientoService.EliminarPorId($"{DgvAsientos.CurrentRow.Cells[0].Value}");
                var lista = await asientoService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
        }

        private void TxtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }    
}
