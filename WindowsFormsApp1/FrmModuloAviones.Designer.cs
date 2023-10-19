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
            this.BtnGestionAsientosAsientos = new System.Windows.Forms.Button();
            this.BtnGestionAerolineas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarVuelo = new System.Windows.Forms.Button();
            this.BtnEditarVuelo = new System.Windows.Forms.Button();
            this.BtnAgregarVuelo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(910, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Gestion";
            // 
            // BtnGestionCategorias
            // 
            this.BtnGestionCategorias.BackColor = System.Drawing.Color.White;
            this.BtnGestionCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionCategorias.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionCategorias.Location = new System.Drawing.Point(880, 405);
            this.BtnGestionCategorias.Name = "BtnGestionCategorias";
            this.BtnGestionCategorias.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionCategorias.TabIndex = 41;
            this.BtnGestionCategorias.Text = "Categorias asientos";
            this.BtnGestionCategorias.UseVisualStyleBackColor = false;
            // 
            // BtnGestionAsientosAsientos
            // 
            this.BtnGestionAsientosAsientos.BackColor = System.Drawing.Color.White;
            this.BtnGestionAsientosAsientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionAsientosAsientos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionAsientosAsientos.Location = new System.Drawing.Point(880, 303);
            this.BtnGestionAsientosAsientos.Name = "BtnGestionAsientosAsientos";
            this.BtnGestionAsientosAsientos.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionAsientosAsientos.TabIndex = 40;
            this.BtnGestionAsientosAsientos.Text = "Asientos";
            this.BtnGestionAsientosAsientos.UseVisualStyleBackColor = false;
            // 
            // BtnGestionAerolineas
            // 
            this.BtnGestionAerolineas.BackColor = System.Drawing.Color.White;
            this.BtnGestionAerolineas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionAerolineas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionAerolineas.Location = new System.Drawing.Point(880, 201);
            this.BtnGestionAerolineas.Name = "BtnGestionAerolineas";
            this.BtnGestionAerolineas.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionAerolineas.TabIndex = 38;
            this.BtnGestionAerolineas.Text = "Aerolíneas";
            this.BtnGestionAerolineas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Aviones";
            // 
            // BtnEliminarVuelo
            // 
            this.BtnEliminarVuelo.BackColor = System.Drawing.Color.White;
            this.BtnEliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVuelo.Location = new System.Drawing.Point(679, 517);
            this.BtnEliminarVuelo.Name = "BtnEliminarVuelo";
            this.BtnEliminarVuelo.Size = new System.Drawing.Size(96, 31);
            this.BtnEliminarVuelo.TabIndex = 36;
            this.BtnEliminarVuelo.Text = "Eliminar";
            this.BtnEliminarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnEditarVuelo
            // 
            this.BtnEditarVuelo.BackColor = System.Drawing.Color.White;
            this.BtnEditarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarVuelo.Location = new System.Drawing.Point(416, 517);
            this.BtnEditarVuelo.Name = "BtnEditarVuelo";
            this.BtnEditarVuelo.Size = new System.Drawing.Size(96, 31);
            this.BtnEditarVuelo.TabIndex = 35;
            this.BtnEditarVuelo.Text = "Editar";
            this.BtnEditarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarVuelo
            // 
            this.BtnAgregarVuelo.BackColor = System.Drawing.Color.White;
            this.BtnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarVuelo.Location = new System.Drawing.Point(119, 517);
            this.BtnAgregarVuelo.Name = "BtnAgregarVuelo";
            this.BtnAgregarVuelo.Size = new System.Drawing.Size(96, 31);
            this.BtnAgregarVuelo.TabIndex = 34;
            this.BtnAgregarVuelo.Text = "Agregar";
            this.BtnAgregarVuelo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 418);
            this.dataGridView1.TabIndex = 33;
            // 
            // FrmModuloAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1100, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGestionCategorias);
            this.Controls.Add(this.BtnGestionAsientosAsientos);
            this.Controls.Add(this.BtnGestionAerolineas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarVuelo);
            this.Controls.Add(this.BtnEditarVuelo);
            this.Controls.Add(this.BtnAgregarVuelo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModuloAviones";
            this.Text = "FrmModuloAviones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGestionCategorias;
        private System.Windows.Forms.Button BtnGestionAsientosAsientos;
        private System.Windows.Forms.Button BtnGestionAerolineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarVuelo;
        private System.Windows.Forms.Button BtnEditarVuelo;
        private System.Windows.Forms.Button BtnAgregarVuelo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}