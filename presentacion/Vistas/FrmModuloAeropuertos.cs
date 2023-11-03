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
    }
}
