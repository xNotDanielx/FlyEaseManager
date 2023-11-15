using BLL.Servicios;
using Entity;
using Entity.Utilidades;
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
            await CargarDatos();
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

        }

        private async Task ActualizarPasajerosAvion(Avion avion)
        {
            int cantidadAsientos = 0;

            var asientos = await asientoService.ObtenerTodos();
            foreach (var item in asientos)
            {
                if (item.Avion.IdAvion == avion.IdAvion)
                {
                    cantidadAsientos++;
                }
            }

            avion.CantidadPasajeros = cantidadAsientos;

            await avionService.Actualizar(avion.IdAvion, avion);
        }

        private async Task CargarDatos()
        {
            CargarGrilla(await asientoService.ObtenerTodos());
            CargarCombos();
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            if (DgvAsientos.RowCount == 0)
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

        private void DgvAsientos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvAsientos.Rows[e.RowIndex];
            if (fila.Cells[2].Value.ToString() == "Activo")
            {
                ChkDisponibilidad.Checked = true;
            }
            else
            {
                ChkDisponibilidad.Checked = false;
            }
            CbCategorias.Text = fila.Cells[3].Value.ToString();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvAsientos.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar el asiento de id: {DgvAsientos.CurrentRow.Cells[0].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var obtenerCategoria = await categoriaService.ObtenerTodos();

                    var aviones = await avionService.ObtenerTodos();
                    var avion = aviones.Where(p => p.Nombre == DgvAsientos.CurrentRow.Cells[4].Value.ToString()).FirstOrDefault();

                    Asiento asiento = new Asiento
                    {
                        IdAsiento = Convert.ToInt32(DgvAsientos.CurrentRow.Cells[0].Value.ToString()),
                        Posicion = int.Parse(DgvAsientos.CurrentRow.Cells[1].Value.ToString()),
                        Disponibilidad = ChkDisponibilidad.Checked,
                        Categoria = obtenerCategoria.Where(p => p.Nombre == CbCategorias.Text).FirstOrDefault(),
                        Avion = avion,
                        FechaRegistro = DgvAsientos.CurrentRow.Cells[5].Value.ToString()
                    };

                    var response = await asientoService.Actualizar(DgvAsientos.CurrentRow.Cells[0].Value.ToString(), asiento);

                    if (response != "Error en la solicitud Put")
                    {
                        await CargarDatos();
                        await ActualizarPasajerosAvion(avion);
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente el asiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el asiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiarCampos()
        {
            ChkDisponibilidad.Checked = true;
            CbCategorias.Text = "";
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAsientos.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el asiento? Se elminará el último asiento del avión {DgvAsientos.CurrentRow.Cells[4].Value}", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            try
            {
                if (resultado == DialogResult.OK)
                {
                    var aviones = await avionService.ObtenerTodos();
                    var avion = aviones.Where(p => p.Nombre == DgvAsientos.CurrentRow.Cells[4].Value.ToString()).FirstOrDefault();
                    var asientos = await asientoService.ObtenerTodos();
                    var asientosFiltrados = asientos.Where(item => item.Avion.Nombre.Equals(avion.Nombre)).ToList();
                    var asiento = asientosFiltrados.Where(item => item.Posicion == asientosFiltrados.Count()).FirstOrDefault();
                    var response = await asientoService.EliminarPorId(asiento.IdAsiento.ToString());

                    if (response != "Error en la solicitud Delete")
                    {
                        await CargarDatos();
                        await ActualizarPasajerosAvion(avion);
                        limpiarCampos();
                        MessageBox.Show("Se ha aliminado correctamente el asiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el asiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }    
}
