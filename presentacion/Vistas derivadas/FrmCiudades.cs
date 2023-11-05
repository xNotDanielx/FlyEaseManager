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
    public partial class FrmCiudades : Form
    {
        private FrmPrincipal principal;
        private CiudadService ciudadService = new CiudadService();
        public FrmCiudades(FrmPrincipal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
        }

        private void DgvCiudades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1) return;
            var fila = DgvCiudades.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
            CbRegiones.Text = fila.Cells[2].Value.ToString();
        }

        private async void FrmCiudades_Load(object sender, EventArgs e)
        {
            var lista = await ciudadService.ObtenerTodos();
            CargarGrilla(lista);
            ConfigurarBotones();
        }

        void CargarGrilla(List<Ciudad> ciudades)
        {
            DgvCiudades.Rows.Clear();
            foreach (var item in ciudades)
            {
                DgvCiudades.Rows.Add(item.IdCiudad, item.Nombre, item.Region.Nombre, item.FechaRegistro);
            }
        }

        void ConfigurarBotones()
        {
            if (DgvCiudades.RowCount == 1) // igual a 1 porque hay una fila vacia, poner 0 si se elimina esa linea
            {
                BtnEliminar.Enabled = false;
                BtnActualizar.Enabled = false;
            }
            else
            {
                BtnEliminar.Enabled = true;
                BtnActualizar.Enabled = true;
            }
        }
    }
}
