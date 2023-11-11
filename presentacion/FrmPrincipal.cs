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
using Entity;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        private static Administrador administradorActual;
        private Form activo;
        private FormIniciarSesion vuelta;
        
        public FrmPrincipal(/*Administrador administrador, FormIniciarSesion vuelta*/)
        {
            //administradorActual = administrador;
            this.vuelta = vuelta;
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
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                vuelta.FormIniciarSesion_Load(sender, e);
                vuelta.Show();
                this.Close();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PnTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Para poder mover la ventana
        }

        public void Abrirformhijo( object FormHijo)
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
            Abrirformhijo(new FrmModuloVuelos(this));
        }


        private void BtnAeropuertos_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmModuloAeropuertos(this));
        }

        private void BtnAviones_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmModuloAviones(this));
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

        private void PnTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //LblNombreUsuario.Text = administradorActual.Nombres + " " + administradorActual.Apellidos;
        }

        public void OpenForms(Form formHijo)
        {
            if (activo != null)
            {
                activo.Close();
                activo = null;
            }

            if (formHijo != null)
            {                
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                PnPrincipal.Controls.Add(formHijo);
                PnPrincipal.Tag = formHijo;
                formHijo.BringToFront();
                formHijo.Show();

                activo = formHijo;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmClientes(this));
        }

        private void BtnBoletosVendidos_Click_1(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmBoletos(this));
        }
    }
}
