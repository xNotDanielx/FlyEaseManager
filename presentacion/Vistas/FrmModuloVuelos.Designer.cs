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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarVuelo = new System.Windows.Forms.Button();
            this.BtnEditarVuelo = new System.Windows.Forms.Button();
            this.BtnAgregarVuelo = new System.Windows.Forms.Button();
            this.DgvVuelos = new System.Windows.Forms.DataGridView();
            this.IdVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarifaVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaRecorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDespegue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoDespegue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGestionEstado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vuelos";
            // 
            // BtnEliminarVuelo
            // 
            this.BtnEliminarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVuelo.Location = new System.Drawing.Point(627, 438);
            this.BtnEliminarVuelo.Name = "BtnEliminarVuelo";
            this.BtnEliminarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminarVuelo.TabIndex = 16;
            this.BtnEliminarVuelo.Text = "Eliminar";
            this.BtnEliminarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnEditarVuelo
            // 
            this.BtnEditarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEditarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarVuelo.Location = new System.Drawing.Point(384, 438);
            this.BtnEditarVuelo.Name = "BtnEditarVuelo";
            this.BtnEditarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEditarVuelo.TabIndex = 15;
            this.BtnEditarVuelo.Text = "Editar";
            this.BtnEditarVuelo.UseVisualStyleBackColor = false;
            this.BtnEditarVuelo.Click += new System.EventHandler(this.BtnEditarVuelo_Click);
            // 
            // BtnAgregarVuelo
            // 
            this.BtnAgregarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarVuelo.Location = new System.Drawing.Point(133, 438);
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
            this.Estado,
            this.Avion,
            this.FechaRegistro});
            this.DgvVuelos.Location = new System.Drawing.Point(0, 48);
            this.DgvVuelos.Name = "DgvVuelos";
            this.DgvVuelos.Size = new System.Drawing.Size(961, 384);
            this.DgvVuelos.TabIndex = 13;
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
            // BtnGestionEstado
            // 
            this.BtnGestionEstado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionEstado.Location = new System.Drawing.Point(967, 223);
            this.BtnGestionEstado.Name = "BtnGestionEstado";
            this.BtnGestionEstado.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionEstado.TabIndex = 20;
            this.BtnGestionEstado.Text = "Estado vuelos";
            this.BtnGestionEstado.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(995, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gestion";
            // 
            // FrmModuloVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGestionEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarVuelo);
            this.Controls.Add(this.BtnEditarVuelo);
            this.Controls.Add(this.BtnAgregarVuelo);
            this.Controls.Add(this.DgvVuelos);
            this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.Button BtnGestionEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarifaVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaRecorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDespegue;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoDespegue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}