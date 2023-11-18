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
    public partial class FormLoading : Form
    {
        public Form formulario;
        public FormLoading(Form formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }

        private void IniciarGif()
        {
            pbGif.BackColor = Color.Transparent;
            pbGif.SizeMode = PictureBoxSizeMode.CenterImage;

            pbGif.Image = Image.FromFile("Resources/loading.gif");
            ActualizarTamañoPB();
        }

        private void ActualizarTamañoPB()
        {
            int tamaño = Math.Min(formulario.Width, formulario.Height);

            pbGif.Size = new Size(tamaño, tamaño);
            pbGif.Location = new Point((formulario.Width - tamaño) / 2, (formulario.Height - tamaño) / 2);
        }

        public void ShowLoading()
        {
            FormLoading loadingForm = new FormLoading(formulario);

            loadingForm.Size = formulario.Size;
            loadingForm.StartPosition = formulario.StartPosition;

            loadingForm.Show(formulario);
            loadingForm.BringToFront();
            loadingForm.Refresh();
        }

        public void HideLoading()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form.Owner == formulario && form is FormLoading loadingForm)
                {
                    formsToClose.Add(loadingForm);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            formulario.Focus();
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            IniciarGif();
        }
    }
}
