namespace WindowsFormsApp1
{
    partial class FrmModuloAviones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGestionCategorias = new System.Windows.Forms.Button();
            this.BtnGestionAsientos = new System.Windows.Forms.Button();
            this.BtnGestionAerolineas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvAviones = new System.Windows.Forms.DataGridView();
            this.IdAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabricanteDelAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelocidadAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(979, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Gestion";
            // 
            // BtnGestionCategorias
            // 
            this.BtnGestionCategorias.BackColor = System.Drawing.Color.Firebrick;
            this.BtnGestionCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionCategorias.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionCategorias.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnGestionCategorias.Location = new System.Drawing.Point(949, 335);
            this.BtnGestionCategorias.Name = "BtnGestionCategorias";
            this.BtnGestionCategorias.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionCategorias.TabIndex = 41;
            this.BtnGestionCategorias.Text = "Categorias asientos";
            this.BtnGestionCategorias.UseVisualStyleBackColor = false;
            this.BtnGestionCategorias.Click += new System.EventHandler(this.BtnGestionCategorias_Click);
            // 
            // BtnGestionAsientos
            // 
            this.BtnGestionAsientos.BackColor = System.Drawing.Color.Firebrick;
            this.BtnGestionAsientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionAsientos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionAsientos.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnGestionAsientos.Location = new System.Drawing.Point(949, 233);
            this.BtnGestionAsientos.Name = "BtnGestionAsientos";
            this.BtnGestionAsientos.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionAsientos.TabIndex = 40;
            this.BtnGestionAsientos.Text = "Asientos";
            this.BtnGestionAsientos.UseVisualStyleBackColor = false;
            this.BtnGestionAsientos.Click += new System.EventHandler(this.BtnGestionAsientos_Click);
            // 
            // BtnGestionAerolineas
            // 
            this.BtnGestionAerolineas.BackColor = System.Drawing.Color.Firebrick;
            this.BtnGestionAerolineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionAerolineas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionAerolineas.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnGestionAerolineas.Location = new System.Drawing.Point(949, 131);
            this.BtnGestionAerolineas.Name = "BtnGestionAerolineas";
            this.BtnGestionAerolineas.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionAerolineas.TabIndex = 38;
            this.BtnGestionAerolineas.Text = "Aerolíneas";
            this.BtnGestionAerolineas.UseVisualStyleBackColor = false;
            this.BtnGestionAerolineas.Click += new System.EventHandler(this.BtnGestionAerolineas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Aviones";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnEliminar.Location = new System.Drawing.Point(627, 438);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminar.TabIndex = 36;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnEditar.Location = new System.Drawing.Point(384, 438);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(121, 46);
            this.BtnEditar.TabIndex = 35;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnAgregar.Location = new System.Drawing.Point(133, 438);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregar.TabIndex = 34;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvAviones
            // 
            this.DgvAviones.AllowUserToAddRows = false;
            this.DgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAvion,
            this.NombreAvion,
            this.ModeloAvion,
            this.FabricanteDelAvion,
            this.VelocidadAvion,
            this.CantidadPasajeros,
            this.CantidadCarga,
            this.NombreAerolinea,
            this.FechaRegistro});
            this.DgvAviones.Location = new System.Drawing.Point(12, 48);
            this.DgvAviones.Name = "DgvAviones";
            this.DgvAviones.RowHeadersVisible = false;
            this.DgvAviones.Size = new System.Drawing.Size(893, 384);
            this.DgvAviones.TabIndex = 33;
            // 
            // IdAvion
            // 
            this.IdAvion.HeaderText = "Id";
            this.IdAvion.Name = "IdAvion";
            this.IdAvion.ReadOnly = true;
            this.IdAvion.Width = 80;
            // 
            // NombreAvion
            // 
            this.NombreAvion.HeaderText = "Nombre";
            this.NombreAvion.Name = "NombreAvion";
            this.NombreAvion.ReadOnly = true;
            // 
            // ModeloAvion
            // 
            this.ModeloAvion.HeaderText = "Modelo";
            this.ModeloAvion.Name = "ModeloAvion";
            this.ModeloAvion.ReadOnly = true;
            // 
            // FabricanteDelAvion
            // 
            this.FabricanteDelAvion.HeaderText = "Fabricante";
            this.FabricanteDelAvion.Name = "FabricanteDelAvion";
            this.FabricanteDelAvion.ReadOnly = true;
            // 
            // VelocidadAvion
            // 
            this.VelocidadAvion.HeaderText = "Velocidad (Km/h)";
            this.VelocidadAvion.Name = "VelocidadAvion";
            this.VelocidadAvion.ReadOnly = true;
            // 
            // CantidadPasajeros
            // 
            this.CantidadPasajeros.HeaderText = "Cantidad Pasajeros";
            this.CantidadPasajeros.Name = "CantidadPasajeros";
            this.CantidadPasajeros.ReadOnly = true;
            this.CantidadPasajeros.Width = 80;
            // 
            // CantidadCarga
            // 
            this.CantidadCarga.HeaderText = "Cantidad carga (Kg)";
            this.CantidadCarga.Name = "CantidadCarga";
            this.CantidadCarga.ReadOnly = true;
            this.CantidadCarga.Width = 80;
            // 
            // NombreAerolinea
            // 
            this.NombreAerolinea.HeaderText = "Aerolínea";
            this.NombreAerolinea.Name = "NombreAerolinea";
            this.NombreAerolinea.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 150;
            // 
            // FrmModuloAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGestionCategorias);
            this.Controls.Add(this.BtnGestionAsientos);
            this.Controls.Add(this.BtnGestionAerolineas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvAviones);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModuloAviones";
            this.Text = "FrmModuloAviones";
            this.Load += new System.EventHandler(this.FrmModuloAviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGestionCategorias;
        private System.Windows.Forms.Button BtnGestionAsientos;
        private System.Windows.Forms.Button BtnGestionAerolineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvAviones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabricanteDelAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelocidadAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}