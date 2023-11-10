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
        private async void FrmRegiones_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private void DgvPaises_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvRegiones.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
            CbPaises.Text = fila.Cells[2].Value.ToString();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            IrAModuloAereopuertos();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvRegiones.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la region: {DgvRegiones.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var response = await regionService.EliminarPorId($"{DgvRegiones.CurrentRow.Cells[0].Value}");

                    if (response != "Error en la solicitud Delete: ")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha eliminado correctamente la region", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la region: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvRegiones.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar la región: {DgvRegiones.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var paises = await new PaisService().ObtenerTodos();
                    var pais = paises.Where(p => p.Nombre == CbPaises.Text).FirstOrDefault();

                    Region region = new Region
                    {
                        IdRegion = Convert.ToInt32(DgvRegiones.CurrentRow.Cells[0].Value.ToString()),
                        Nombre = TxtNombre.Text,
                        Pais = pais,
                        FechaRegistro = DgvRegiones.CurrentRow.Cells[3].Value.ToString()
                    };

                    var response = await regionService.Actualizar(DgvRegiones.CurrentRow.Cells[0].Value.ToString(), region);

                    if (response != "Error en la solicitud Put: ")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente la region", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la region: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var obtenerPais = await new PaisService().ObtenerTodos();

                Region region = new Region
                {
                    Nombre = TxtNombre.Text,
                    Pais = obtenerPais.Where(P => P.Nombre == CbPaises.Text).FirstOrDefault(),
                };

                var response = await regionService.Crear(region);

                if (response != "Error en la solicitud Post: ")
                {
                    await CargarDatos();
                    limpiarCampos();
                    MessageBox.Show("Se creado correctamente la region", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la region: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IrAModuloAereopuertos()
        {
            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async Task CargarDatos()
        {
            CargarGrilla(await regionService.ObtenerTodos());
            CargarCombo(await new PaisService().ObtenerTodos());
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            if (DgvRegiones.RowCount == 0)
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

        private void CargarGrilla(List<Region> regiones)
        {
            DgvRegiones.Rows.Clear();
            foreach (var item in regiones)
            {
                DgvRegiones.Rows.Add(item.IdRegion, item.Nombre, item.Pais.Nombre, item.FechaRegistro);
            }
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
        }

        private void CargarCombo(List<Pais> paises)
        {
            CbPaises.DataSource = paises;
            CbPaises.DisplayMember = "Nombre";
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
