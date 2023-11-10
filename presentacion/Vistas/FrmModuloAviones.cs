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
            CargarGrilla(await avionService.ObtenerTodos());
        }

        void CargarGrilla(List<Avion> aviones)
        {
            DgvAviones.Rows.Clear();
            foreach (var item in aviones)
            {
                DgvAviones.Rows.Add(item.IdAvion, item.Nombre, item.Modelo, item.Fabricante, item.VelocidadPromedio,
                    item.CantidadPasajeros, item.CantidadCarga, item.Aereolinea.Nombre, item.FechaRegistro);
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
            await Task.Delay(190);
            if (DgvAviones.CurrentRow == null) return;            
            FrmEditarAvion vista = new FrmEditarAvion(principal, $"{DgvAviones.CurrentRow.Cells[0].Value}");
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
    }
}
