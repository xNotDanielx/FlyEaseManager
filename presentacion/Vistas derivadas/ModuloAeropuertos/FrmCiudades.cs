using BLL.Servicios;
using Entity;
using Entity.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        private async void FrmCiudades_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async void DgvCiudades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var fila = DgvCiudades.Rows[e.RowIndex];
            TxtNombre.Text = fila.Cells[1].Value.ToString();
            CbRegiones.Text = fila.Cells[2].Value.ToString();

            var ciudad = await ciudadService.ObtenerPorId(fila.Cells[0].Value.ToString());

            if (ciudad.Imagen == null)
            {
                pbImagen.Image = null;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(ciudad.Imagen);
                Bitmap bitmap = new Bitmap(memoryStream);
                pbImagen.Image = bitmap;
            }
        }

        private async void BtnRegresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(190);
            IrAModuloAereopuertos();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvCiudades.CurrentRow == null) return;

            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la ciudad: {DgvCiudades.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var response = await ciudadService.EliminarPorId($"{DgvCiudades.CurrentRow.Cells[0].Value}");

                    if (response != "Error en la solicitud Delete: ")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha eliminado correctamente la ciudad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la ciudad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvCiudades.CurrentRow == null) return;

            string nombre = TxtNombre.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre))
            {
                MessageBox.Show("El nombre de la región no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Validacion.EsTamañoImagenValido((Bitmap)pbImagen.Image, 100))
            {
                MessageBox.Show("Debe agregar una imagen válida (MÁX 100KB).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Está seguro de actualizar la ciudad: {DgvCiudades.CurrentRow.Cells[1].Value}?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    var regiones = await new RegionService().ObtenerTodos();
                    var region = regiones.Where(p => p.Nombre == CbRegiones.Text).FirstOrDefault();

                    Ciudad ciudad = new Ciudad
                    {
                        IdCiudad = Convert.ToInt32(DgvCiudades.CurrentRow.Cells[0].Value.ToString()),
                        Nombre = nombre,
                        Region = region,
                        FechaRegistro = DateTime.Parse(DgvCiudades.CurrentRow.Cells[3].Value.ToString()),
                        Imagen = ObtenerImagen()
                    };

                    var response = await ciudadService.Actualizar(DgvCiudades.CurrentRow.Cells[0].Value.ToString(), ciudad);

                    if (response != "Error en la solicitud Put: ")
                    {
                        await CargarDatos();
                        limpiarCampos();
                        MessageBox.Show("Se ha actualizado correctamente la ciudad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la ciudad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();

            if (Validacion.EsNuloOVacio(nombre))
            {
                MessageBox.Show("El nombre de la región no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Validacion.EsTamañoImagenValido((Bitmap)pbImagen.Image, 100))
            {
                MessageBox.Show("Debe guardar una imagen valida (MAX 100KB).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var obtenerRegion = await new RegionService().ObtenerTodos();

                Ciudad ciudad = new Ciudad()
                {
                    Nombre = nombre,
                    Region = obtenerRegion.Where(x => x.Nombre == CbRegiones.Text).FirstOrDefault(),
                    Imagen = ObtenerImagen()
                };

                var response = await ciudadService.Crear(ciudad);

                if (response != "Error en la solicitud Post: ")
                {
                    await CargarDatos();
                    limpiarCampos();
                    MessageBox.Show("Se creado correctamente la ciudad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido realizar la operación\nIntente más tarde.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la ciudad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionarImagen = new OpenFileDialog();
            ofdSeleccionarImagen.Filter = "Imagenes|*.jpg; *.png; *.jpeg";
            ofdSeleccionarImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionarImagen.Title = "Seleccionar Imagen";

            if (ofdSeleccionarImagen.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(ofdSeleccionarImagen.FileName);
            }
        }

        private void IrAModuloAereopuertos()
        {
            FrmModuloAeropuertos vista = new FrmModuloAeropuertos(principal);
            principal.OpenForms(vista);
            this.Close();
        }

        private async Task CargarDatos()
        {
            CargarGrilla(await ciudadService.ObtenerTodos());
            CargarCombo(await new RegionService().ObtenerTodos());
            ConfigurarBotones();
            TxtNombre.ShortcutsEnabled = false;
        }

        private void ConfigurarBotones()
        {
            if (DgvCiudades.RowCount == 0)
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

        private void CargarGrilla(List<Ciudad> ciudades)
        {
            try
            {
                DgvCiudades.Rows.Clear();
                foreach (var item in ciudades)
                {
                    DgvCiudades.Rows.Add(item.IdCiudad, item.Nombre, item.Region.Nombre, item.FechaRegistro.ToString());
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void limpiarCampos()
        {
            TxtNombre.Text = "";
            pbImagen.Image = null;
        }

        private void CargarCombo(List<Entity.Region> regiones)
        {
            CbRegiones.DataSource = regiones;
            CbRegiones.DisplayMember = "Nombre";
        }

        private byte[] ObtenerImagen()
        {
            MemoryStream memoryStream = new MemoryStream();
            pbImagen.Image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtNombre.Text.Length > 59 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
