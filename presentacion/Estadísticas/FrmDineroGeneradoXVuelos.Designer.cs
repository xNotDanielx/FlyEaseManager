namespace WindowsFormsApp1
{
    partial class FrmDineroGeneradoXVuelos
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
            this.DgvDineroGenerado = new System.Windows.Forms.DataGridView();
            this.IdVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDineroGenerado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDineroGenerado
            // 
            this.DgvDineroGenerado.AllowUserToAddRows = false;
            this.DgvDineroGenerado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDineroGenerado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVuelo,
            this.IdBoleto,
            this.Pagado});
            this.DgvDineroGenerado.Location = new System.Drawing.Point(101, 122);
            this.DgvDineroGenerado.Name = "DgvDineroGenerado";
            this.DgvDineroGenerado.RowHeadersVisible = false;
            this.DgvDineroGenerado.Size = new System.Drawing.Size(403, 348);
            this.DgvDineroGenerado.TabIndex = 0;
            // 
            // IdVuelo
            // 
            this.IdVuelo.HeaderText = "Id del vuelo";
            this.IdVuelo.Name = "IdVuelo";
            this.IdVuelo.ReadOnly = true;
            // 
            // IdBoleto
            // 
            this.IdBoleto.HeaderText = "IdBoleto";
            this.IdBoleto.Name = "IdBoleto";
            // 
            // Pagado
            // 
            this.Pagado.HeaderText = "Dinero pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.ReadOnly = true;
            this.Pagado.Width = 200;
            // 
            // CbAno
            // 
            this.CbAno.BackColor = System.Drawing.Color.White;
            this.CbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAno.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAno.ForeColor = System.Drawing.Color.Black;
            this.CbAno.FormattingEnabled = true;
            this.CbAno.Location = new System.Drawing.Point(784, 95);
            this.CbAno.Name = "CbAno";
            this.CbAno.Size = new System.Drawing.Size(168, 24);
            this.CbAno.TabIndex = 2;
            this.CbAno.SelectedIndexChanged += new System.EventHandler(this.CbAno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(635, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 87;
            this.label1.Text = "Total";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Black;
            this.LblTotal.Location = new System.Drawing.Point(780, 148);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(17, 23);
            this.LblTotal.TabIndex = 88;
            this.LblTotal.Text = ".";
            this.LblTotal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(497, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 89;
            this.label2.Text = "Dinero generado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(562, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 90;
            this.label3.Text = "Seleccione un año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(218, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 23);
            this.label4.TabIndex = 91;
            this.label4.Text = "Boletos vendidos";
            // 
            // FrmDineroGeneradoXVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbAno);
            this.Controls.Add(this.DgvDineroGenerado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDineroGeneradoXVuelos";
            this.Text = "FrmDineroGeneradoXVuelos";
            this.Load += new System.EventHandler(this.FrmDineroGeneradoXVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDineroGenerado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDineroGenerado;
        private System.Windows.Forms.ComboBox CbAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.Label label4;
    }
}