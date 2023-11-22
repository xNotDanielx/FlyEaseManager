namespace WindowsFormsApp1
{
    partial class FrmModuloVuelos
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarVuelo = new System.Windows.Forms.Button();
            this.BtnEditarVuelo = new System.Windows.Forms.Button();
            this.BtnAgregarVuelo = new System.Windows.Forms.Button();
            this.DgvVuelos = new System.Windows.Forms.DataGridView();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.IdVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarifaVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaRecorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDespegue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoDespegue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(571, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vuelos";
            // 
            // BtnEliminarVuelo
            // 
            this.BtnEliminarVuelo.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarVuelo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVuelo.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnEliminarVuelo.Location = new System.Drawing.Point(575, 438);
            this.BtnEliminarVuelo.Name = "BtnEliminarVuelo";
            this.BtnEliminarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminarVuelo.TabIndex = 16;
            this.BtnEliminarVuelo.Text = "Eliminar";
            this.BtnEliminarVuelo.UseVisualStyleBackColor = false;
            this.BtnEliminarVuelo.Click += new System.EventHandler(this.BtnEliminarVuelo_Click);
            // 
            // BtnEditarVuelo
            // 
            this.BtnEditarVuelo.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEditarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarVuelo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarVuelo.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnEditarVuelo.Location = new System.Drawing.Point(380, 438);
            this.BtnEditarVuelo.Name = "BtnEditarVuelo";
            this.BtnEditarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEditarVuelo.TabIndex = 15;
            this.BtnEditarVuelo.Text = "Editar";
            this.BtnEditarVuelo.UseVisualStyleBackColor = false;
            this.BtnEditarVuelo.Click += new System.EventHandler(this.BtnEditarVuelo_Click);
            // 
            // BtnAgregarVuelo
            // 
            this.BtnAgregarVuelo.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarVuelo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarVuelo.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnAgregarVuelo.Location = new System.Drawing.Point(179, 438);
            this.BtnAgregarVuelo.Name = "BtnAgregarVuelo";
            this.BtnAgregarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregarVuelo.TabIndex = 14;
            this.BtnAgregarVuelo.Text = "Agregar";
            this.BtnAgregarVuelo.UseVisualStyleBackColor = false;
            this.BtnAgregarVuelo.Click += new System.EventHandler(this.BtnAgregarVuelo_Click);
            // 
            // DgvVuelos
            // 
            this.DgvVuelos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvVuelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVuelos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.DgvVuelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgvVuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVuelo,
            this.PrecioVuelo,
            this.TarifaVuelo,
            this.DescuentoVuelo,
            this.DistanciaRecorrida,
            this.FechaDespegue,
            this.FechaLlegada,
            this.AeropuertoDespegue,
            this.AeropuertoDestino,
            this.Cupo,
            this.Estado,
            this.Avion,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVuelos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvVuelos.EnableHeadersVisualStyles = false;
            this.DgvVuelos.Location = new System.Drawing.Point(25, 48);
            this.DgvVuelos.Name = "DgvVuelos";
            this.DgvVuelos.RowHeadersVisible = false;
            this.DgvVuelos.RowTemplate.Height = 30;
            this.DgvVuelos.Size = new System.Drawing.Size(1054, 384);
            this.DgvVuelos.TabIndex = 13;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnRegresar.Location = new System.Drawing.Point(770, 438);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(121, 46);
            this.BtnRegresar.TabIndex = 58;
            this.BtnRegresar.Text = "Ver Estados";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // IdVuelo
            // 
            this.IdVuelo.HeaderText = "Id";
            this.IdVuelo.Name = "IdVuelo";
            this.IdVuelo.ReadOnly = true;
            this.IdVuelo.Width = 50;
            // 
            // PrecioVuelo
            // 
            this.PrecioVuelo.HeaderText = "Precio";
            this.PrecioVuelo.Name = "PrecioVuelo";
            this.PrecioVuelo.ReadOnly = true;
            this.PrecioVuelo.Width = 80;
            // 
            // TarifaVuelo
            // 
            this.TarifaVuelo.HeaderText = "Tarifa";
            this.TarifaVuelo.Name = "TarifaVuelo";
            this.TarifaVuelo.ReadOnly = true;
            this.TarifaVuelo.Width = 80;
            // 
            // DescuentoVuelo
            // 
            this.DescuentoVuelo.HeaderText = "Descuento";
            this.DescuentoVuelo.Name = "DescuentoVuelo";
            this.DescuentoVuelo.ReadOnly = true;
            this.DescuentoVuelo.Width = 80;
            // 
            // DistanciaRecorrida
            // 
            this.DistanciaRecorrida.HeaderText = "Distancia recorrida";
            this.DistanciaRecorrida.Name = "DistanciaRecorrida";
            this.DistanciaRecorrida.ReadOnly = true;
            this.DistanciaRecorrida.Width = 80;
            // 
            // FechaDespegue
            // 
            this.FechaDespegue.HeaderText = "Fecha despegue";
            this.FechaDespegue.Name = "FechaDespegue";
            this.FechaDespegue.ReadOnly = true;
            // 
            // FechaLlegada
            // 
            this.FechaLlegada.HeaderText = "Fecha llegada";
            this.FechaLlegada.Name = "FechaLlegada";
            this.FechaLlegada.ReadOnly = true;
            // 
            // AeropuertoDespegue
            // 
            this.AeropuertoDespegue.HeaderText = "Despegue";
            this.AeropuertoDespegue.Name = "AeropuertoDespegue";
            this.AeropuertoDespegue.ReadOnly = true;
            this.AeropuertoDespegue.Width = 80;
            // 
            // AeropuertoDestino
            // 
            this.AeropuertoDestino.HeaderText = "Destino";
            this.AeropuertoDestino.Name = "AeropuertoDestino";
            this.AeropuertoDestino.ReadOnly = true;
            this.AeropuertoDestino.Width = 80;
            // 
            // Cupo
            // 
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.Width = 60;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // Avion
            // 
            this.Avion.HeaderText = "Avion";
            this.Avion.Name = "Avion";
            this.Avion.ReadOnly = true;
            this.Avion.Width = 80;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // FrmModuloVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarVuelo);
            this.Controls.Add(this.BtnEditarVuelo);
            this.Controls.Add(this.BtnAgregarVuelo);
            this.Controls.Add(this.DgvVuelos);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModuloVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModuloVuelos";
            this.Load += new System.EventHandler(this.FrmModuloVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarVuelo;
        private System.Windows.Forms.Button BtnEditarVuelo;
        private System.Windows.Forms.Button BtnAgregarVuelo;
        private System.Windows.Forms.DataGridView DgvVuelos;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarifaVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaRecorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDespegue;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoDespegue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}