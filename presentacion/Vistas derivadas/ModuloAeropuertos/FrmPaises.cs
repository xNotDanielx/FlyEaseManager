using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BLL.Servicios;
using Entity;
using Entity.Utilidades;

namespace WindowsFormsApp1
{
    public partial class FrmPaises : Form
    {
        private FrmPrincipal principal;
        private PaisService paisService = new PaisService();
        public FrmPaises(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void FrmPaises_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private void DgvPaises_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvPaises.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            IrAModuloAereopuertos();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvPaises.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el país: {DgvPaises.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var response = await paisService.EliminarPorId(DgvPaises.CurrentRow.Cells[0].Value.ToString());

                    if (response != "Error en la solicitud Delete")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha eliminado correctamente el país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el país: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvPaises.CurrentRow == null) return;

            string nombre = TxtNombre.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre))
            {
                MessageBox.Show("El nombre del país no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar el país: {DgvPaises.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var pais = new Pais
                    {
                        IdPais = Convert.ToInt32(DgvPaises.CurrentRow.Cells[0].Value),
                        Nombre = nombre,
                        FechaRegistro = DateTime.Parse(DgvPaises.CurrentRow.Cells[2].Value.ToString())
                    };

                    var response = await paisService.Actualizar(DgvPaises.CurrentRow.Cells[0].Value.ToString(), pais);

                    if (response != "Error en la solicitud Put")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente el país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el país: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre))
            {
                MessageBox.Show("El nombre del país no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var pais = new Pais
                {
                    Nombre = nombre
                };

                var response = await paisService.Crear(pais);

                if (response != "Error en la solicitud Post")
                {
                    await CargarDatos();
                    limpiarCampos();
                    MessageBox.Show("Se creado correctamente el país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el país: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IrAModuloAereopuertos()
        {
            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
            this.Close();
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
                var lista = await paisService.ObtenerTodos();
                CargarGrilla(lista);
                ConfigurarBotones();
                TxtNombre.ShortcutsEnabled = false;
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void ConfigurarBotones()
        {
            if (DgvPaises.RowCount == 0)
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

        private void CargarGrilla(List<Pais> paises)
        {
            try
            {           
                DgvPaises.Rows.Clear();
                foreach (var item in paises)
                {
                    DgvPaises.Rows.Add(item.IdPais, item.Nombre, item.FechaRegistro.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtNombre.Text.Length > 59 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
