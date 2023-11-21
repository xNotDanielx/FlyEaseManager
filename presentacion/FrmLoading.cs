using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLoading : Form
    {
        public Form formulario;
        public FrmLoading(Form formulario)
        {
            InitializeComponent();
            this.formulario = formulario;

            ShowInTaskbar = false;
        }

        private void IniciarGif()
        {
            pbGif.BackColor = Color.Transparent;
            pbGif.SizeMode = PictureBoxSizeMode.CenterImage;

            ActualizarTamañoPB();
        }

        private void ActualizarTamañoPB()
        {
            int tamaño = Math.Min(formulario.Width, formulario.Height);

            pbGif.Size = new Size(tamaño, tamaño);
            pbGif.Location = new Point((formulario.Width - tamaño) / 2, (formulario.Height - tamaño) / 2);
        }

        public void ShowLoading(FrmLoading loadingForm)
        {
            loadingForm.Size = formulario.Size;
            loadingForm.Show(formulario);
            loadingForm.BringToFront();
            loadingForm.Refresh();
        }

        public void HideLoading()
        {
            Close();
            formulario.Focus();
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            IniciarGif();
            Location = formulario.Location;
        }
    }
}
