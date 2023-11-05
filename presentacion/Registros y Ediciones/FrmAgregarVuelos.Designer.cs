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
            this.TxtTarifa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbCupo = new System.Windows.Forms.ComboBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbDespegue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbDestino = new System.Windows.Forms.ComboBox();
            this.DtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTarifa.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtTarifa.ForeColor = System.Drawing.Color.White;
            this.TxtTarifa.Location = new System.Drawing.Point(827, 87);
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Size = new System.Drawing.Size(200, 32);
            this.TxtTarifa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(639, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarifa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(455, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registrar de vuelo";
            // 
            // CbCupo
            // 
            this.CbCupo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbCupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbCupo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.CbCupo.ForeColor = System.Drawing.Color.White;
            this.CbCupo.FormattingEnabled = true;
            this.CbCupo.Location = new System.Drawing.Point(827, 415);
            this.CbCupo.Name = "CbCupo";
            this.CbCupo.Size = new System.Drawing.Size(200, 31);
            this.CbCupo.TabIndex = 8;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtDescuento.ForeColor = System.Drawing.Color.White;
            this.TxtDescuento.Location = new System.Drawing.Point(306, 200);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(200, 32);
            this.TxtDescuento.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(118, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descuento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(639, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cupo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(118, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha y hora salida:";
            // 
            // DtpFechaSalida
            // 
            this.DtpFechaSalida.CalendarForeColor = System.Drawing.Color.White;
            this.DtpFechaSalida.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.DtpFechaSalida.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpFechaSalida.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DtpFechaSalida.CustomFormat = "d/MM/yyyy HH:mm";
            this.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaSalida.Location = new System.Drawing.Point(306, 324);
            this.DtpFechaSalida.Name = "DtpFechaSalida";
            this.DtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaSalida.TabIndex = 15;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(118, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtPrecio.ForeColor = System.Drawing.Color.White;
            this.TxtPrecio.Location = new System.Drawing.Point(306, 87);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(200, 32);
            this.TxtPrecio.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(639, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "Despegue:";
            // 
            // CbDespegue
            // 
            this.CbDespegue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbDespegue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDespegue.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.CbDespegue.ForeColor = System.Drawing.Color.White;
            this.CbDespegue.FormattingEnabled = true;
            this.CbDespegue.Location = new System.Drawing.Point(827, 199);
            this.CbDespegue.Name = "CbDespegue";
            this.CbDespegue.Size = new System.Drawing.Size(200, 31);
            this.CbDespegue.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(639, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Destino:";
            // 
            // CbDestino
            // 
            this.CbDestino.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDestino.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.CbDestino.ForeColor = System.Drawing.Color.White;
            this.CbDestino.FormattingEnabled = true;
            this.CbDestino.Location = new System.Drawing.Point(827, 313);
            this.CbDestino.Name = "CbDestino";
            this.CbDestino.Size = new System.Drawing.Size(200, 31);
            this.CbDestino.TabIndex = 62;
            // 
            // DtpFechaLlegada
            // 
            this.DtpFechaLlegada.CalendarForeColor = System.Drawing.Color.White;
            this.DtpFechaLlegada.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.DtpFechaLlegada.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpFechaLlegada.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DtpFechaLlegada.CustomFormat = "d/MM/yyyy HH:mm";
            this.DtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaLlegada.Location = new System.Drawing.Point(306, 418);
            this.DtpFechaLlegada.Name = "DtpFechaLlegada";
            this.DtpFechaLlegada.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaLlegada.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(118, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "Fecha y hora llegada:";
            // 
            // FrmAgregarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.DtpFechaLlegada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbDespegue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DtpFechaSalida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.CbCupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTarifa);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarVuelos";
            this.Text = "FrmAgregarVuelos";
            this.Load += new System.EventHandler(this.FrmAgregarVuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTarifa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbCupo;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpFechaSalida;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbDespegue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbDestino;
        private System.Windows.Forms.DateTimePicker DtpFechaLlegada;
        private System.Windows.Forms.Label label9;
    }
}