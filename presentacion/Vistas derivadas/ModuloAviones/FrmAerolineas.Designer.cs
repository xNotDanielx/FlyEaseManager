namespace WindowsFormsApp1
{
    partial class FrmAerolineas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvAerolineas = new System.Windows.Forms.DataGridView();
            this.IdAeolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoIATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCodigoIATA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodigoICAO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAerolineas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnActualizar.Location = new System.Drawing.Point(944, 327);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 46);
            this.BtnActualizar.TabIndex = 72;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 69;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(909, 188);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(156, 24);
            this.TxtNombre.TabIndex = 68;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(791, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(883, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Gestión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(402, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "Aerolineas";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnEliminar.Location = new System.Drawing.Point(396, 438);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminar.TabIndex = 64;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnAgregar.Location = new System.Drawing.Point(794, 327);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregar.TabIndex = 63;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvAerolineas
            // 
            this.DgvAerolineas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvAerolineas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAerolineas.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAerolineas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAerolineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAeolinea,
            this.NombreAerolinea,
            this.CodigoIATA,
            this.CodigoICAO,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAerolineas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAerolineas.EnableHeadersVisualStyles = false;
            this.DgvAerolineas.Location = new System.Drawing.Point(168, 48);
            this.DgvAerolineas.Name = "DgvAerolineas";
            this.DgvAerolineas.RowHeadersVisible = false;
            this.DgvAerolineas.Size = new System.Drawing.Size(563, 384);
            this.DgvAerolineas.TabIndex = 62;
            this.DgvAerolineas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAerolineas_CellMouseClick);
            // 
            // IdAeolinea
            // 
            this.IdAeolinea.HeaderText = "Id";
            this.IdAeolinea.Name = "IdAeolinea";
            this.IdAeolinea.ReadOnly = true;
            this.IdAeolinea.Width = 50;
            // 
            // NombreAerolinea
            // 
            this.NombreAerolinea.HeaderText = "Nombre";
            this.NombreAerolinea.Name = "NombreAerolinea";
            this.NombreAerolinea.ReadOnly = true;
            // 
            // CodigoIATA
            // 
            this.CodigoIATA.HeaderText = "CodigoIATA";
            this.CodigoIATA.Name = "CodigoIATA";
            this.CodigoIATA.ReadOnly = true;
            this.CodigoIATA.Width = 80;
            // 
            // CodigoICAO
            // 
            this.CodigoICAO.HeaderText = "CodigoICAO";
            this.CodigoICAO.Name = "CodigoICAO";
            this.CodigoICAO.ReadOnly = true;
            this.CodigoICAO.Width = 80;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 250;
            // 
            // TxtCodigoIATA
            // 
            this.TxtCodigoIATA.BackColor = System.Drawing.Color.White;
            this.TxtCodigoIATA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoIATA.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtCodigoIATA.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoIATA.Location = new System.Drawing.Point(909, 234);
            this.TxtCodigoIATA.Name = "TxtCodigoIATA";
            this.TxtCodigoIATA.Size = new System.Drawing.Size(156, 24);
            this.TxtCodigoIATA.TabIndex = 74;
            this.TxtCodigoIATA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoIATA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(791, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "CodigoIATA:";
            // 
            // TxtCodigoICAO
            // 
            this.TxtCodigoICAO.BackColor = System.Drawing.Color.White;
            this.TxtCodigoICAO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoICAO.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtCodigoICAO.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoICAO.Location = new System.Drawing.Point(909, 281);
            this.TxtCodigoICAO.Name = "TxtCodigoICAO";
            this.TxtCodigoICAO.Size = new System.Drawing.Size(156, 24);
            this.TxtCodigoICAO.TabIndex = 76;
            this.TxtCodigoICAO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoICAO_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(791, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 75;
            this.label5.Text = "CodigoICAO:";
            // 
            // FrmAerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.TxtCodigoICAO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCodigoIATA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvAerolineas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAerolineas";
            this.Text = "FrmAerolineas";
            this.Load += new System.EventHandler(this.FrmAerolineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAerolineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvAerolineas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoIATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.TextBox TxtCodigoIATA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodigoICAO;
        private System.Windows.Forms.Label label5;
    }
}