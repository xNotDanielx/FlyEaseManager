namespace WindowsFormsApp1
{
    partial class FrmEditarAvion
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
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CbAerolinea = new System.Windows.Forms.ComboBox();
            this.TxtCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCatidadCarga = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtVelocidad = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(500, 366);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 46);
            this.BtnActualizar.TabIndex = 168;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(607, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 167;
            this.label9.Text = "Aerolínea:";
            // 
            // CbAerolinea
            // 
            this.CbAerolinea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbAerolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAerolinea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbAerolinea.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAerolinea.ForeColor = System.Drawing.Color.White;
            this.CbAerolinea.FormattingEnabled = true;
            this.CbAerolinea.Location = new System.Drawing.Point(714, 281);
            this.CbAerolinea.Name = "CbAerolinea";
            this.CbAerolinea.Size = new System.Drawing.Size(200, 24);
            this.CbAerolinea.TabIndex = 8;
            // 
            // TxtCantidadPasajeros
            // 
            this.TxtCantidadPasajeros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCantidadPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidadPasajeros.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtCantidadPasajeros.ForeColor = System.Drawing.Color.White;
            this.TxtCantidadPasajeros.Location = new System.Drawing.Point(714, 216);
            this.TxtCantidadPasajeros.Name = "TxtCantidadPasajeros";
            this.TxtCantidadPasajeros.Size = new System.Drawing.Size(200, 24);
            this.TxtCantidadPasajeros.TabIndex = 7;
            this.TxtCantidadPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadPasajeros_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(541, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 164;
            this.label8.Text = "Cantidad carga(KG):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(541, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 163;
            this.label5.Text = "Velocidad Promedio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(172, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 162;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(256, 151);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 24);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(544, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 160;
            this.label7.Text = "Cantidad pasajeros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(158, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 159;
            this.label4.Text = "Fabricante:";
            // 
            // TxtFabricante
            // 
            this.TxtFabricante.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFabricante.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtFabricante.ForeColor = System.Drawing.Color.White;
            this.TxtFabricante.Location = new System.Drawing.Point(256, 281);
            this.TxtFabricante.Name = "TxtFabricante";
            this.TxtFabricante.Size = new System.Drawing.Size(200, 24);
            this.TxtFabricante.TabIndex = 4;
            this.TxtFabricante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFabricante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(176, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 157;
            this.label1.Text = "Modelo:";
            // 
            // TxtCatidadCarga
            // 
            this.TxtCatidadCarga.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCatidadCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCatidadCarga.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtCatidadCarga.ForeColor = System.Drawing.Color.White;
            this.TxtCatidadCarga.Location = new System.Drawing.Point(714, 151);
            this.TxtCatidadCarga.Name = "TxtCatidadCarga";
            this.TxtCatidadCarga.Size = new System.Drawing.Size(200, 24);
            this.TxtCatidadCarga.TabIndex = 6;
            this.TxtCatidadCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCatidadCarga_KeyPress);
            // 
            // TxtModelo
            // 
            this.TxtModelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtModelo.ForeColor = System.Drawing.Color.White;
            this.TxtModelo.Location = new System.Drawing.Point(256, 216);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(200, 24);
            this.TxtModelo.TabIndex = 3;
            this.TxtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModelo_KeyPress);
            // 
            // TxtVelocidad
            // 
            this.TxtVelocidad.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVelocidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtVelocidad.ForeColor = System.Drawing.Color.White;
            this.TxtVelocidad.Location = new System.Drawing.Point(714, 85);
            this.TxtVelocidad.Name = "TxtVelocidad";
            this.TxtVelocidad.Size = new System.Drawing.Size(200, 24);
            this.TxtVelocidad.TabIndex = 5;
            this.TxtVelocidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVelocidad_KeyPress);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 153;
            this.BtnRegresar.Text = "<Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(495, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 152;
            this.label3.Text = "Editar avion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(205, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 18);
            this.label6.TabIndex = 170;
            this.label6.Text = "id:";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtId.ForeColor = System.Drawing.Color.White;
            this.TxtId.Location = new System.Drawing.Point(256, 85);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(200, 24);
            this.TxtId.TabIndex = 1;
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // FrmEditarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbAerolinea);
            this.Controls.Add(this.TxtCantidadPasajeros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFabricante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCatidadCarga);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtVelocidad);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarAvion";
            this.Text = "FrmEditarAviones";
            this.Load += new System.EventHandler(this.FrmEditarAvion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbAerolinea;
        private System.Windows.Forms.TextBox TxtCantidadPasajeros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCatidadCarga;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtVelocidad;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtId;
    }
}