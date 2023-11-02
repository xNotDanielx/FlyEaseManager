using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Para poder mover la ventana

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            TmrFechaYHora.Start();
            Abrirformhijo(new FrmBienvenida());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); // Para poder mover la ventana

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

        }

        private void PnTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Para poder mover la ventana
        }

        private void Abrirformhijo( object FormHijo)
        {
            if (this.PnPrincipal.Controls.Count > 0)          
                this.PnPrincipal.Controls.RemoveAt(0);            
            Form fh  = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnPrincipal.Controls.Add(fh);
            this.PnPrincipal.Tag = fh;
            fh.Show();
        }

        private void BtnVuelos_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmModuloVuelos());
        }


        private void BtnAeropuertos_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmModuloAeropuertos());
        }

        private void BtnAviones_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmModuloAviones());
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            if (PnSubmenuEstadisticas.Visible == false)
            {
                PnSubmenuEstadisticas.Visible = true;
            }
            else
            {
                PnSubmenuEstadisticas.Visible = false;
            }
        }

        private void BtnBoletosVendidos_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false;
        }

        private void BtnClientes_Click_1(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false;
        }

        private void BtnEstadoVuelos_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false;
        }

        private void BtnDestinosPopulares_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false;
        }

        private void BtnTiempoxMeses_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false; PnSubmenuEstadisticas.Visible = false;
        }

        private void BtnDineroGenerado_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false;
        }

        private void TmrFechaYHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void PbLogoPrincipal_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmBienvenida());
        }
    }
}
