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
    public partial class FrmModuloAviones : Form
    {
        private FrmPrincipal principal;
        private AvionService avionService = new AvionService();

        public FrmModuloAviones(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnGestionAsientos_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmAsientos vista = new FrmAsientos(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnGestionCategorias_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmCategorias vista = new FrmCategorias(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void FrmModuloAviones_Load(object sender, EventArgs e)
        {
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                await CargarDatos();
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void CargarGrilla(List<Avion> aviones)
        {
            try
            {
                DgvAviones.Rows.Clear();
                foreach (var item in aviones)
                {
                    DgvAviones.Rows.Add(item.IdAvion, item.Nombre, item.Modelo, item.Fabricante, item.VelocidadPromedio,
                        item.CantidadPasajeros, item.CantidadCarga, item.Aereolinea.Nombre, item.FechaRegistro.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void BtnGestionAerolineas_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmAerolineas vista = new FrmAerolineas(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvAviones.CurrentRow == null) return;
            await Task.Delay(190);

            var avion= await avionService.ObtenerPorId($"{DgvAviones.CurrentRow.Cells[0].Value}");
            FrmEditarAvion vista = new FrmEditarAvion(principal, avion);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
            this.Close();
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmAgregarAvion frmAgregarAvion = new FrmAgregarAvion(principal);
            frmAgregarAvion.Dock = DockStyle.Fill;
            principal.OpenForms(frmAgregarAvion);
            this.Close();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAviones.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el avión: {DgvAviones.CurrentRow.Cells[1].Value}?\nSe eliminaran todos los asientos asociados!", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var loading = CrearLoading();
                try
                {
                    loading.ShowLoading(loading);
                    var response = await avionService.EliminarPorId($"{DgvAviones.CurrentRow.Cells[0].Value}");

                    if (response != "Error en la solicitud Delete")
                    {
                        await CargarDatos();
                        loading.HideLoading();
                        MessageBox.Show("Se ha eliminado correctamente el avion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        loading.HideLoading();
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    loading.HideLoading();
                    MessageBox.Show($"Error al eliminar el avion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private FrmLoading CrearLoading()
        {
            FrmLoading loadingForm = new FrmLoading(principal);
            return loadingForm;
        }

        private async Task CargarDatos()
        {
            
                CargarGrilla(await avionService.ObtenerTodos());
                ConfigurarBotones();
                
        }

        private void ConfigurarBotones()
        {
            if (DgvAviones.RowCount == 0)
            {
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
            }
            else
            {
                BtnEliminar.Enabled = true;
                BtnEditar.Enabled = true;
            }
        }
    }
}
