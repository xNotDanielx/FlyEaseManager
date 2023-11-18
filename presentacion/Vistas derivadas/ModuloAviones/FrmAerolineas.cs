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
    public partial class FrmAerolineas : Form
    {
        private FrmPrincipal principal;
        private AereolineaService AereolineaService = new AereolineaService();
        public FrmAerolineas(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }
        private async void FrmAerolineas_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private void DgvAerolineas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvAerolineas.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
            TxtCodigoIATA.Text = fila.Cells[2].Value.ToString();
            TxtCodigoICAO.Text = fila.Cells[3].Value.ToString();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAviones vista = new FrmModuloAviones(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        void CargarGrilla(List<Aereolinea> aerolineas)
        {
            try
            { 
                DgvAerolineas.Rows.Clear();
                foreach (var item in aerolineas)
                {
                    DgvAerolineas.Rows.Add(item.IdAereolinea, item.Nombre, item.CodigoIATA,item.CodigoICAO, item.FechaRegistro.ToString());
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string codigoIATA = TxtCodigoIATA.Text.Trim();
            string codigoICAO = TxtCodigoICAO.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre) || Validacion.EsNuloOVacio(codigoIATA) || Validacion.EsNuloOVacio(codigoICAO))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Aereolinea aereolinea = new Aereolinea
                {
                    Nombre = nombre,
                    CodigoIATA = codigoIATA,
                    CodigoICAO = codigoICAO,
                };
                var response = await AereolineaService.Crear(aereolinea);

                if (response != "Error en la solicitud Post")
                {
                    await CargarDatos();
                    limpiarCampos();
                    MessageBox.Show("Se ha creado correctamente la aerolinea", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la aerolinea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                var lista = await AereolineaService.ObtenerTodos();
                CargarGrilla(lista);
                ConfigurarBotones();
                TxtNombre.ShortcutsEnabled = false;
                TxtCodigoIATA.ShortcutsEnabled = false;
                TxtCodigoICAO.ShortcutsEnabled = false;
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtCodigoIATA.Text = "";
            TxtCodigoICAO.Text = "";
        }

        private void ConfigurarBotones()
        {
            if (DgvAerolineas.RowCount == 0)
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

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvAerolineas.CurrentRow == null) return;

            string nombre = TxtNombre.Text.Trim();
            string codigoIATA = TxtCodigoIATA.Text.Trim();
            string codigoICAO = TxtCodigoICAO.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre) || Validacion.EsNuloOVacio(codigoIATA) || Validacion.EsNuloOVacio(codigoICAO))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar la región: {DgvAerolineas.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {

                    Aereolinea aereolinea = new Aereolinea
                    {
                        IdAereolinea = Convert.ToInt32(DgvAerolineas.CurrentRow.Cells[0].Value.ToString()),
                        Nombre = nombre,
                        CodigoIATA = codigoIATA,
                        CodigoICAO = codigoICAO,
                        FechaRegistro = DateTime.Parse(DgvAerolineas.CurrentRow.Cells[4].Value.ToString())
                    };

                    var response = await AereolineaService.Actualizar(DgvAerolineas.CurrentRow.Cells[0].Value.ToString(), aereolinea);

                    if (response != "Error en la solicitud Put")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente la aereolinea", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la aereolinea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAerolineas.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la aerolínea: {DgvAerolineas.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(resultado == DialogResult.OK)
            {
                try
                {
                    var response = await AereolineaService.EliminarPorId($"{DgvAerolineas.CurrentRow.Cells[0].Value}");

                    if (response != "Error en la solicitud Delete")
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
                    MessageBox.Show($"Error al eliminar la areolinea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtNombre.Text.Length > 49 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtCodigoIATA.Focus();
            }
        }

        private void TxtCodigoIATA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtCodigoIATA.Text.Length > 1 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtCodigoICAO.Focus();
            }
        }

        private void TxtCodigoICAO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtCodigoICAO.Text.Length > 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }    
}
