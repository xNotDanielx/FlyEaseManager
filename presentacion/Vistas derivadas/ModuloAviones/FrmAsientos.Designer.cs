﻿namespace WindowsFormsApp1
{
    partial class FrmAsientos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DgvAsientos = new System.Windows.Forms.DataGridView();
            this.IdAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisponibilidadAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbCategorias = new System.Windows.Forms.ComboBox();
            this.ChkDisponibilidad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(794, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 88;
            this.label5.Text = "Categoria: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(791, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Disponibilidad:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnActualizar.Location = new System.Drawing.Point(886, 359);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 46);
            this.BtnActualizar.TabIndex = 85;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 84;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(883, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 81;
            this.label2.Text = "Edición";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(401, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "Asientos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnEliminar.Location = new System.Drawing.Point(386, 438);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminar.TabIndex = 79;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DgvAsientos
            // 
            this.DgvAsientos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvAsientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAsientos.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAsientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAsiento,
            this.PosicionAsiento,
            this.DisponibilidadAsiento,
            this.NombreCategoria,
            this.NombreAvion,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAsientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAsientos.EnableHeadersVisualStyles = false;
            this.DgvAsientos.Location = new System.Drawing.Point(103, 48);
            this.DgvAsientos.Name = "DgvAsientos";
            this.DgvAsientos.RowHeadersVisible = false;
            this.DgvAsientos.Size = new System.Drawing.Size(664, 384);
            this.DgvAsientos.TabIndex = 77;
            this.DgvAsientos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAsientos_CellMouseClick);
            // 
            // IdAsiento
            // 
            this.IdAsiento.HeaderText = "Id";
            this.IdAsiento.Name = "IdAsiento";
            this.IdAsiento.ReadOnly = true;
            this.IdAsiento.Width = 50;
            // 
            // PosicionAsiento
            // 
            this.PosicionAsiento.HeaderText = "Posicion";
            this.PosicionAsiento.Name = "PosicionAsiento";
            this.PosicionAsiento.ReadOnly = true;
            this.PosicionAsiento.Width = 80;
            // 
            // DisponibilidadAsiento
            // 
            this.DisponibilidadAsiento.HeaderText = "Disponibilidad";
            this.DisponibilidadAsiento.Name = "DisponibilidadAsiento";
            this.DisponibilidadAsiento.ReadOnly = true;
            this.DisponibilidadAsiento.Width = 80;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Categoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            // 
            // NombreAvion
            // 
            this.NombreAvion.HeaderText = "Avion";
            this.NombreAvion.Name = "NombreAvion";
            this.NombreAvion.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 250;
            // 
            // CbCategorias
            // 
            this.CbCategorias.BackColor = System.Drawing.Color.White;
            this.CbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbCategorias.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbCategorias.ForeColor = System.Drawing.Color.Black;
            this.CbCategorias.FormattingEnabled = true;
            this.CbCategorias.Location = new System.Drawing.Point(909, 291);
            this.CbCategorias.Name = "CbCategorias";
            this.CbCategorias.Size = new System.Drawing.Size(156, 24);
            this.CbCategorias.TabIndex = 93;
            // 
            // ChkDisponibilidad
            // 
            this.ChkDisponibilidad.AutoSize = true;
            this.ChkDisponibilidad.Checked = true;
            this.ChkDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDisponibilidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.ChkDisponibilidad.ForeColor = System.Drawing.Color.Black;
            this.ChkDisponibilidad.Location = new System.Drawing.Point(909, 242);
            this.ChkDisponibilidad.Name = "ChkDisponibilidad";
            this.ChkDisponibilidad.Size = new System.Drawing.Size(98, 22);
            this.ChkDisponibilidad.TabIndex = 114;
            this.ChkDisponibilidad.Text = "Disponible";
            this.ChkDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // FrmAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1084, 485);
            this.Controls.Add(this.ChkDisponibilidad);
            this.Controls.Add(this.CbCategorias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DgvAsientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsientos";
            this.Text = "FrmAsientos";
            this.Load += new System.EventHandler(this.FrmAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DgvAsientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisponibilidadAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.ComboBox CbCategorias;
        private System.Windows.Forms.CheckBox ChkDisponibilidad;
    }
}