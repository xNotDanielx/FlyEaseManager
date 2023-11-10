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
    public partial class FrmEditarAereopuerto : Form
    {
        private FrmPrincipal principal;
        private string idAereopuerto;
        private CiudadService ciudadService = new CiudadService();
        private AereopuertoService aereopuertoService = new AereopuertoService();
        public FrmEditarAereopuerto(FrmPrincipal principal, string idAereopuerto)
        {
            this.principal = principal;
            InitializeComponent();
            this.idAereopuerto = idAereopuerto;
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var obtenerCiudad = await ciudadService.ObtenerTodos();

                Coordenadas coordenada = new Coordenadas
                {
                    Latitud = double.Parse(TxtLatitud.Text),
                    Longitud = double.Parse(TxtLongitud.Text)
                };

                Aereopuerto aeropuerto = new Aereopuerto
                {
                    Nombre = TxtNombre.Text,
                    Coordenadas = coordenada,
                    Ciudad = obtenerCiudad.Where(p => p.Nombre == CbCiudades.Text).FirstOrDefault()
                };

                var response = await aereopuertoService.Actualizar(idAereopuerto, aeropuerto);

                if (response != "Error en la solicitud Post: ")
                {
                    limpiarCampos();
                    MessageBox.Show("Se ha actualizado correctamente el aeropuerto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el aeropuerto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarCombo(List<Ciudad> ciudades)
        {
            CbCiudades.DataSource = ciudades;
            CbCiudades.DisplayMember = "Nombre";
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtLatitud.Text = "";
            TxtLongitud.Text = "";
            CbCiudades.Text = "";
        }

        private async void FrmEditarAereopuerto_Load(object sender, EventArgs e)
        {
            CargarCombo(await ciudadService.ObtenerTodos());
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLatitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void TxtLongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
