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
            this.BtnGestionCoordenadas = new System.Windows.Forms.Button();
            this.BtnGestionRegiones = new System.Windows.Forms.Button();
            this.BtnGestionCiudades = new System.Windows.Forms.Button();
            this.BtnGestionPaises = new System.Windows.Forms.Button();
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(939, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Gestion";
            // 
            // BtnGestionCoordenadas
            // 
            this.BtnGestionCoordenadas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionCoordenadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionCoordenadas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionCoordenadas.Location = new System.Drawing.Point(914, 285);
            this.BtnGestionCoordenadas.Name = "BtnGestionCoordenadas";
            this.BtnGestionCoordenadas.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionCoordenadas.TabIndex = 31;
            this.BtnGestionCoordenadas.Text = "Coordenadas";
            this.BtnGestionCoordenadas.UseVisualStyleBackColor = false;
            // 
            // BtnGestionRegiones
            // 
            this.BtnGestionRegiones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionRegiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionRegiones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionRegiones.Location = new System.Drawing.Point(914, 183);
            this.BtnGestionRegiones.Name = "BtnGestionRegiones";
            this.BtnGestionRegiones.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionRegiones.TabIndex = 30;
            this.BtnGestionRegiones.Text = "Regiones";
            this.BtnGestionRegiones.UseVisualStyleBackColor = false;
            // 
            // BtnGestionCiudades
            // 
            this.BtnGestionCiudades.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionCiudades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionCiudades.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionCiudades.Location = new System.Drawing.Point(914, 387);
            this.BtnGestionCiudades.Name = "BtnGestionCiudades";
            this.BtnGestionCiudades.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionCiudades.TabIndex = 29;
            this.BtnGestionCiudades.Text = "Ciudades";
            this.BtnGestionCiudades.UseVisualStyleBackColor = false;
            // 
            // BtnGestionPaises
            // 
            this.BtnGestionPaises.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionPaises.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionPaises.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionPaises.Location = new System.Drawing.Point(914, 81);
            this.BtnGestionPaises.Name = "BtnGestionPaises";
            this.BtnGestionPaises.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionPaises.TabIndex = 28;
            this.BtnGestionPaises.Text = "Paises";
            this.BtnGestionPaises.UseVisualStyleBackColor = false;
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
            // BtnEliminarVuelo
            // 
            this.BtnEliminarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVuelo.Location = new System.Drawing.Point(627, 438);
            this.BtnEliminarVuelo.Name = "BtnEliminarVuelo";
            this.BtnEliminarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminarVuelo.TabIndex = 26;
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
            this.BtnEditarVuelo.TabIndex = 25;
            this.BtnEditarVuelo.Text = "Editar";
            this.BtnEditarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarVuelo
            // 
            this.BtnAgregarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarVuelo.Location = new System.Drawing.Point(133, 438);
            this.BtnAgregarVuelo.Name = "BtnAgregarVuelo";
            this.BtnAgregarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregarVuelo.TabIndex = 24;
            this.BtnAgregarVuelo.Text = "Agregar";
            this.BtnAgregarVuelo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 384);
            this.dataGridView1.TabIndex = 23;
            // 
            // FrmModuloAeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGestionCoordenadas);
            this.Controls.Add(this.BtnGestionRegiones);
            this.Controls.Add(this.BtnGestionCiudades);
            this.Controls.Add(this.BtnGestionPaises);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarVuelo);
            this.Controls.Add(this.BtnEditarVuelo);
            this.Controls.Add(this.BtnAgregarVuelo);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModuloAeropuertos";
            this.Text = "FrmModuloAeropuertos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGestionCoordenadas;
        private System.Windows.Forms.Button BtnGestionRegiones;
        private System.Windows.Forms.Button BtnGestionCiudades;
        private System.Windows.Forms.Button BtnGestionPaises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarVuelo;
        private System.Windows.Forms.Button BtnEditarVuelo;
        private System.Windows.Forms.Button BtnAgregarVuelo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}