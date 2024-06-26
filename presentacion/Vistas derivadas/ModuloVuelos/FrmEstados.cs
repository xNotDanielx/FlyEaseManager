﻿using BLL.Servicios;
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
            this.Close();
        }

        private async void FrmEstados_Load(object sender, EventArgs e)
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
                CargarGrilla(await new EstadoService().ObtenerTodos());
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

            private void CargarGrilla(List<Estado> estados)
        {
            try
            { 
                DgvEstados.Rows.Clear();
                foreach (var item in estados)
                {
                    DgvEstados.Rows.Add(item.IdEstado, item.Nombre, item.Descripcion, item.Detencion, item.FechaRegistro.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void DgvEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //    private void DgvEstados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //    {
        //        if (e.RowIndex == -1) return;
        //        var fila = DgvEstados.Rows[e.RowIndex];
        //        TxtNombre.Text = fila.Cells[1].Value.ToString();
        //        TxtDescripcion.Text = fila.Cells[2].Value.ToString();
        //        if (fila.Cells[3].Value.ToString() == "True")
        //        {
        //            ChkDetencion.Checked = true;
        //        }
        //        else
        //        {
        //            ChkDetencion.Checked = false;
        //        }
        //    }

        //    private void limpiarCampos()
        //    {
        //        TxtNombre.Text = "";
        //        TxtDescripcion.Text = "";
        //        ChkDetencion.Checked = true;
        //    }

        //    private async void BtnAgregar_Click(object sender, EventArgs e)
        //    {
        //        try
        //        {
        //            Estado estado = new Estado
        //            {
        //                Nombre = TxtNombre.Text,
        //                Descripcion = TxtDescripcion.Text,
        //                Detencion = ChkDetencion.Checked
        //            };

        //            var response = await estadoService.Crear(estado);

        //            if (response != "Error en la solicitud Post")
        //            {
        //                await CargarDatos();
        //                limpiarCampos();
        //                MessageBox.Show("Se creado correctamente el estado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error al crear el estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    private async Task CargarDatos()
        //    {
        //        CargarGrilla(await estadoService.ObtenerTodos());
        //        ConfigurarBotones();
        //    }

        //    private void ConfigurarBotones()
        //    {
        //        if (DgvEstados.RowCount == 0)
        //        {
        //            BtnEliminar.Enabled = false;
        //            BtnActualizar.Enabled = false;
        //        }
        //        else
        //        {
        //            BtnEliminar.Enabled = true;
        //            BtnActualizar.Enabled = true;
        //        }
        //    }

        //    private async void BtnActualizar_Click(object sender, EventArgs e)
        //    {
        //        if (DgvEstados.CurrentRow == null) return;
        //        Estado estado = new Estado
        //        {
        //            IdEstado = Convert.ToInt32(DgvEstados.CurrentRow.Cells[0].Value.ToString()),
        //            Nombre = TxtNombre.Text,
        //            Descripcion = TxtDescripcion.Text,
        //            Detencion = ChkDetencion.Checked,
        //            FechaRegistro = DgvEstados.CurrentRow.Cells[4].Value.ToString()
        //        };
        //        var response = await estadoService.Actualizar(DgvEstados.CurrentRow.Cells[0].Value.ToString(), estado);

        //        MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        var lista = await estadoService.ObtenerTodos();
        //        CargarGrilla(lista);
        //    }

        //    private async void BtnEliminar_Click(object sender, EventArgs e)
        //    {
        //        if (DgvEstados.CurrentRow == null) return;

        //        DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el estado: {DgvEstados.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        //        if (resultado == DialogResult.OK)
        //        {
        //            var response = await estadoService.EliminarPorId($"{DgvEstados.CurrentRow.Cells[0].Value}");
        //            var lista = await estadoService.ObtenerTodos();

        //            CargarGrilla(lista);
        //            MessageBox.Show(response);
        //        }
        //    }

        //    private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        //    {
        //        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }
        //    }

        //    private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        //    {
        //        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }
        //    }
    }
}
