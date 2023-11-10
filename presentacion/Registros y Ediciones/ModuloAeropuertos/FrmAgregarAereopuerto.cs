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
    public partial class FrmAgregarAereopuerto : Form
    {
        private FrmPrincipal principal;
        private CiudadService ciudadService = new CiudadService();
        private AereopuertoService aereopuertoService = new AereopuertoService();
        public FrmAgregarAereopuerto(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void FrmAgregarAereopuerto_Load(object sender, EventArgs e)
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

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var obtenerCiudad = await ciudadService.ObtenerTodos();

                Coordenadas coordenada = new Coordenadas
                {
                    Latitud = double.Parse(TxtLatitud.Text),
                    Longitud = double.Parse(TxtLongitud.Text)
                };

                Aereopuerto aereopuerto = new Aereopuerto
                {
                    Nombre = TxtNombre.Text,
                    Coordenadas = coordenada,
                    Ciudad = obtenerCiudad.Where(p => p.Nombre == CbCiudades.Text).FirstOrDefault()
                };

                var response = await aereopuertoService.Crear(aereopuerto);

                if (response != "Error en la solicitud Post: ")
                { 
                    limpiarCampos();
                    MessageBox.Show("Se creado correctamente el aeropuerto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el aeropuerto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtLatitud.Text = "";
            TxtLongitud.Text = "";
            CbCiudades.Text = "";
        }

        void CargarCombo(List<Ciudad> ciudades)
        {
            CbCiudades.DataSource = ciudades;
            CbCiudades.DisplayMember = "Nombre";
        }

    }
}