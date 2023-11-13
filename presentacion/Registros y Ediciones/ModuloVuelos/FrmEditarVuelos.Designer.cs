namespace WindowsFormsApp1
{
    partial class FrmEditarVuelos
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
            this.label8 = new System.Windows.Forms.Label();
            this.CbDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbDespegue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.DtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTarifa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbAvion = new System.Windows.Forms.ComboBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.ChkCupo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(625, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 81;
            this.label8.Text = "Destino:";
            // 
            // CbDestino
            // 
            this.CbDestino.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDestino.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbDestino.ForeColor = System.Drawing.Color.White;
            this.CbDestino.FormattingEnabled = true;
            this.CbDestino.Location = new System.Drawing.Point(837, 209);
            this.CbDestino.Name = "CbDestino";
            this.CbDestino.Size = new System.Drawing.Size(200, 24);
            this.CbDestino.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(625, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 79;
            this.label5.Text = "Despegue:";
            // 
            // CbDespegue
            // 
            this.CbDespegue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbDespegue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDespegue.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbDespegue.ForeColor = System.Drawing.Color.White;
            this.CbDespegue.FormattingEnabled = true;
            this.CbDespegue.Location = new System.Drawing.Point(837, 133);
            this.CbDespegue.Name = "CbDespegue";
            this.CbDespegue.Size = new System.Drawing.Size(200, 24);
            this.CbDespegue.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(81, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtPrecio.ForeColor = System.Drawing.Color.White;
            this.TxtPrecio.Location = new System.Drawing.Point(312, 61);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(200, 24);
            this.TxtPrecio.TabIndex = 76;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.Location = new System.Drawing.Point(12, 11);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 75;
            this.BtnRegresar.Text = "<Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DtpFechaSalida
            // 
            this.DtpFechaSalida.CalendarForeColor = System.Drawing.Color.White;
            this.DtpFechaSalida.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.DtpFechaSalida.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpFechaSalida.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DtpFechaSalida.CustomFormat = "d/MM/yyyy HH:mm";
            this.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaSalida.Location = new System.Drawing.Point(312, 215);
            this.DtpFechaSalida.Name = "DtpFechaSalida";
            this.DtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaSalida.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "Fecha y hora salida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(625, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Cupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(81, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 71;
            this.label4.Text = "Descuento:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDescuento.ForeColor = System.Drawing.Color.White;
            this.TxtDescuento.Location = new System.Drawing.Point(312, 134);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(200, 24);
            this.TxtDescuento.TabIndex = 70;
            this.TxtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescuento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(499, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 68;
            this.label3.Text = "Editar vuelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(625, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tarifa:";
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTarifa.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtTarifa.ForeColor = System.Drawing.Color.White;
            this.TxtTarifa.Location = new System.Drawing.Point(837, 61);
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Size = new System.Drawing.Size(200, 24);
            this.TxtTarifa.TabIndex = 66;
            this.TxtTarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTarifa_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(621, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 97;
            this.label10.Text = "Estado";
            // 
            // CbEstado
            // 
            this.CbEstado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbEstado.ForeColor = System.Drawing.Color.White;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(837, 419);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(200, 24);
            this.CbEstado.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(621, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "Avion:";
            // 
            // CbAvion
            // 
            this.CbAvion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbAvion.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAvion.ForeColor = System.Drawing.Color.White;
            this.CbAvion.FormattingEnabled = true;
            this.CbAvion.Location = new System.Drawing.Point(837, 348);
            this.CbAvion.Name = "CbAvion";
            this.CbAvion.Size = new System.Drawing.Size(200, 24);
            this.CbAvion.TabIndex = 94;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(513, 466);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 46);
            this.BtnActualizar.TabIndex = 123;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // ChkCupo
            // 
            this.ChkCupo.AutoSize = true;
            this.ChkCupo.Checked = true;
            this.ChkCupo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCupo.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.ChkCupo.ForeColor = System.Drawing.Color.White;
            this.ChkCupo.Location = new System.Drawing.Point(837, 288);
            this.ChkCupo.Name = "ChkCupo";
            this.ChkCupo.Size = new System.Drawing.Size(98, 22);
            this.ChkCupo.TabIndex = 125;
            this.ChkCupo.Text = "Disponible";
            this.ChkCupo.UseVisualStyleBackColor = true;
            // 
            // FrmEditarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.ChkCupo);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbAvion);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTarifa);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarVuelos";
            this.Text = "FrmEditarVuelos";
            this.Load += new System.EventHandler(this.FrmEditarVuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbDespegue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DateTimePicker DtpFechaSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTarifa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbAvion;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.CheckBox ChkCupo;
    }
}