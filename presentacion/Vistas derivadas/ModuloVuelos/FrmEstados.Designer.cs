namespace WindowsFormsApp1
{
    partial class FrmEstados
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvEstados = new System.Windows.Forms.DataGridView();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetencionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminarVuelo = new System.Windows.Forms.Button();
            this.BtnEditarVuelo = new System.Windows.Forms.Button();
            this.BtnAgregarVuelo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RbDetencion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 69;
            this.BtnRegresar.Text = "<Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "Estados";
            // 
            // DgvEstados
            // 
            this.DgvEstados.AllowUserToAddRows = false;
            this.DgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstado,
            this.NombreEstado,
            this.DescripcionEstado,
            this.DetencionEstado,
            this.FechaRegistro});
            this.DgvEstados.Location = new System.Drawing.Point(43, 48);
            this.DgvEstados.Name = "DgvEstados";
            this.DgvEstados.Size = new System.Drawing.Size(704, 384);
            this.DgvEstados.TabIndex = 62;
            this.DgvEstados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEstados_CellMouseClick);
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "Id";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Width = 80;
            // 
            // NombreEstado
            // 
            this.NombreEstado.HeaderText = "Nombre";
            this.NombreEstado.Name = "NombreEstado";
            this.NombreEstado.ReadOnly = true;
            this.NombreEstado.Width = 150;
            // 
            // DescripcionEstado
            // 
            this.DescripcionEstado.HeaderText = "Descripcion";
            this.DescripcionEstado.Name = "DescripcionEstado";
            this.DescripcionEstado.ReadOnly = true;
            this.DescripcionEstado.Width = 80;
            // 
            // DetencionEstado
            // 
            this.DetencionEstado.HeaderText = "Detencion";
            this.DetencionEstado.Name = "DetencionEstado";
            this.DetencionEstado.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 250;
            // 
            // BtnEliminarVuelo
            // 
            this.BtnEliminarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVuelo.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarVuelo.Location = new System.Drawing.Point(331, 438);
            this.BtnEliminarVuelo.Name = "BtnEliminarVuelo";
            this.BtnEliminarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminarVuelo.TabIndex = 75;
            this.BtnEliminarVuelo.Text = "Eliminar";
            this.BtnEliminarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnEditarVuelo
            // 
            this.BtnEditarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEditarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarVuelo.ForeColor = System.Drawing.Color.White;
            this.BtnEditarVuelo.Location = new System.Drawing.Point(939, 328);
            this.BtnEditarVuelo.Name = "BtnEditarVuelo";
            this.BtnEditarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnEditarVuelo.TabIndex = 74;
            this.BtnEditarVuelo.Text = "Actualizar";
            this.BtnEditarVuelo.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarVuelo
            // 
            this.BtnAgregarVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarVuelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarVuelo.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarVuelo.Location = new System.Drawing.Point(785, 328);
            this.BtnAgregarVuelo.Name = "BtnAgregarVuelo";
            this.BtnAgregarVuelo.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregarVuelo.TabIndex = 73;
            this.BtnAgregarVuelo.Text = "Agregar";
            this.BtnAgregarVuelo.UseVisualStyleBackColor = false;
            this.BtnAgregarVuelo.Click += new System.EventHandler(this.BtnAgregarVuelo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(784, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Descripcion:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(902, 177);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(156, 24);
            this.TxtNombre.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(784, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(883, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "Gestión";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDescripcion.ForeColor = System.Drawing.Color.White;
            this.TxtDescripcion.Location = new System.Drawing.Point(904, 226);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(156, 24);
            this.TxtDescripcion.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(782, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Detencion:";
            // 
            // RbDetencion
            // 
            this.RbDetencion.AutoSize = true;
            this.RbDetencion.Location = new System.Drawing.Point(902, 278);
            this.RbDetencion.Name = "RbDetencion";
            this.RbDetencion.Size = new System.Drawing.Size(14, 13);
            this.RbDetencion.TabIndex = 83;
            this.RbDetencion.TabStop = true;
            this.RbDetencion.UseVisualStyleBackColor = true;
            // 
            // FrmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.RbDetencion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEliminarVuelo);
            this.Controls.Add(this.BtnEditarVuelo);
            this.Controls.Add(this.BtnAgregarVuelo);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvEstados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstados";
            this.Text = "FrmEstados";
            this.Load += new System.EventHandler(this.FrmEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvEstados;
        private System.Windows.Forms.Button BtnEliminarVuelo;
        private System.Windows.Forms.Button BtnEditarVuelo;
        private System.Windows.Forms.Button BtnAgregarVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetencionEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbDetencion;
    }
}