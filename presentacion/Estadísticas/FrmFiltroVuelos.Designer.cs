namespace WindowsFormsApp1
{
    partial class FrmFiltroVuelos
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
            this.DgvVuelos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVuelos
            // 
            this.DgvVuelos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvVuelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVuelos.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.Estado,
            this.Avion,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVuelos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvVuelos.EnableHeadersVisualStyles = false;
            this.DgvVuelos.Location = new System.Drawing.Point(29, 51);
            this.DgvVuelos.Name = "DgvVuelos";
            this.DgvVuelos.RowHeadersVisible = false;
            this.DgvVuelos.Size = new System.Drawing.Size(1045, 446);
            this.DgvVuelos.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Filtro de vuelos por estado";
            // 
            // CbEstado
            // 
            this.CbEstado.BackColor = System.Drawing.Color.White;
            this.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.ForeColor = System.Drawing.Color.Black;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(743, 11);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(168, 24);
            this.CbEstado.TabIndex = 1;
            this.CbEstado.SelectedIndexChanged += new System.EventHandler(this.CbEstado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(585, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Seleccione un estado:";
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
            // 
            // FechaDespegue
            // 
            this.FechaDespegue.HeaderText = "Fecha despegue";
            this.FechaDespegue.Name = "FechaDespegue";
            this.FechaDespegue.ReadOnly = true;
            this.FechaDespegue.Width = 112;
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
            // FrmFiltroVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFiltroVuelos";
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmFiltroVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVuelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label5;
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