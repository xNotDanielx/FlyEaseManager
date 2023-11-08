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
    public partial class FrmAerolineas : Form
    {
        private FrmPrincipal principal;
        private AereolineaService AereolineaService = new AereolineaService();
        public FrmAerolineas(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAviones vista = new FrmModuloAviones(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async void FrmAerolineas_Load(object sender, EventArgs e)
        {
            CargarGrilla(await AereolineaService.ObtenerTodos());
        }

        void CargarGrilla(List<Aereolinea> aerolineas)
        {
            DgvAerolineas.Rows.Clear();
            foreach (var item in aerolineas)
            {
                DgvAerolineas.Rows.Add(item.IdAereolinea, item.Nombre, item.CodigoIATA,item.CodigoICAO, item.FechaRegistro);
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            Aereolinea aereolinea = new Aereolinea
            {
                Nombre = TxtNombre.Text,
                CodigoIATA = TxtCodigoIATA.Text,
                CodigoICAO = TxtCodigoICAO.Text,
            };
            var response = await AereolineaService.Crear(aereolinea);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            var lista = await AereolineaService.ObtenerTodos();
            CargarGrilla(lista);
            limpiarCampos();
        }

        void limpiarCampos()
        {
            TxtNombre.Text = "";
            TxtCodigoIATA.Text = "";
            TxtCodigoICAO.Text = "";
        }

        private void DgvAerolineas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvAerolineas.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
            TxtCodigoIATA.Text = fila.Cells[2].Value.ToString();
            TxtCodigoICAO.Text = fila.Cells[3].Value.ToString();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Toca editar el mensaje enviado al usuario
            if (DgvAerolineas.CurrentRow == null) return;
            Aereolinea aereolinea = new Aereolinea
            {
                IdAereolinea = Convert.ToInt32(DgvAerolineas.CurrentRow.Cells[0].Value.ToString()),
                Nombre = TxtNombre.Text,
                CodigoIATA = TxtCodigoIATA.Text,
                CodigoICAO = TxtCodigoICAO.Text,    
                FechaRegistro = DgvAerolineas.CurrentRow.Cells[4].Value.ToString()
            };
            var response = await AereolineaService.Actualizar(DgvAerolineas.CurrentRow.Cells[0].Value.ToString(), aereolinea);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var lista = await AereolineaService.ObtenerTodos();
            CargarGrilla(lista);
            limpiarCampos();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAerolineas.CurrentRow == null) return;
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la aerolínea: {DgvAerolineas.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(resultado == DialogResult.OK)
            {
                var response = await AereolineaService.EliminarPorId($"{DgvAerolineas.CurrentRow.Cells[0].Value}");
                var lista = await AereolineaService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
        }
    }    
}
