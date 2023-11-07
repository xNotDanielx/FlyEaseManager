namespace WindowsFormsApp1
{
    partial class FrmModuloAeropuertos
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
            this.BtnGestionRegiones = new System.Windows.Forms.Button();
            this.BtnGestionCiudades = new System.Windows.Forms.Button();
            this.BtnGestionPaises = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvAeropuertos = new System.Windows.Forms.DataGridView();
            this.IdAeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatitudCoordenada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongitudCoordeada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAeropuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(888, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Gestion";
            // 
            // BtnGestionRegiones
            // 
            this.BtnGestionRegiones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionRegiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionRegiones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionRegiones.Location = new System.Drawing.Point(863, 197);
            this.BtnGestionRegiones.Name = "BtnGestionRegiones";
            this.BtnGestionRegiones.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionRegiones.TabIndex = 30;
            this.BtnGestionRegiones.Text = "Regiones";
            this.BtnGestionRegiones.UseVisualStyleBackColor = false;
            this.BtnGestionRegiones.Click += new System.EventHandler(this.BtnGestionRegiones_Click);
            // 
            // BtnGestionCiudades
            // 
            this.BtnGestionCiudades.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionCiudades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionCiudades.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionCiudades.Location = new System.Drawing.Point(863, 281);
            this.BtnGestionCiudades.Name = "BtnGestionCiudades";
            this.BtnGestionCiudades.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionCiudades.TabIndex = 29;
            this.BtnGestionCiudades.Text = "Ciudades";
            this.BtnGestionCiudades.UseVisualStyleBackColor = false;
            this.BtnGestionCiudades.Click += new System.EventHandler(this.BtnGestionCiudades_Click);
            // 
            // BtnGestionPaises
            // 
            this.BtnGestionPaises.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionPaises.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionPaises.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionPaises.Location = new System.Drawing.Point(863, 112);
            this.BtnGestionPaises.Name = "BtnGestionPaises";
            this.BtnGestionPaises.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionPaises.TabIndex = 28;
            this.BtnGestionPaises.Text = "Paises";
            this.BtnGestionPaises.UseVisualStyleBackColor = false;
            this.BtnGestionPaises.Click += new System.EventHandler(this.BtnGestionPaises_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Aeropuertos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(627, 438);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminar.TabIndex = 26;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(384, 438);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(121, 46);
            this.BtnEditar.TabIndex = 25;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(133, 438);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregar.TabIndex = 24;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvAeropuertos
            // 
            this.DgvAeropuertos.AllowUserToAddRows = false;
            this.DgvAeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAeropuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAeropuerto,
            this.NombreAeropuerto,
            this.LatitudCoordenada,
            this.LongitudCoordeada,
            this.nombreCiudad,
            this.FechaRegistro});
            this.DgvAeropuertos.Location = new System.Drawing.Point(71, 48);
            this.DgvAeropuertos.Name = "DgvAeropuertos";
            this.DgvAeropuertos.Size = new System.Drawing.Size(733, 384);
            this.DgvAeropuertos.TabIndex = 23;
            // 
            // IdAeropuerto
            // 
            this.IdAeropuerto.HeaderText = "Id";
            this.IdAeropuerto.Name = "IdAeropuerto";
            this.IdAeropuerto.ReadOnly = true;
            // 
            // NombreAeropuerto
            // 
            this.NombreAeropuerto.HeaderText = "Nombre";
            this.NombreAeropuerto.Name = "NombreAeropuerto";
            this.NombreAeropuerto.ReadOnly = true;
            // 
            // LatitudCoordenada
            // 
            this.LatitudCoordenada.HeaderText = "Latitud";
            this.LatitudCoordenada.Name = "LatitudCoordenada";
            this.LatitudCoordenada.ReadOnly = true;
            this.LatitudCoordenada.Width = 70;
            // 
            // LongitudCoordeada
            // 
            this.LongitudCoordeada.HeaderText = "Longitud";
            this.LongitudCoordeada.Name = "LongitudCoordeada";
            this.LongitudCoordeada.ReadOnly = true;
            this.LongitudCoordeada.Width = 70;
            // 
            // nombreCiudad
            // 
            this.nombreCiudad.HeaderText = "Ciudad";
            this.nombreCiudad.Name = "nombreCiudad";
            this.nombreCiudad.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 250;
            // 
            // FrmModuloAeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGestionRegiones);
            this.Controls.Add(this.BtnGestionCiudades);
            this.Controls.Add(this.BtnGestionPaises);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvAeropuertos);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModuloAeropuertos";
            this.Text = "FrmModuloAeropuertos";
            this.Load += new System.EventHandler(this.FrmModuloAeropuertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAeropuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGestionRegiones;
        private System.Windows.Forms.Button BtnGestionCiudades;
        private System.Windows.Forms.Button BtnGestionPaises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvAeropuertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatitudCoordenada;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongitudCoordeada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}