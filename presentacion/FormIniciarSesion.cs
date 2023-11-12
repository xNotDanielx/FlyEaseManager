﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Para poder mover la ventana
using BLL.Servicios;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class FormIniciarSesion : Form
    {
       

        public FormIniciarSesion()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); // Para poder mover la ventana

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            if(TxtContrasena.Text == "Contraseña")
            {
                TxtContrasena.Text = "";
                TxtContrasena.ForeColor = Color.Black;
                TxtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if(TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "Contraseña";
                TxtContrasena.ForeColor = Color.LightGray;
                TxtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormIniciarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Para poder mover la ventana
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Para poder mover la ventana
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Para poder mover la ventana
        }

        private async void BtnAcceder_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            AdministradorService administradorService = new AdministradorService();
            var token = await administradorService.Autenticar(TxtUsuario.Text, TxtContrasena.Text);
            if (token != null)
            {
                AdministradorService administradorService2 = new AdministradorService();
                var administradores = await administradorService2.ObtenerTodos();
                var administrador = administradores.Where(item => item.Usuario == TxtUsuario.Text && item.Clave == TxtContrasena.Text).FirstOrDefault();
                FrmPrincipal principal = new FrmPrincipal(administrador, this);

                principal.Show(); // Le permitimos al nuevo formulario poder visualizarse
                this.Hide(); // Ocultamos el formulario actual

            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnAcceder.PerformClick();
            }
        }

        public void FormIniciarSesion_Load(object sender, EventArgs e)
        {
            TxtUsuario.Text = "Usuario";
            TxtUsuario.ForeColor = Color.LightGray;
            TxtContrasena.Text = "Contraseña";
            TxtContrasena.ForeColor = Color.LightGray;
            TxtContrasena.UseSystemPasswordChar = false;
        }
    }
}
