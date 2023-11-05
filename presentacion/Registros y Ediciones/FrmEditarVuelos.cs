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
    public partial class FrmEditarVuelos : Form
    {
        private FrmPrincipal principal;
        private int IdVuelo;
        public FrmEditarVuelos(FrmPrincipal principal, int IdVuelo)
        {
            this.principal = principal;
            this.IdVuelo= IdVuelo;
            InitializeComponent();
        }

        private void FrmEditarVuelos_Load(object sender, EventArgs e)
        {
            ConfigurarDateTimePickers();
        }

        void ConfigurarDateTimePickers()
        {
            DtpFechaSalida.MinDate = DateTime.Now;
            DtpFechaSalida.Value = DateTime.Now;
            DtpFechaLlegada.MinDate = DateTime.Now;
            DtpFechaLlegada.Value = DateTime.Now;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            
            FrmAgregarVuelos vista = new FrmAgregarVuelos(principal);
            principal.OpenForms(vista);
        }
    }
}
