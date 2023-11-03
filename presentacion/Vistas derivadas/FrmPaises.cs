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
            PaisService service = new PaisService();

            var lista = await service.ObtenerTodos();

            CargarGrilla(lista);
        }

        void CargarGrilla(List<Pais> paises)
        {
            DgvPaises.Rows.Clear();
            foreach (var item in paises)
            {
                DgvPaises.Rows.Add(item.IdPais, item.Nombre, item.FechaRegistro);
            }
        }
    }
}
