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
    public partial class FrmClientes : Form
    {
        private FrmPrincipal principal;
        private ClienteService clienteService = new ClienteService();
        public FrmClientes(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private async void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla(await clienteService.ObtenerTodos());
        }      

        void CargarGrilla(List<Cliente> clientes)
        {
            DgvClientes.Rows.Clear();
            foreach (var item in clientes)
            {                
                DgvClientes.Rows.Add(item.NumeroDocumento, item.TipoDocumento, item.Nombres, item.Apellidos, item.Celular, item.Correo, item.FechaRegistro);
            }
        }

        private void DgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1) return;
            var fila = DgvClientes.Rows[e.RowIndex];
            TxtDocumento.Text = fila.Cells[0].Value.ToString();
            if (fila.Cells[1].Value.ToString() == "CC")
            {
                CbTipoDocumento.Text = CbTipoDocumento.Items[0].ToString();
            }
            else if (fila.Cells[1].Value.ToString() == "CE")
            {
                CbTipoDocumento.Text = CbTipoDocumento.Items[1].ToString();
            }
            else if (fila.Cells[1].Value.ToString() == "TI")
            {
                CbTipoDocumento.Text = CbTipoDocumento.Items[2].ToString();
            }
            else if (fila.Cells[1].Value.ToString() == "Pasaporte")
            {
                CbTipoDocumento.Text = CbTipoDocumento.Items[3].ToString();
            }          
            TxtNombres.Text = fila.Cells[2].Value.ToString();
            TxtApellidos.Text = fila.Cells[3].Value.ToString();
            TxtCelular.Text = fila.Cells[4].Value.ToString();
            TxtCorreo.Text = fila.Cells[5].Value.ToString();
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoDocumento = "";
                if (CbTipoDocumento.Text == "Cedula de ciudadania")
                {
                    tipoDocumento = "CC";
                }else if(CbTipoDocumento.Text == "Cedula de extranjeria")
                {
                    tipoDocumento = "CE";
                }else if(CbTipoDocumento.Text == "Tarjeta de identidad")
                {
                    tipoDocumento = "TI";
                }else if(CbTipoDocumento.Text == "Pasaporte")
                {
                    tipoDocumento = "Pasaporte";
                }

                Cliente cliente = new Cliente
                {
                    NumeroDocumento = TxtDocumento.Text,

                    TipoDocumento = tipoDocumento,
                    Nombres = TxtNombres.Text,
                    Apellidos = TxtApellidos.Text,
                    Celular = TxtCelular.Text,
                    Correo = TxtCorreo.Text,
                };

                var response = await clienteService.Crear(cliente);

                if (response == "Error en la solicitud Post:")
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CargarGrilla(await clienteService.ObtenerTodos());
                    limpiarCampos();
                    MessageBox.Show("Se ha creado correctamente el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiarCampos()
        {
            TxtDocumento.Text = "";
            CbTipoDocumento.Text = "";
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            TxtCelular.Text = "";
            TxtCorreo.Text = "";
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar el cliente: {DgvClientes.CurrentRow.Cells[2].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                try
                {
                    var tipoDocumento = "";
                    if (CbTipoDocumento.Text == "Cedula de ciudadania")
                    {
                        tipoDocumento = "CC";
                    }
                    else if (CbTipoDocumento.Text == "Cedula de extranjeria")
                    {
                        tipoDocumento = "CE";
                    }
                    else if (CbTipoDocumento.Text == "Tarjeta de identidad")
                    {
                        tipoDocumento = "TI";
                    }
                    else if (CbTipoDocumento.Text == "Pasaporte")
                    {
                        tipoDocumento = "Pasaporte";
                    }

                    Cliente cliente = new Cliente
                    {
                        NumeroDocumento = TxtDocumento.Text,
                        TipoDocumento = tipoDocumento,
                        Nombres = TxtNombres.Text,
                        Apellidos = TxtApellidos.Text,
                        Celular = TxtCelular.Text,
                        Correo = TxtCorreo.Text,
                        FechaRegistro = DgvClientes.CurrentRow.Cells[6].Value.ToString()
                    };

                    var response = await clienteService.Actualizar(DgvClientes.CurrentRow.Cells[0].Value.ToString(), cliente);

                    if (response == "Error en la solicitud Put:")
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CargarGrilla(await clienteService.ObtenerTodos());
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el cliente: {DgvClientes.CurrentRow.Cells[2].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var response = await clienteService.EliminarPorId($"{DgvClientes.CurrentRow.Cells[0].Value}");

                    if (response == "Error en la solicitud Delete:")
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CargarGrilla(await clienteService.ObtenerTodos());
                        limpiarCampos();
                        MessageBox.Show("Se ha eliminado correctamente el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
