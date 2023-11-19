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
        private FrmIniciarSesion vuelta;
        
        public FrmPrincipal(Administrador administrador, FrmIniciarSesion vuelta)
        {
            administradorActual = administrador;
            this.vuelta = vuelta;
            InitializeComponent();
            TmrFechaYHora.Start();
            OpenForms(new FrmBienvenida());
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

        private void BtnVuelos_Click(object sender, EventArgs e)
        {
            OpenForms(new FrmModuloVuelos(this));
        }


        private void BtnAeropuertos_Click(object sender, EventArgs e)
        {
            OpenForms(new FrmModuloAeropuertos(this));
        }

        private void BtnAviones_Click(object sender, EventArgs e)
        {
            OpenForms(new FrmModuloAviones(this));
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
            OpenForms(new FrmFiltroVuelos(this));
        }

        private void BtnDestinosPopulares_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false;
            OpenForms(new FrmDestinosPopulares(this));
        }

        private void BtnTiempoxMeses_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false; PnSubmenuEstadisticas.Visible = false;
            OpenForms(new FrmHistograma(this));
        }

        private void BtnDineroGenerado_Click(object sender, EventArgs e)
        {
            PnSubmenuEstadisticas.Visible = false;
            OpenForms(new FrmDineroGeneradoXVuelos(this));
        }

        private void TmrFechaYHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void PbLogoPrincipal_Click(object sender, EventArgs e)
        {
            OpenForms(new FrmBienvenida());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblNombreUsuario.Text = administradorActual.Nombres + " " + administradorActual.Apellidos;
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
            OpenForms(new FrmClientes(this));
        }

        private void BtnBoletosVendidos_Click_1(object sender, EventArgs e)
        {
            OpenForms(new FrmBoletos(this));
        }
    }
}
