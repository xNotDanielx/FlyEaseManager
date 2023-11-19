using BLL.Servicios;
using Entity;
using Entity.Utilidades;
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
            await CargarDatos();
        }

        void CargarGrilla(List<Boleto> boletos)
        {
            try
            {
                DgvBoletos.Rows.Clear();
                foreach (var item in boletos)
                {
                    DgvBoletos.Rows.Add(item.IdBoleto, item.Precio, item.Descuento, item.PrecioTotal, item.Cliente.NumeroDocumento, item.Asiento.IdAsiento, item.Asiento.Categoria.Nombre, item.Vuelo.IdVuelo, item.Vuelo.FechaYHoraDeSalida, item.Vuelo.Avion.IdAvion, item.FechaRegistro.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }

            if (e.KeyChar != (char)Keys.Back)
            {
                int valorIngresado;
                if (!int.TryParse(TxtDescuento.Text + e.KeyChar, out valorIngresado) || valorIngresado < 0 || valorIngresado > 100)
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

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvBoletos.CurrentRow == null) return;

            string descuento = TxtDescuento.Text.Trim();

            if (Validacion.EsNuloOVacio(descuento))
            {
                MessageBox.Show("El el descuento del boleto no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar el boleto de id: {DgvBoletos.CurrentRow.Cells[0].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    ClienteService clienteService = new ClienteService();
                    var clientes = await clienteService.ObtenerTodos();
                    var cliente = clientes.Where(item => item.NumeroDocumento.Equals(DgvBoletos.CurrentRow.Cells[4].Value.ToString())).FirstOrDefault();

                    AsientoService asientoService = new AsientoService();
                    var asientos = await asientoService.ObtenerTodos();
                    var asiento = asientos.Where(item => item.IdAsiento == int.Parse(DgvBoletos.CurrentRow.Cells[5].Value.ToString())).FirstOrDefault();

                    VueloService vueloService = new VueloService();
                    var vuelos = await vueloService.ObtenerTodos();
                    var vuelo = vuelos.Where(item => item.IdVuelo == int.Parse(DgvBoletos.CurrentRow.Cells[7].Value.ToString())).FirstOrDefault();

                    Boleto boleto = new Boleto
                    {
                        IdBoleto = Convert.ToInt32(DgvBoletos.CurrentRow.Cells[0].Value.ToString()),
                        Precio = Convert.ToDouble(DgvBoletos.CurrentRow.Cells[1].Value.ToString()),
                        Descuento = Convert.ToDouble(TxtDescuento.Text),
                        PrecioTotal = Convert.ToDouble(DgvBoletos.CurrentRow.Cells[3].Value.ToString()),
                        Cliente = cliente,
                        Vuelo = vuelo,
                        Asiento = asiento,
                        FechaRegistro = DateTime.Parse(DgvBoletos.CurrentRow.Cells[10].Value.ToString())
                    };

                    var response = await boletoService.Actualizar(DgvBoletos.CurrentRow.Cells[0].Value.ToString(), boleto);

                    if (response != "Error en la solicitud Put")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente el boleto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el boleto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var loading = CrearLoading();
            try
            {
                loading.ShowLoading(loading);
                CargarGrilla(await boletoService.ObtenerTodos());
                TxtDescuento.ShortcutsEnabled = false;
                loading.HideLoading();
            }
            catch (Exception ex)
            {
                loading.HideLoading();
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void limpiarCampos()
        {
            TxtDescuento.Text = "";
        }
    }
}
