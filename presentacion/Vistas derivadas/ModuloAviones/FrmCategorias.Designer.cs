namespace WindowsFormsApp1
{
    partial class FrmCategorias
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
            this.label4 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarifaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTarifa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(439, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 103;
            this.label4.Text = "Estado:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnActualizar.Location = new System.Drawing.Point(524, 452);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 46);
            this.BtnActualizar.TabIndex = 102;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnRegresar.Location = new System.Drawing.Point(10, 11);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 101;
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
            this.TxtNombre.Location = new System.Drawing.Point(554, 290);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(124, 24);
            this.TxtNombre.TabIndex = 100;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(436, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(530, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "Edición";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(520, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "Categorias";
            // 
            // DgvCategorias
            // 
            this.DgvCategorias.AllowUserToAddRows = false;
            this.DgvCategorias.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategoria,
            this.NombreCategoria,
            this.DescripcionCategoria,
            this.EstadoCategoria,
            this.TarifaCategoria,
            this.Comercial,
            this.FechaRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCategorias.EnableHeadersVisualStyles = false;
            this.DgvCategorias.Location = new System.Drawing.Point(191, 59);
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.RowHeadersVisible = false;
            this.DgvCategorias.Size = new System.Drawing.Size(763, 169);
            this.DgvCategorias.TabIndex = 94;
            this.DgvCategorias.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCategorias_CellMouseClick);
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "Id";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Width = 50;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Nombre";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            // 
            // DescripcionCategoria
            // 
            this.DescripcionCategoria.HeaderText = "Descripcion";
            this.DescripcionCategoria.Name = "DescripcionCategoria";
            this.DescripcionCategoria.ReadOnly = true;
            this.DescripcionCategoria.Width = 200;
            // 
            // EstadoCategoria
            // 
            this.EstadoCategoria.HeaderText = "Estado";
            this.EstadoCategoria.Name = "EstadoCategoria";
            this.EstadoCategoria.ReadOnly = true;
            this.EstadoCategoria.Width = 60;
            // 
            // TarifaCategoria
            // 
            this.TarifaCategoria.HeaderText = "Tarifa";
            this.TarifaCategoria.Name = "TarifaCategoria";
            this.TarifaCategoria.ReadOnly = true;
            // 
            // Comercial
            // 
            this.Comercial.HeaderText = "Comercial";
            this.Comercial.Name = "Comercial";
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 150;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.White;
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TxtDescripcion.Location = new System.Drawing.Point(554, 332);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(124, 24);
            this.TxtDescripcion.TabIndex = 110;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(436, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "Descripcion:";
            // 
            // TxtTarifa
            // 
            this.TxtTarifa.BackColor = System.Drawing.Color.White;
            this.TxtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTarifa.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtTarifa.ForeColor = System.Drawing.Color.Black;
            this.TxtTarifa.Location = new System.Drawing.Point(554, 374);
            this.TxtTarifa.Name = "TxtTarifa";
            this.TxtTarifa.Size = new System.Drawing.Size(124, 24);
            this.TxtTarifa.TabIndex = 112;
            this.TxtTarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTarifa_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(436, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 111;
            this.label5.Text = "Tarifa (%): ";
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.Checked = true;
            this.ChkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.ChkEstado.ForeColor = System.Drawing.Color.Black;
            this.ChkEstado.Location = new System.Drawing.Point(554, 414);
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Size = new System.Drawing.Size(70, 22);
            this.ChkEstado.TabIndex = 113;
            this.ChkEstado.Text = "Activo";
            this.ChkEstado.UseVisualStyleBackColor = true;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.ChkEstado);
            this.Controls.Add(this.TxtTarifa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategorias";
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTarifa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarifaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}