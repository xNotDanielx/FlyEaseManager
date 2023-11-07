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
    public partial class FrmModuloAeropuertos : Form
    {
        private FrmPrincipal principal;
        private AereopuertoService AereopuertoService = new AereopuertoService();
        public FrmModuloAeropuertos(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private async void BtnGestionPaises_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmPaises vista = new FrmPaises(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
        }

        private async void BtnGestionRegiones_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmRegiones vista = new FrmRegiones(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
        }

        private async void BtnGestionCiudades_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmCiudades vista = new FrmCiudades(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
        }

        private async void FrmModuloAeropuertos_Load(object sender, EventArgs e)
        {
            //CargarGrilla(await AereopuertoService.ObtenerTodos());
        }
        
        void CargarGrilla(List<Aereopuerto> aeropuertos)
        {
            DgvAeropuertos.Rows.Clear();
            foreach (var item in aeropuertos)
            {
                DgvAeropuertos.Rows.Add(item.IdAereopuerto, item.Nombre, item.Coordenada.Latitud, item.Coordenada.Longitud, item.Ciudad, item.Ciudad.Nombre, item.FechaRegistro);
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmAgregarAereopuerto vista = new FrmAgregarAereopuerto(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAeropuertos.CurrentRow == null) return;
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el aeropuerto: {DgvAeropuertos.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(resultado == DialogResult.OK)
            {
                var response = await AereopuertoService.EliminarPorId($"{DgvAeropuertos.CurrentRow.Cells[0].Value}");
                var lista = await AereopuertoService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response);
            }
        }
    }
}
