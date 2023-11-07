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
            this.BtnGestionAsientos = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(892, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Gestion";
            // 
            // BtnGestionCategorias
            // 
            this.BtnGestionCategorias.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionCategorias.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionCategorias.Location = new System.Drawing.Point(862, 315);
            this.BtnGestionCategorias.Name = "BtnGestionCategorias";
            this.BtnGestionCategorias.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionCategorias.TabIndex = 41;
            this.BtnGestionCategorias.Text = "Categorias asientos";
            this.BtnGestionCategorias.UseVisualStyleBackColor = false;
            this.BtnGestionCategorias.Click += new System.EventHandler(this.BtnGestionCategorias_Click);
            // 
            // BtnGestionAsientos
            // 
            this.BtnGestionAsientos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionAsientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionAsientos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionAsientos.Location = new System.Drawing.Point(862, 213);
            this.BtnGestionAsientos.Name = "BtnGestionAsientos";
            this.BtnGestionAsientos.Size = new System.Drawing.Size(127, 45);
            this.BtnGestionAsientos.TabIndex = 40;
            this.BtnGestionAsientos.Text = "Asientos";
            this.BtnGestionAsientos.UseVisualStyleBackColor = false;
            this.BtnGestionAsientos.Click += new System.EventHandler(this.BtnGestionAsientos_Click);
            // 
            // BtnGestionAerolineas
            // 
            this.BtnGestionAerolineas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGestionAerolineas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGestionAerolineas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionAerolineas.Location = new System.Drawing.Point(862, 111);
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
            this.label1.Location = new System.Drawing.Point(425, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Aviones";
            // 
            // BtnEliminarVuelo
            // 
            this.BtnEliminarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVuelo.Location = new System.Drawing.Point(627, 438);
            this.BtnEliminarVuelo.Name = "BtnEliminarVuelo";
            this.BtnEliminarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminarVuelo.TabIndex = 36;
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
            this.BtnEditarVuelo.TabIndex = 35;
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
            this.BtnAgregarVuelo.TabIndex = 34;
            this.BtnAgregarVuelo.Text = "Agregar";
            this.BtnAgregarVuelo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 384);
            this.dataGridView1.TabIndex = 33;
            // 
            // FrmModuloAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGestionCategorias);
            this.Controls.Add(this.BtnGestionAsientos);
            this.Controls.Add(this.BtnGestionAerolineas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarVuelo);
            this.Controls.Add(this.BtnEditarVuelo);
            this.Controls.Add(this.BtnAgregarVuelo);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.Button BtnGestionAsientos;
        private System.Windows.Forms.Button BtnGestionAerolineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarVuelo;
        private System.Windows.Forms.Button BtnEditarVuelo;
        private System.Windows.Forms.Button BtnAgregarVuelo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}