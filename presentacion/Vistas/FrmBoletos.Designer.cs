namespace WindowsFormsApp1
{
    partial class FrmBoletos
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
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBoletos = new System.Windows.Forms.DataGridView();
            this.IdBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDescuento.ForeColor = System.Drawing.Color.White;
            this.TxtDescuento.Location = new System.Drawing.Point(444, 473);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(106, 24);
            this.TxtDescuento.TabIndex = 94;
            this.TxtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescuento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(319, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "Descuento (%):";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(595, 460);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 46);
            this.BtnActualizar.TabIndex = 90;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Gestión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Boletos";
            // 
            // DgvBoletos
            // 
            this.DgvBoletos.AllowUserToAddRows = false;
            this.DgvBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBoletos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBoleto,
            this.PrecioBoleto,
            this.DescuentoBoleto,
            this.PrecioTotal,
            this.Documento,
            this.PosicionAsiento,
            this.Categoria,
            this.IdVuelo,
            this.FechaSalida,
            this.IdAvion,
            this.FechaRegistro});
            this.DgvBoletos.Location = new System.Drawing.Point(12, 35);
            this.DgvBoletos.Name = "DgvBoletos";
            this.DgvBoletos.RowHeadersVisible = false;
            this.DgvBoletos.Size = new System.Drawing.Size(997, 406);
            this.DgvBoletos.TabIndex = 83;
            this.DgvBoletos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBoletos_CellMouseClick);
            // 
            // IdBoleto
            // 
            this.IdBoleto.HeaderText = "Id";
            this.IdBoleto.Name = "IdBoleto";
            this.IdBoleto.ReadOnly = true;
            this.IdBoleto.Width = 40;
            // 
            // PrecioBoleto
            // 
            this.PrecioBoleto.HeaderText = "Precio";
            this.PrecioBoleto.Name = "PrecioBoleto";
            this.PrecioBoleto.ReadOnly = true;
            // 
            // DescuentoBoleto
            // 
            this.DescuentoBoleto.HeaderText = "Descuento";
            this.DescuentoBoleto.Name = "DescuentoBoleto";
            this.DescuentoBoleto.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // PosicionAsiento
            // 
            this.PosicionAsiento.HeaderText = "Asiento";
            this.PosicionAsiento.Name = "PosicionAsiento";
            this.PosicionAsiento.ReadOnly = true;
            this.PosicionAsiento.Width = 80;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // IdVuelo
            // 
            this.IdVuelo.HeaderText = "Vuelo";
            this.IdVuelo.Name = "IdVuelo";
            this.IdVuelo.ReadOnly = true;
            this.IdVuelo.Width = 80;
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "Fecha salida";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            // 
            // IdAvion
            // 
            this.IdAvion.HeaderText = "Avion";
            this.IdAvion.Name = "IdAvion";
            this.IdAvion.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // FrmBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvBoletos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBoletos";
            this.Text = "FrmBoletos";
            this.Load += new System.EventHandler(this.FrmBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvBoletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}