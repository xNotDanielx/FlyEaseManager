﻿namespace WindowsFormsApp1
{
    partial class FrmCiudades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvCiudades = new System.Windows.Forms.DataGridView();
            this.IdCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbRegiones = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(66, 23);
            this.BtnRegresar.TabIndex = 56;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(907, 194);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(156, 24);
            this.TxtNombre.TabIndex = 54;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(823, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(938, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Gestión";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(363, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ciudades";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(382, 438);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminar.TabIndex = 49;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(815, 438);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregar.TabIndex = 48;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvCiudades
            // 
            this.DgvCiudades.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvCiudades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCiudades.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCiudad,
            this.NombreCiudad,
            this.NombreRegion,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCiudades.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCiudades.EnableHeadersVisualStyles = false;
            this.DgvCiudades.Location = new System.Drawing.Point(90, 48);
            this.DgvCiudades.Name = "DgvCiudades";
            this.DgvCiudades.RowHeadersVisible = false;
            this.DgvCiudades.Size = new System.Drawing.Size(704, 384);
            this.DgvCiudades.TabIndex = 47;
            this.DgvCiudades.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCiudades_CellMouseClick);
            // 
            // IdCiudad
            // 
            this.IdCiudad.HeaderText = "Id de la ciudad";
            this.IdCiudad.Name = "IdCiudad";
            this.IdCiudad.ReadOnly = true;
            this.IdCiudad.Width = 150;
            // 
            // NombreCiudad
            // 
            this.NombreCiudad.HeaderText = "Nombre de la ciudad";
            this.NombreCiudad.Name = "NombreCiudad";
            this.NombreCiudad.ReadOnly = true;
            this.NombreCiudad.Width = 150;
            // 
            // NombreRegion
            // 
            this.NombreRegion.HeaderText = "Nombre de la región";
            this.NombreRegion.Name = "NombreRegion";
            this.NombreRegion.ReadOnly = true;
            this.NombreRegion.Width = 150;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 250;
            // 
            // CbRegiones
            // 
            this.CbRegiones.BackColor = System.Drawing.Color.White;
            this.CbRegiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRegiones.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbRegiones.ForeColor = System.Drawing.Color.Black;
            this.CbRegiones.FormattingEnabled = true;
            this.CbRegiones.Location = new System.Drawing.Point(907, 252);
            this.CbRegiones.Name = "CbRegiones";
            this.CbRegiones.Size = new System.Drawing.Size(156, 24);
            this.CbRegiones.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(823, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Región:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(942, 438);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 46);
            this.BtnActualizar.TabIndex = 61;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(826, 321);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(145, 95);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 62;
            this.pbImagen.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(977, 357);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(112, 23);
            this.btnSeleccionarImagen.TabIndex = 63;
            this.btnSeleccionarImagen.Text = "Seleccionar imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(823, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Imagen de la ciudad:";
            // 
            // ofdSeleccionarImagen
            // 
            this.ofdSeleccionarImagen.FileName = "openFileDialog1";
            // 
            // FrmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.CbRegiones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvCiudades);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCiudades";
            this.Text = "FrmCiudades";
            this.Load += new System.EventHandler(this.FrmCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvCiudades;
        private System.Windows.Forms.ComboBox CbRegiones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionarImagen;
    }
}