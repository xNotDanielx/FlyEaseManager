namespace WindowsFormsApp1
{
    partial class FrmAgregarAvion
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
            this.label6 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CbAerolinea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCatidadCarga = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtVelocidad = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAsientosPremium = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtAsientosEconomicos = new System.Windows.Forms.TextBox();
            this.TxtCantidadAsietos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAsientosNoComerciales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(172, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 189;
            this.label6.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.White;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtId.ForeColor = System.Drawing.Color.Black;
            this.TxtId.Location = new System.Drawing.Point(216, 91);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(200, 24);
            this.TxtId.TabIndex = 1;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnAgregar.Location = new System.Drawing.Point(549, 413);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregar.TabIndex = 187;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(675, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 186;
            this.label9.Text = "Aerolínea:";
            // 
            // CbAerolinea
            // 
            this.CbAerolinea.BackColor = System.Drawing.Color.White;
            this.CbAerolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAerolinea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbAerolinea.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAerolinea.ForeColor = System.Drawing.Color.Black;
            this.CbAerolinea.FormattingEnabled = true;
            this.CbAerolinea.Location = new System.Drawing.Point(775, 356);
            this.CbAerolinea.Name = "CbAerolinea";
            this.CbAerolinea.Size = new System.Drawing.Size(200, 24);
            this.CbAerolinea.TabIndex = 11;
            this.CbAerolinea.SelectedIndexChanged += new System.EventHandler(this.CbAerolinea_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(54, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 16);
            this.label8.TabIndex = 183;
            this.label8.Text = "Cantidad carga(KG):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 16);
            this.label5.TabIndex = 182;
            this.label5.Text = "Velocidad Promedio(KM/h):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 181;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(216, 162);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 24);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(115, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 178;
            this.label4.Text = "Fabricante:";
            // 
            // TxtFabricante
            // 
            this.TxtFabricante.BackColor = System.Drawing.Color.White;
            this.TxtFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFabricante.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtFabricante.ForeColor = System.Drawing.Color.Black;
            this.TxtFabricante.Location = new System.Drawing.Point(216, 297);
            this.TxtFabricante.Name = "TxtFabricante";
            this.TxtFabricante.Size = new System.Drawing.Size(200, 24);
            this.TxtFabricante.TabIndex = 4;
            this.TxtFabricante.TextChanged += new System.EventHandler(this.TxtFabricante_TextChanged);
            this.TxtFabricante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFabricante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(133, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 176;
            this.label1.Text = "Modelo:";
            // 
            // TxtCatidadCarga
            // 
            this.TxtCatidadCarga.BackColor = System.Drawing.Color.White;
            this.TxtCatidadCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCatidadCarga.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtCatidadCarga.ForeColor = System.Drawing.Color.Black;
            this.TxtCatidadCarga.Location = new System.Drawing.Point(216, 413);
            this.TxtCatidadCarga.Name = "TxtCatidadCarga";
            this.TxtCatidadCarga.Size = new System.Drawing.Size(200, 24);
            this.TxtCatidadCarga.TabIndex = 6;
            this.TxtCatidadCarga.TextChanged += new System.EventHandler(this.TxtCatidadCarga_TextChanged);
            this.TxtCatidadCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCatidadCarga_KeyPress);
            // 
            // TxtModelo
            // 
            this.TxtModelo.BackColor = System.Drawing.Color.White;
            this.TxtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtModelo.ForeColor = System.Drawing.Color.Black;
            this.TxtModelo.Location = new System.Drawing.Point(216, 234);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(200, 24);
            this.TxtModelo.TabIndex = 3;
            this.TxtModelo.TextChanged += new System.EventHandler(this.TxtModelo_TextChanged);
            this.TxtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModelo_KeyPress);
            // 
            // TxtVelocidad
            // 
            this.TxtVelocidad.BackColor = System.Drawing.Color.White;
            this.TxtVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVelocidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtVelocidad.ForeColor = System.Drawing.Color.Black;
            this.TxtVelocidad.Location = new System.Drawing.Point(216, 357);
            this.TxtVelocidad.Name = "TxtVelocidad";
            this.TxtVelocidad.Size = new System.Drawing.Size(200, 24);
            this.TxtVelocidad.TabIndex = 5;
            this.TxtVelocidad.TextChanged += new System.EventHandler(this.TxtVelocidad_TextChanged);
            this.TxtVelocidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVelocidad_KeyPress);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 172;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(495, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 171;
            this.label3.Text = "Agregar avión";
            // 
            // TxtAsientosPremium
            // 
            this.TxtAsientosPremium.BackColor = System.Drawing.Color.White;
            this.TxtAsientosPremium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAsientosPremium.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtAsientosPremium.ForeColor = System.Drawing.Color.Black;
            this.TxtAsientosPremium.Location = new System.Drawing.Point(775, 162);
            this.TxtAsientosPremium.Name = "TxtAsientosPremium";
            this.TxtAsientosPremium.Size = new System.Drawing.Size(200, 24);
            this.TxtAsientosPremium.TabIndex = 8;
            this.TxtAsientosPremium.TextChanged += new System.EventHandler(this.TxtAsientosPremium_TextChanged);
            this.TxtAsientosPremium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAsientosPremium_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(562, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 16);
            this.label13.TabIndex = 194;
            this.label13.Text = "Número asientos Premium:";
            // 
            // TxtAsientosEconomicos
            // 
            this.TxtAsientosEconomicos.BackColor = System.Drawing.Color.White;
            this.TxtAsientosEconomicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAsientosEconomicos.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtAsientosEconomicos.ForeColor = System.Drawing.Color.Black;
            this.TxtAsientosEconomicos.Location = new System.Drawing.Point(775, 234);
            this.TxtAsientosEconomicos.Name = "TxtAsientosEconomicos";
            this.TxtAsientosEconomicos.Size = new System.Drawing.Size(200, 24);
            this.TxtAsientosEconomicos.TabIndex = 9;
            this.TxtAsientosEconomicos.TextChanged += new System.EventHandler(this.TxtAsientosEconomicos_TextChanged);
            this.TxtAsientosEconomicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAsientosEconomicos_KeyPress);
            // 
            // TxtCantidadAsietos
            // 
            this.TxtCantidadAsietos.BackColor = System.Drawing.Color.White;
            this.TxtCantidadAsietos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidadAsietos.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtCantidadAsietos.ForeColor = System.Drawing.Color.Black;
            this.TxtCantidadAsietos.Location = new System.Drawing.Point(775, 95);
            this.TxtCantidadAsietos.Name = "TxtCantidadAsietos";
            this.TxtCantidadAsietos.Size = new System.Drawing.Size(200, 24);
            this.TxtCantidadAsietos.TabIndex = 7;
            this.TxtCantidadAsietos.TextChanged += new System.EventHandler(this.TxtCantidadAsietos_TextChanged);
            this.TxtCantidadAsietos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadAsietos_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(544, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 16);
            this.label12.TabIndex = 191;
            this.label12.Text = "Número asientos Economicos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(538, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 16);
            this.label11.TabIndex = 190;
            this.label11.Text = "Cantidad asientos comerciales:";
            // 
            // txtAsientosNoComerciales
            // 
            this.txtAsientosNoComerciales.BackColor = System.Drawing.Color.White;
            this.txtAsientosNoComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsientosNoComerciales.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.txtAsientosNoComerciales.ForeColor = System.Drawing.Color.Black;
            this.txtAsientosNoComerciales.Location = new System.Drawing.Point(775, 293);
            this.txtAsientosNoComerciales.Name = "txtAsientosNoComerciales";
            this.txtAsientosNoComerciales.Size = new System.Drawing.Size(200, 24);
            this.txtAsientosNoComerciales.TabIndex = 10;
            this.txtAsientosNoComerciales.TextChanged += new System.EventHandler(this.txtAsientosNoComerciales_TextChanged);
            this.txtAsientosNoComerciales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsientosNoComerciales_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(522, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 16);
            this.label7.TabIndex = 197;
            this.label7.Text = "Número asientos no comerciales:";
            // 
            // FrmAgregarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAsientosNoComerciales);
            this.Controls.Add(this.TxtAsientosPremium);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtAsientosEconomicos);
            this.Controls.Add(this.TxtCantidadAsietos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbAerolinea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFabricante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCatidadCarga);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtVelocidad);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarAvion";
            this.Text = "FrmAgregarAvion";
            this.Load += new System.EventHandler(this.FrmAgregarAvion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbAerolinea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCatidadCarga;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtVelocidad;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAsientosPremium;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtAsientosEconomicos;
        private System.Windows.Forms.TextBox TxtCantidadAsietos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAsientosNoComerciales;
        private System.Windows.Forms.Label label7;
    }
}