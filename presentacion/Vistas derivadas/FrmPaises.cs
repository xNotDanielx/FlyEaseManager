using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Servicios;
using Entity;

namespace WindowsFormsApp1
{
    public partial class FrmPaises : Form
    {
        private FrmPrincipal principal;
        private PaisService paisService = new PaisService();
        public FrmPaises(FrmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);

            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
        }

        private async void FrmPaises_Load(object sender, EventArgs e)
        {            
            var lista = await paisService.ObtenerTodos();
            CargarGrilla(lista);
            ConfigurarBotones();
        }

        void ConfigurarBotones()
        {
            if (DgvPaises.RowCount == 1) // igual a 1 porque hay una fila vacia, poner 0 si se elimina esa linea
            {
                BtnEliminar.Enabled = false;
                //BtnActualizar.Enabled = false; //Cuando se cree el boton actualizar en este form
            }
            else
            {
                BtnEliminar.Enabled = true;
                //BtnActualizar.Enabled = true; //Cuando se cree el boton actualizar en este form
            }
        }

        void CargarGrilla(List<Pais> paises)
        {
            DgvPaises.Rows.Clear();
            foreach (var item in paises)
            {
                DgvPaises.Rows.Add(item.IdPais, item.Nombre, item.FechaRegistro);
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el país: {DgvPaises.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                var response = await paisService.EliminarPorId($"{DgvPaises.CurrentRow.Cells[0].Value}");
                var lista = await paisService.ObtenerTodos();

                CargarGrilla(lista);
                MessageBox.Show(response);
                ConfigurarBotones();
            }

        }
    }
}
