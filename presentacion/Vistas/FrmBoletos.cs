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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FrmBoletos : Form
    {
        private FrmPrincipal principal;
        private BoletoService boletoService = new BoletoService();
        public FrmBoletos(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void FrmBoletos_Load(object sender, EventArgs e)
        {
            CargarGrilla(await boletoService.ObtenerTodos());
        }

        void CargarGrilla(List<Boleto> boletos)
        {
            DgvBoletos.Rows.Clear();
            foreach (var item in boletos)
            {
                DgvBoletos.Rows.Add(item.IdBoleto, item.Precio, item.Descuento, item.PrecioTotal, item.Cliente.NumeroDocumento, item.Asiento.Posicion, item.Asiento.Categoria.Nombre, item.Vuelo.IdVuelo, item.Vuelo.FechaYHoraDeSalida, item.Vuelo.Avion.IdAvion, item.FechaRegistro);
            }
        }

        void limpiarcampos()
        {
            TxtDescuento.Text = "";
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }

            // Verifica el rango de números permitido (1-100)
            if (e.KeyChar != (char)Keys.Back)
            {
                int valorIngresado;
                if (!int.TryParse(TxtDescuento.Text + e.KeyChar, out valorIngresado) || valorIngresado < 1 || valorIngresado > 100)
                {
                    e.Handled = true;
                }
            }
        }

        private void DgvBoletos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvBoletos.Rows[e.RowIndex];

            TxtDescuento.Text = fila.Cells[2].Value.ToString();
        }
    }
}
