namespace WindowsFormsApp1
{
    partial class FrmCiudades
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
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.Location = new System.Drawing.Point(12, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(62, 23);
            this.BtnRegresar.TabIndex = 56;
            this.BtnRegresar.Text = "<Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtFecha.ForeColor = System.Drawing.Color.White;
            this.TxtFecha.Location = new System.Drawing.Point(941, 255);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(156, 24);
            this.TxtFecha.TabIndex = 55;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(941, 192);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(156, 24);
            this.TxtNombre.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(823, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fecha registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(823, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(915, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Edición";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ciudades";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(543, 438);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 46);
            this.BtnEliminar.TabIndex = 49;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(226, 438);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 46);
            this.BtnAgregar.TabIndex = 48;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 384);
            this.dataGridView1.TabIndex = 47;
            // 
            // FrmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCiudades";
            this.Text = "FrmCiudades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}