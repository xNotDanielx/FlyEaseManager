﻿using BLL.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using System.CodeDom;

namespace WindowsFormsApp1
{
    public partial class FrmRegiones : Form
    {
        private FrmPrincipal principal;
        public FrmRegiones(FrmPrincipal principal)
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

        private async void FrmRegiones_Load(object sender, EventArgs e)
        {
            CargarGrilla(await new RegionService().ObtenerTodos());

            CargarCombo(await new PaisService().ObtenerTodos());
        }
        void CargarGrilla(List<Region> regiones)
        {
            DgvPaises.Rows.Clear();
            foreach (var item in regiones)
            {
                DgvPaises.Rows.Add(item.IdRegion, item.Nombre, item.Pais.Nombre, item.FechaRegistro);
            }
        }

        void CargarCombo(List<Pais> paises)
        {
                CbPaises.DataSource = paises;
                CbPaises.DisplayMember = "Nombre";
        }

        private void DgvPaises_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var fila = DgvPaises.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
            CbPaises.Text = fila.Cells[2].Value.ToString();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            //RegionService service = new RegionService();
            //Region region = new Region
            //{ 
            //Nombre = TxtNombre.Text;
            //Pais.Nombre = CbPaises.Text;
            //};
            
            var ObtenerPais = await new PaisService().ObtenerTodos();
            var pais = ObtenerPais.Where(p => p.Nombre == CbPaises.Text).FirstOrDefault();
            RegionService service = new RegionService();
            Region region = new Region
            {
                IdRegion = Convert.ToInt32(DgvPaises.CurrentRow.Cells[0].Value.ToString()),
                Nombre = TxtNombre.Text,
                Pais = pais,
                FechaRegistro = DgvPaises.CurrentRow.Cells[3].Value.ToString()
            };
            var response = await service.Actualizar(DgvPaises.CurrentRow.Cells[0].Value.ToString(), region);

            MessageBox.Show(response, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
