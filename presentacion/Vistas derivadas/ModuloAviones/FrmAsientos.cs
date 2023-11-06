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
    public partial class FrmAsientos : Form
    {
        private FrmPrincipal principal;
        public FrmAsientos(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAviones vista = new FrmModuloAviones();
            principal.OpenForms(vista);
        }

        private void FrmAsientos_Load(object sender, EventArgs e)
        {

        }
    }
}
