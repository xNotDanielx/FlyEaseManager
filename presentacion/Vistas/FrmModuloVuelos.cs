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
    public partial class FrmModuloVuelos : Form
    {

        private FrmPrincipal principal;
        public FrmModuloVuelos(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnAgregarVuelo_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmAgregarVuelos vista = new FrmAgregarVuelos(principal);
            vista.Dock = DockStyle.Fill;
            principal.OpenForms(vista);

        }
    }
}
