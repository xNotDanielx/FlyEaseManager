namespace WindowsFormsApp1
{
    partial class FrmAgregarVuelos
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbAvion = new System.Windows.Forms.ComboBox();
            this.TxtAsientosPremium = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtAsientosEconomicos = new System.Windows.Forms.TextBox();
            this.TxtCantidadAsietos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CbDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbDespegue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.DtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTarifa = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.ChkCupo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(474, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registrar vuelo";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 57;
            this.BtnRegresar.Text = "<Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(612, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 121;
            this.label10.Text = "Estado";
            // 
            // CbEstado
            // 
            this.CbEstado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbEstado.ForeColor = System.Drawing.Color.White;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(828, 407);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(200, 24);
            this.CbEstado.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(612, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 119;
            this.label9.Text = "Avion:";
            // 
            // CbAvion
            // 
            this.CbAvion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbAvion.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAvion.ForeColor = System.Drawing.Color.White;
            this.CbAvion.FormattingEnabled = true;
            this.CbAvion.Location = new System.Drawing.Point(828, 336);
            this.CbAvion.Name = "CbAvion";
            this.CbAvion.Size = new System.Drawing.Size(200, 24);
            this.CbAvion.TabIndex = 118;
            // 
            // TxtAsientosPremium
            // 
            this.TxtAsientosPremium.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtAsientosPremium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAsientosPremium.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtAsientosPremium.ForeColor = System.Drawing.Color.White;
            this.TxtAsientosPremium.Location = new System.Drawing.Point(303, 340);
            this.TxtAsientosPremium.Name = "TxtAsientosPremium";
            this.TxtAsientosPremium.Size = new System.Drawing.Size(200, 24);
            this.TxtAsientosPremium.TabIndex = 117;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(72, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 18);
            this.label13.TabIndex = 116;
            this.label13.Text = "Numero asientos Premium:";
            // 
            // TxtAsientosEconomicos
            // 
            this.TxtAsientosEconomicos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtAsientosEconomicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAsientosEconomicos.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtAsientosEconomicos.ForeColor = System.Drawing.Color.White;
            this.TxtAsientosEconomicos.Location = new System.Drawing.Point(303, 408);
            this.TxtAsientosEconomicos.Name = "TxtAsientosEconomicos";
            this.TxtAsientosEconomicos.Size = new System.Drawing.Size(200, 24);
            this.TxtAsientosEconomicos.TabIndex = 115;
            // 
            // TxtCantidadAsietos
            // 
            this.TxtCantidadAsietos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCantidadAsietos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidadAsietos.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtCantidadAsietos.ForeColor = System.Drawing.Color.White;
            this.TxtCantidadAsietos.Location = new System.Drawing.Point(303, 272);
            this.TxtCantidadAsietos.Name = "TxtCantidadAsietos";
            this.TxtCantidadAsietos.Size = new System.Drawing.Size(200, 24);
            this.TxtCantidadAsietos.TabIndex = 114;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(72, 410);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 18);
            this.label12.TabIndex = 113;
            this.label12.Text = "Numero asientos Economicos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(72, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 112;
            this.label11.Text = "Cantidad asientos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(616, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 111;
            this.label8.Text = "Destino:";
            // 
            // CbDestino
            // 
            this.CbDestino.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDestino.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbDestino.ForeColor = System.Drawing.Color.White;
            this.CbDestino.FormattingEnabled = true;
            this.CbDestino.Location = new System.Drawing.Point(828, 197);
            this.CbDestino.Name = "CbDestino";
            this.CbDestino.Size = new System.Drawing.Size(200, 24);
            this.CbDestino.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(616, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 109;
            this.label5.Text = "Despegue:";
            // 
            // CbDespegue
            // 
            this.CbDespegue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbDespegue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDespegue.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbDespegue.ForeColor = System.Drawing.Color.White;
            this.CbDespegue.FormattingEnabled = true;
            this.CbDespegue.Location = new System.Drawing.Point(828, 121);
            this.CbDespegue.Name = "CbDespegue";
            this.CbDespegue.Size = new System.Drawing.Size(200, 24);
            this.CbDespegue.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtPrecio.ForeColor = System.Drawing.Color.White;
            this.TxtPrecio.Location = new System.Drawing.Point(303, 49);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(200, 24);
            this.TxtPrecio.TabIndex = 106;
            // 
            // DtpFechaSalida
            // 
            this.DtpFechaSalida.CalendarForeColor = System.Drawing.Color.White;
            this.DtpFechaSalida.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.DtpFechaSalida.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpFechaSalida.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DtpFechaSalida.CustomFormat = "d/MM/yyyy HH:mm";
            this.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaSalida.Location = new System.Drawing.Point(303, 203);
            this.DtpFechaSalida.Name = "DtpFechaSalida";
            this.DtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaSalida.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 104;
            this.label7.Text = "Fecha y hora salida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(616, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 103;
            this.label6.Text = "Cupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(72, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Descuento:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDescuento.ForeColor = System.Drawing.Color.White;
            this.TxtDescuento.Location = new System.Drawing.Point(303, 122);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(200, 24);
            this.TxtDescuento.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(616, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "Tarifa:";
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTarifa.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtTarifa.ForeColor = System.Drawing.Color.White;
            this.TxtTarifa.Location = new System.Drawing.Point(828, 49);
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Size = new System.Drawing.Size(200, 24);
            this.TxtTarifa.TabIndex = 98;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(498, 438);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(121, 46);
            this.BtnGuardar.TabIndex = 122;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // ChkCupo
            // 
            this.ChkCupo.AutoSize = true;
            this.ChkCupo.Checked = true;
            this.ChkCupo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCupo.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.ChkCupo.ForeColor = System.Drawing.Color.White;
            this.ChkCupo.Location = new System.Drawing.Point(828, 272);
            this.ChkCupo.Name = "ChkCupo";
            this.ChkCupo.Size = new System.Drawing.Size(98, 22);
            this.ChkCupo.TabIndex = 126;
            this.ChkCupo.Text = "Disponible";
            this.ChkCupo.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.ChkCupo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbAvion);
            this.Controls.Add(this.TxtAsientosPremium);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtAsientosEconomicos);
            this.Controls.Add(this.TxtCantidadAsietos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbDespegue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.DtpFechaSalida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTarifa);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarVuelos";
            this.Text = "FrmAgregarVuelos";
            this.Load += new System.EventHandler(this.FrmAgregarVuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbAvion;
        private System.Windows.Forms.TextBox TxtAsientosPremium;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtAsientosEconomicos;
        private System.Windows.Forms.TextBox TxtCantidadAsietos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbDespegue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.DateTimePicker DtpFechaSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTarifa;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.CheckBox ChkCupo;
    }
}